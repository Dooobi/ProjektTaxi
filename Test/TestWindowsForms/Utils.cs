using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using System.Net;
using System.Xml.Linq;

namespace TestWindowsForms
{
    public class Utils
    {
        public static List<PointLatLng> GetRoutePoints(string start, string end)
        {
            string requestUri = string.Format("https://maps.googleapis.com/maps/api/directions/xml?origin={0}&destination={1}", Uri.EscapeDataString(start), Uri.EscapeDataString(end));
            WebRequest request = WebRequest.Create(requestUri);
            WebResponse response = request.GetResponse();
            XDocument xdoc = XDocument.Load(response.GetResponseStream());

            List<PointLatLng> points = new List<PointLatLng>();
            XElement result = xdoc.Element("DirectionsResponse").Element("route").Element("leg");

            PointLatLng point;
            XElement end_location = null;
            double lat, lng;
            string poly;

            foreach (XElement step in result.Elements("step"))
            {
                //XElement start_location = step.Element("start_location");
                //end_location = step.Element("end_location");
                //lat = Convert.ToDouble(start_location.Element("lat").Value.Replace(".", ","));
                //lng = Convert.ToDouble(start_location.Element("lng").Value.Replace(".", ","));
                //point = new PointLatLng(lat, lng);
                //points.Add(point);

                poly = step.Element("polyline").Element("points").Value;
                points.AddRange(DecodePoly(poly));
            }
            //lat = Convert.ToDouble(end_location.Element("lat").Value.Replace(".", ","));
            //lng = Convert.ToDouble(end_location.Element("lng").Value.Replace(".", ","));

            //point = new PointLatLng(lat, lng);
            //points.Add(point);

            return points;
        }

        /**
        * Method to decode polyline points
        * Courtesy : jeffreysambells.com/2010/05/27/decoding-polylines-from-google-maps-direction-api-with-java
        * */
        public static List<PointLatLng> DecodePoly(String encoded)
        {

            List<PointLatLng> poly = new List<PointLatLng>();
            int index = 0, len = encoded.Length;
            int lat = 0, lng = 0;

            while (index < len)
            {
                int b, shift = 0, result = 0;
                do
                {
                    b = encoded[index++] - 63;
                    result |= (b & 0x1f) << shift;
                    shift += 5;
                } while (b >= 0x20);
                int dlat = ((result & 1) != 0 ? ~(result >> 1) : (result >> 1));
                lat += dlat;

                shift = 0;
                result = 0;
                do
                {
                    b = encoded[index++] - 63;
                    result |= (b & 0x1f) << shift;
                    shift += 5;
                } while (b >= 0x20);
                int dlng = ((result & 1) != 0 ? ~(result >> 1) : (result >> 1));
                lng += dlng;

                PointLatLng p = new PointLatLng((((double)lat / 1E5)), (((double)lng / 1E5)));
                poly.Add(p);
            }

            return poly;
        }

        public static List<PointLatLng> GetNewRoute(List<PointLatLng> points, double distance)
        {
            PointLatLng current, next;
            double currentDist = 0, prevDist = 0;

            for (int i = 0; i < points.Count; i++)
            {
                prevDist = currentDist;
                current = points[i];
                if (i < points.Count - 1)
                {
                    next = points[i + 1];
                    currentDist += GMapProviders.EmptyProvider.Projection.GetDistance(current, next);
                    if (currentDist >= distance)
                    {
                        PointLatLng point = GetPointBetweenTwoPoints(current, next, distance - prevDist);
                        List<PointLatLng> newRoute = new List<PointLatLng>(points);
                        newRoute.RemoveRange(0, i+1);
                        newRoute.Insert(0, point);

                        return newRoute;
                    }
                }
                else
                {
                    return new List<PointLatLng>();
                }
            }

            return new List<PointLatLng>();
        }

        public static PointLatLng GetPointBetweenTwoPoints(PointLatLng start, PointLatLng end, double distance)
        {
            double lat, lng;
            double distancePercentage = distance / GMapProviders.EmptyProvider.Projection.GetDistance(start, end);
            if (distancePercentage >= 1)
            {
                return new PointLatLng(end.Lat, end.Lng);
            }
            lat = Math.Abs(start.Lat - end.Lat) * distancePercentage;
            lng = Math.Abs(start.Lng - end.Lng) * distancePercentage;
            PointLatLng point = new PointLatLng(Math.Min(start.Lat, end.Lat) + lat, Math.Min(start.Lng, end.Lng) + lng);
            return point;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Net;
using System.Xml.Linq;


namespace TestWindowsForms
{
    public partial class Form1 : Form
    {
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
        }
        GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
   //     GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(49.773111, 9.940927), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
            

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            System.Net.WebProxy myProxy = new System.Net.WebProxy("172.16.111.1", 3128);
            //GMap.NET.MapProviders.GMapProvider.WebProxy = myProxy;
            gmap.SetPositionByKeywords("Stettiner Straße 1, 97082, Deutschland");
            //gmap.Position = new GMap.NET.PointLatLng(48.8589507, 2.2775175);
            gmap.ShowCenter = false;
            gmap.Zoom = 13;

            Init();

        }

        private void Init()
        {
           // string start = "Königsberger Str. 6, 97072 Würzburg";
            string end = "Goethestr. 56, 97493 Bergrheinfeld";
            string start = "Stettiner Str. 1, 97072 Würzburg";

            List<PointLatLng> route = Utils.GetRoutePoints(start, end);
            GMapRoute r = new GMapRoute(route, "My route");

            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            gmap.Overlays.Add(routesOverlay);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            GMapRoute r;


            String straße = textBox_straße.Text;
            String plz = textBox_plz.Text;

            StringBuilder querryadress = new StringBuilder();
            querryadress.Append(straße + ", ");
            querryadress.Append(plz);

            gmap.SetPositionByKeywords(querryadress.ToString());

            
            gmap.Overlays.Add(markers);
            

        }

       

        private void gmap_OnMarkerClick(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {

         //   Berechnung berechnung = new Berechnung();
         //   berechnung.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateRoute("test");
        }

        private void UpdateRoute(string routeId)
        {
            GMapOverlay overlay = null;
            GMapRoute route = null;

            foreach (GMapOverlay o in gmap.Overlays)
            {
                if (o.Id == "routes")
                {
                    overlay = o;
                    foreach (GMapRoute r in o.Routes)
                    {
                        if (r.Name == routeId)
                        {
                            route = r;
                        }
                    }
                }
            }

            if (overlay == null) return;
            if (route == null) return;

            overlay.Routes.Remove(route);

            route = new GMapRoute(Utils.GetNewRoute(route.Points, 0.1), routeId);
            if (route.Points.Count == 0)
                label2.Text = "Destination reached!";
            
            overlay.Routes.Add(route);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateRoute("My route");
        }

        
    }
}

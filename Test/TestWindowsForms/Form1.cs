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
using TaxiDLL;


namespace TestWindowsForms
{
    public partial class Form1 : Form
    {
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
            GMap.NET.MapProviders.GMapProvider.WebProxy = myProxy;
            gmap.SetPositionByKeywords("Stettiner Straße 1, 97082, Deutschland");
            //gmap.Position = new GMap.NET.PointLatLng(48.8589507, 2.2775175);
            gmap.ShowCenter = false;
            gmap.Zoom = 13;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Datenzugriff dz = new Datenzugriff();
            List<Taxi> taxiListe = dz.getTaxis();

            foreach(Taxi taxi in taxiListe){

            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(taxi.Longitude, taxi.Latitude), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue);
            markers.Markers.Add(marker);

            }


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
    }
}

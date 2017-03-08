using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

            // Overlay und Markers
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
     
            GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(1, 1), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.green);

        

          


        }
    }
}

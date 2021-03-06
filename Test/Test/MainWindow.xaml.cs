﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gmap.Position = new GMap.NET.PointLatLng(48.8589507, 2.2775175);
        }
    }
}

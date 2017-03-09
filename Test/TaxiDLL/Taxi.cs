using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDLL
{
    class Taxi
    {

        public int TaxiID { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }


        public Taxi(int taxiID, double longitude, double latitude)
        {
            TaxiID = taxiID;
            Longitude = longitude;
            Latitude = latitude;

        }


    }
}

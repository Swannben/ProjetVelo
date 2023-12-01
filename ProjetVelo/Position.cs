using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProjetVelo
{
    public class Position
    {
         public float lat { get; set; }
         public float lng { get; set; }

        public GeoCoordinate GetGeoCoordinate()
        {
            return new GeoCoordinate(lat, lng);
        }
           
    }
}

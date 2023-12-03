using System.Device.Location;

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

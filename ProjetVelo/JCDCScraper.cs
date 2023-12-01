using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProjetVelo
{
    internal class JCDCScraper
    {
        public const string BaseUrl = "https://api.jcdecaux.com/vls/v1/stations?apiKey=32c48bc84a5d88c6a0ae509ce8c833d0243ec6b7";
        private readonly HttpClient _client;

        public JCDCScraper()
        {
            this._client = new HttpClient();
        }

        private string getStationsResponse(string city)
        {
            return this._client.GetStringAsync($"{BaseUrl}&contract={city}").Result;
        }

        // Parser le JSON
        // Retourner une liste de stations
        private List<Station> parse(string response)
        {
            return JsonConvert.DeserializeObject<List<Station>>(response);
        }

        public List<Station> getStations(string city)
        {
            return parse(getStationsResponse(city));
        }

        public static Station findClosestStation(GeoCoordinate chosenLocation, List<Station> stations)
        {
            double closestDistance = double.MaxValue;
            Station closestStation = null;
            GeoCoordinate stationLocation;
            foreach (var station in stations)
            {

                stationLocation = new GeoCoordinate(station.position.lat, station.position.lng);
                double distance = chosenLocation.GetDistanceTo(stationLocation);

                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestStation = station;
                }
            }

            return closestStation;
        }
    }
}
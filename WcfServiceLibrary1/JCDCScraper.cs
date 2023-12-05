using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Net.Http;
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

        private async Task<string> getStationsResponseAsync(string city)
        {
            Console.Write("Searching ");
            Console.Write(city);
            Console.Write("...\n");
            HttpResponseMessage response = await this._client.GetAsync($"{BaseUrl}&contract={city}");
            Console.Write("city found !\n");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("success status code!");
                string toreturn = await response.Content.ReadAsStringAsync();
                if (toreturn!= "[]")
                    return toreturn;
            }
            Console.WriteLine("not success status code");
            response = await this._client.GetAsync($"{BaseUrl}");
            Console.WriteLine("still not success");
            if (response.IsSuccessStatusCode)
            {
                string toreturn = await response.Content.ReadAsStringAsync();
                Console.WriteLine("returning every stations");
                return toreturn;
            }
            Console.Write("no Contracts in this city\n");
            throw new System.Exception("your city doesnt have a contract");
        }

        // Parser le JSON
        // Retourner une liste de stations
        private List<Station> parse(string response)
        {
            Console.WriteLine($"on a une reponse");
            List<Station> result = JsonConvert.DeserializeObject<List<Station>>(response);
            Console.WriteLine($"json converted succesfully !");
            if (result != null) { 
                Console.WriteLine("parse complete !");
                return result; }
            Console.WriteLine("could not understand the bike data");
            throw new System.Exception("could not understand the bike data");
        }

        public async Task<List<Station>> getStationsAsync(string city)
        {
            string stationsResponse = await getStationsResponseAsync(city);
            return parse(stationsResponse);
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

                if (distance < closestDistance && station.available_bikes>0)
                {
                    closestDistance = distance;
                    closestStation = station;
                }
            }

            return closestStation;
        }


        public static Station findClosestStationEnd(GeoCoordinate chosenLocation, List<Station> stations)
        {
            double closestDistance = double.MaxValue;
            Station closestStation = null;
            GeoCoordinate stationLocation;
            foreach (var station in stations)
            {

                stationLocation = new GeoCoordinate(station.position.lat, station.position.lng);
                double distance = chosenLocation.GetDistanceTo(stationLocation);

                if (distance < closestDistance && station.available_bike_stands > 0)
                {
                    closestDistance = distance;
                    closestStation = station;
                }
            }

            return closestStation;
        }


    }
}
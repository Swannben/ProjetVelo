using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProjetVelo
{
    internal class NominatimScraper
    {
        string BaseUrl = "https://nominatim.openstreetmap.org";
        private readonly HttpClient _client;

        public NominatimScraper()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("User-Agent", "ProjetVeloSwann");
        }

        public async Task<GeoCoordinate> getPositionFromAdressAsync(string address)
        {
            string FormatedAddress = Uri.EscapeDataString(address);
            HttpResponseMessage response = await _client.GetAsync($"{BaseUrl}/search?q={address.Replace(",", "")}&format=json");
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                List<Class1> addressJson = System.Text.Json.JsonSerializer.Deserialize<List<Class1>>(responseString);
                Class1 parsedaddress = addressJson.FirstOrDefault();
                return new GeoCoordinate(Double.Parse(parsedaddress.lat.Replace(".", ",")), Double.Parse(parsedaddress.lon.Replace(".", ",")));
            }
            throw new Exception("can't find the address you searched");

        }

        public async Task<string> getCityFromPosition(GeoCoordinate geoCoordinate)
        {
            Console.Write($"recherche de ville aux coordonées{geoCoordinate}");
            double latitude = geoCoordinate.Latitude;
            string latString = latitude.ToString().Replace(",", ".");
            double longitude = geoCoordinate.Longitude;
            string longString = longitude.ToString().Replace(",", ".");
            var json =  await (_client.GetStringAsync($"{BaseUrl}/reverse?lat={latString}&lon={longString}&format=json"));
            var parsedJson = JToken.Parse(json);


            if (parsedJson is JArray)
                parsedJson = parsedJson.FirstOrDefault();
            else if (parsedJson is JObject)
                parsedJson = parsedJson;
            else
                throw new NoCityException("could not find your position, try again");


            var address = parsedJson["address"];

            string city = (string)address?["municipality"] ??(string)address?["city"] ?? (string)address?["town"] ?? (string)address?["village"];

            if (city == null)
            {
                throw new NoCityException("there was no city in your adress");
            }

            return city;
        }


    }

    public class baseObject
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int place_id { get; set; }
        public string licence { get; set; }
        public string osm_type { get; set; }
        public long osm_id { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string _class { get; set; }
        public string type { get; set; }
        public int place_rank { get; set; }
        public float importance { get; set; }
        public string addresstype { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
        public string[] boundingbox { get; set; }
    }

}

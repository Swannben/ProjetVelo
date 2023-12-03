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
            HttpResponseMessage response = await _client.GetAsync($"{BaseUrl}/search?q={address.Replace(",", "")}");
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                List<AddressJsonClass> addressJson = System.Text.Json.JsonSerializer.Deserialize<List<AddressJsonClass>>(responseString);
                AddressJsonClass parsedaddress = addressJson.FirstOrDefault();
                return new GeoCoordinate(Double.Parse(parsedaddress.lat), Double.Parse(parsedaddress.lon));
            }
            throw new Exception("can't find the address you searched");

        }

        public string getCityFromPosition(GeoCoordinate geoCoordinate)
        {
            double latitude = geoCoordinate.Latitude;
            string latString = latitude.ToString();
            double longitude = geoCoordinate.Longitude;
            string longString = longitude.ToString();
            var json = (_client.GetStringAsync($"{BaseUrl}/reverse?lat={latString}&lon={longString}").Result);
            var parsedJson = JToken.Parse(json);


            if (parsedJson is JArray)
                parsedJson = parsedJson.FirstOrDefault();
            else if (parsedJson is JObject)
                parsedJson = parsedJson;
            else
                throw new NoCityException("could not find your position, try again");


            var address = parsedJson["address"];

            string city = (string)address?["city"] ?? (string)address?["town"] ?? (string)address?["village"];

            if (city == null)
            {
                throw new NoCityException("there was no city in your adress");
            }

            return city;
        }


    }
    public class AddressJsonClass
    {
        public int place_id { get; set; }
        public string licence { get; set; }
        public string osm_type { get; set; }
        public int osm_id { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string @class { get; set; }
        public string type { get; set; }
        public int place_rank { get; set; }
        public double importance { get; set; }
        public string addresstype { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
        public List<string> boundingbox { get; set; }
    }
}

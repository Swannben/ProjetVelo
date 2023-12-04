using Newtonsoft.Json;
using System;
using System.Device.Location;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ProjetVelo
{
    internal class OpenStreetMapScraper
    {
        public const string BaseUrl = "https://api.openrouteservice.org/v2/directions/";
        public const string apiKey = "5b3ce3597851110001cf62480900d8bcff7e482fb4714b6491a71155";
        private readonly HttpClient _client;

        public OpenStreetMapScraper()
        {
            _client = new HttpClient();
        }

        public async Task<string> getWalkingDirectionsAsync(GeoCoordinate start, GeoCoordinate end)
        {
            string startString = $"{start.Longitude.ToString().Replace(",",".")},{start.Latitude.ToString().Replace(",",".")}";
            string endString = $"{end.Longitude.ToString().Replace(",", ".")},{end.Latitude.ToString().Replace(",", ".")}";
            HttpResponseMessage response = await this._client.GetAsync($"{BaseUrl}foot-walking?api_key={apiKey}&start={startString}&end={endString}");
            if (response.IsSuccessStatusCode)
            {

                string toreturn = await  response.Content.ReadAsStringAsync();
                return toreturn;
            }
            throw new Exception("couldn't get your walking directions");
        }

        public async Task<string> getCyclingDirectionsAsync(GeoCoordinate start, GeoCoordinate end)
        {

            string startString = $"{start.Longitude.ToString().Replace(",", ".")},{start.Latitude.ToString().Replace(",", ".")}";
            string endString = $"{end.Longitude.ToString().Replace(",", ".")},{end.Latitude.ToString().Replace(",", ".")}";
            HttpResponseMessage response = await this._client.GetAsync($"{BaseUrl}cycling-road?api_key={apiKey}&start={startString}&end={endString}");
            if (response.IsSuccessStatusCode)
            {
                string toreturn = await response.Content.ReadAsStringAsync();
                return toreturn;
            }

            throw new Exception("couldn't get your cycling directions");
        }

        private Feature GetFeature(string response)
        {

            Rootobject root = JsonConvert.DeserializeObject<Rootobject>(response);
            Feature feature = root.features.FirstOrDefault();
            return feature;
        }

        public async Task<Feature> GetFeatureWalk(GeoCoordinate start, GeoCoordinate end)
        {
            string walkingDirections = await  getWalkingDirectionsAsync(start, end);
            return GetFeature(walkingDirections);
        }

        public async Task<Feature> GetFeatureCycle(GeoCoordinate start, GeoCoordinate end)
        {
            string cyclingDirections = await getCyclingDirectionsAsync(start, end);
            return GetFeature(cyclingDirections);
        }


    }


    public class Rootobject
    {
        public string type { get; set; }
        public Metadata metadata { get; set; }
        public float[] bbox { get; set; }
        public Feature[] features { get; set; }
    }

    public class Metadata
    {
        public string attribution { get; set; }
        public string service { get; set; }
        public long timestamp { get; set; }
        public Query query { get; set; }
        public Engine engine { get; set; }
    }

    public class Query
    {
        public float[][] coordinates { get; set; }
        public string profile { get; set; }
        public string format { get; set; }
    }

    public class Engine
    {
        public string version { get; set; }
        public DateTime build_date { get; set; }
        public DateTime graph_date { get; set; }
    }

    public class Feature
    {
        public float[] bbox { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
        public Geometry geometry { get; set; }
    }

    public class Properties
    {
        public int transfers { get; set; }
        public int fare { get; set; }
        public Segment[] segments { get; set; }
        public int[] way_points { get; set; }
        public Summary summary { get; set; }
    }

    public class Summary
    {
        public float distance { get; set; }
        public float duration { get; set; }
    }

    public class Segment
    {
        public float distance { get; set; }
        public float duration { get; set; }
        public Step[] steps { get; set; }
    }

    [DataContractAttribute]
    public class Step
    {
        public Step(string instruction, string name)
        {
            distance = 0;
            duration = 0;
            this.instruction = instruction;
            this.name = name;
        }
        [DataMemberAttribute] public float distance { get; set; }
        [DataMemberAttribute] public float duration { get; set; }
        [DataMemberAttribute] public int type { get; set; }
        [DataMemberAttribute] public string instruction { get; set; }
        [DataMemberAttribute] public string name { get; set; }
        [DataMemberAttribute] public int[] way_points { get; set; }
    }

    public class Geometry
    {
        public float[][] coordinates { get; set; }
        public string type { get; set; }
    }

}

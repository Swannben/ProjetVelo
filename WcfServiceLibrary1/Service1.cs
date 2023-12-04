using Microsoft.SqlServer.Server;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ProjetVelo
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {


        public async Task<string> GetData(string depart, string arrivee)
        {
            // instantiate the scrapers for the different apis

            JCDCScraper JCDC = new JCDCScraper();
            OpenStreetMapScraper openStreetMap = new OpenStreetMapScraper();
            NominatimScraper nominatim = new NominatimScraper();

            // get the geocoordinates from the adress 
            GeoCoordinate start = await nominatim.getPositionFromAdressAsync(depart);
            GeoCoordinate end = await nominatim.getPositionFromAdressAsync(arrivee);

            //get the city from the geoCoordinates
            String CityStart = await nominatim.getCityFromPosition(start);
            String CityEnd = await nominatim.getCityFromPosition(end);


            // get the list of stations in the given city from the JCDecaux API
            List<Station> stationsStart = await JCDC.getStationsAsync(CityStart);
            List<Station> stationsEnd = stationsStart;
            if (CityStart != CityEnd)
            {
                stationsEnd = await  JCDC.getStationsAsync(CityEnd);
            }

            // find the closest station to your starting and endind position
            Station firstStation = JCDCScraper.findClosestStation(start, stationsStart);
            Station secondStation = JCDCScraper.findClosestStation(end, stationsEnd);

            // find the best way to go get a bike and then drive to the station closest to destination and then go to your destination 
            Feature feature1 = await openStreetMap.GetFeatureWalk(start, firstStation.position.GetGeoCoordinate());
            Feature feature2 = await openStreetMap.GetFeatureCycle(firstStation.position.GetGeoCoordinate(), secondStation.position.GetGeoCoordinate());
            Feature feature3 = await openStreetMap.GetFeatureWalk(secondStation.position.GetGeoCoordinate(), end);

            returnClass returnObject = new returnClass(feature1.properties.segments.FirstOrDefault().steps, feature1.properties.segments.FirstOrDefault().duration, feature1.properties.segments.FirstOrDefault().distance, feature2.geometry.coordinates);

            returnObject.duration += feature2.properties.segments.FirstOrDefault().duration;
            returnObject.duration += feature3.properties.segments.FirstOrDefault().duration;
            returnObject.distance += feature3.properties.segments.FirstOrDefault().distance;
            returnObject.distance += feature2.properties.segments.FirstOrDefault().distance;
            returnObject.steps.Last().instruction ="take a bike here";
            returnObject.steps.Last().name = "take-bike";
            returnObject.steps.AddRange(feature2.properties.segments.FirstOrDefault().steps);
            returnObject.steps.Last().instruction = "leave your bike here";
            returnObject.steps.Last().name = "leave-bike";
            returnObject.steps.AddRange(feature3.properties.segments.FirstOrDefault().steps);
            returnObject.coordinates.Concat(feature2.geometry.coordinates);
            returnObject.coordinates.Concat(feature3.geometry.coordinates);

            return JsonConvert.SerializeObject(returnObject);

        }
    }


    public class returnClass
    {
        public returnClass(Step[] steps, float duration, float distance, float[][] coordinates)
        {
            this.steps = new List<Step>(steps);
            this.duration = duration;
            this.distance = distance;
            this.coordinates = new List<float[]>(coordinates);
        }

        public List<Step> steps { get; set; }
        public float duration { get; set; }
        public float distance { get; set; }
        public List<float[]> coordinates { get; set; }
    }
}

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


        public async Task<Feature> GetData(string depart, string arrivee)
        {
            Console.WriteLine("Before nominatim.getPositionFromAdressAsync(depart)");
            JCDCScraper JCDC = new JCDCScraper();

            OpenStreetMapScraper openStreetMap = new OpenStreetMapScraper();
            NominatimScraper nominatim = new NominatimScraper();
            GeoCoordinate start = await nominatim.getPositionFromAdressAsync(depart);
            Console.WriteLine("After nominatim.getPositionFromAdressAsync(depart)");
            GeoCoordinate end = await nominatim.getPositionFromAdressAsync(arrivee);
            String CityStart = nominatim.getCityFromPosition(start);
            String CityEnd = nominatim.getCityFromPosition(end);
            List<Station> stationsStart = JCDC.getStations(CityStart);
            List<Station> stationsEnd = stationsStart;
            if (CityStart != CityEnd)
            {
                stationsEnd = JCDC.getStations(CityEnd);
            }
            Station firstStation = JCDCScraper.findClosestStation(start, stationsStart);
            Station secondStation = JCDCScraper.findClosestStation(end, stationsEnd);
            Feature feature1 = openStreetMap.GetFeatureWalk(start, firstStation.position.GetGeoCoordinate());
            Feature feature2 = openStreetMap.GetFeatureCycle(firstStation.position.GetGeoCoordinate(), secondStation.position.GetGeoCoordinate());
            Feature feature3 = openStreetMap.GetFeatureWalk(secondStation.position.GetGeoCoordinate(), end);
            Console.WriteLine("openstreetMaped");
            Feature finalFeature = feature1;
            finalFeature.properties.segments.FirstOrDefault().duration += feature2.properties.segments.FirstOrDefault().duration;
            finalFeature.properties.segments.FirstOrDefault().duration += feature3.properties.segments.FirstOrDefault().duration;
            finalFeature.properties.segments.FirstOrDefault().distance += feature3.properties.segments.FirstOrDefault().distance;
            finalFeature.properties.segments.FirstOrDefault().distance += feature2.properties.segments.FirstOrDefault().distance;
            finalFeature.properties.segments.FirstOrDefault().steps.Append(new Step("take a bike here", "take-bike"));
            finalFeature.properties.segments.FirstOrDefault().steps.Concat(feature2.properties.segments.FirstOrDefault().steps);
            finalFeature.properties.segments.FirstOrDefault().steps.Append(new Step("leave your bike here", "leave-bike"));
            finalFeature.properties.segments.FirstOrDefault().steps.Concat(feature3.properties.segments.FirstOrDefault().steps);
            finalFeature.geometry.coordinates.Append(finalFeature.geometry.coordinates.Last());
            finalFeature.geometry.coordinates.Concat(feature2.geometry.coordinates);
            finalFeature.geometry.coordinates.Append(finalFeature.geometry.coordinates.Last());
            finalFeature.geometry.coordinates.Concat(feature3.geometry.coordinates);

            return finalFeature;



            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}

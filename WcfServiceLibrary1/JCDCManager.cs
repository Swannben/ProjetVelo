using ProjetVelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ProjetVelo

{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class JCDCManager
    {
        private readonly GenericProxyCache<List<Station>> _stationCache;

        public JCDCManager()
        {
            _stationCache = new GenericProxyCache<List<Station>>();
        }

        public async Task<List<Station>> getStationsAsync(string city)
        {
            string cacheKey = $"Stations_{city}";

            // Essayez de récupérer les stations depuis le cache
            List<Station> cachedStations = _stationCache.Get(cacheKey);

            if (cachedStations != null && cachedStations.Any())
            {
                // Si les stations sont présentes dans le cache, retournez-les
                Console.WriteLine("Stations récupérées depuis le cache.");
                return cachedStations;
            }
            Console.WriteLine("le cache est vide!");
            // Si les stations ne sont pas présentes dans le cache, récupérez-les depuis JCDecaux
            JCDCScraper scraper = new JCDCScraper();
            List<Station> stations = await scraper.getStationsAsync(city);

            // Stockez les stations dans le cache pour une heure
            _stationCache.Set(cacheKey, stations ,DateTimeOffset.Now.AddHours(1)) ;

            Console.WriteLine("Stations récupérées depuis JCDecaux.");
            return stations;
        }
    }

}
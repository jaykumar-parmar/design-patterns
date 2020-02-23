using System.Collections.Generic;

namespace singletonpatterndemo
{
    public class SingletonDemo
    {
        public string GetCityPopulation()
        {
            var dbQuerier = new CityDatabaseQuerier();
            var totalPopulation = dbQuerier.GetPopulationByCity("Ahmedabad");
            return $"Ahmedabad has population of {totalPopulation}";
        }
    }

    public interface ICityDatabase
    {
        int GetPopulationByCity(string city);
    }

    public class CityDatabase : ICityDatabase
    {
        private Dictionary<string, int> cities;

        private CityDatabase()
        {
            this.cities = new Dictionary<string, int>();
            this.cities.Add("Bangalore", 50000);
            this.cities.Add("Ahmedabad", 75000);
        }

        public int GetPopulationByCity(string city)
        {
            return this.cities[city];
        }

        private static CityDatabase instance = new CityDatabase();

        public static CityDatabase Instance => instance;
    }

    public class CityDatabaseQuerier
    {
        public int GetPopulationByCity(string city)
        {
            return CityDatabase.Instance.GetPopulationByCity(city);
        }
    }

}

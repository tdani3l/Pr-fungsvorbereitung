using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    public interface IAdministrativeUnit
    {
        string GetName();
        int GetPopulation();
    }

    public class City : IAdministrativeUnit
    {
        private string name;
        private int popoulation;

        public City(string _name, int _population)
        {
            name = _name;
            popoulation = _population;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPopulation()
        {
            return popoulation;
        }
    }

    public class Region : IAdministrativeUnit
    {
        private string name;
        List<City> cities = new List<City>();

        public Region(string _name)
        {
            name = _name;
        }

        public void AddCity(City city)
        {
            cities.Add(city);
        }

        public string GetName()
        {
            return name;
        }

        public int GetPopulation()
        {
            int count = 0;
            foreach (var item in cities)
            {
                count = count + item.GetPopulation();
            }

            return count;
        }
    }

    public class Country : IAdministrativeUnit
    {
        private string name;
        List<Region> regions = new List<Region>();

        public Country(string _name)
        {
            name = _name;
        }

        public void AddRegion(Region region)
        {
            regions.Add(region);
        }

        public Region GetRegion(string RegionName)
        {
            foreach (var item in regions)
            {
                if(item.GetName() == RegionName)
                {
                    return item;
                }
            }
            return null;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPopulation()
        {
            int count = 0;
            foreach (var item in regions)
            {
                count = count + item.GetPopulation();
            }

            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

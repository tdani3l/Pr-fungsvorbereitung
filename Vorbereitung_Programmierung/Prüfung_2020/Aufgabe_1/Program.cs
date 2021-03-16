using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    public class City
    {
        public string name;
        public int population;
        public bool capital;

        public City(string _name, int _population, bool _capital)
        {
            name = _name;
            population = _population;
            capital = _capital;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var cities = readCities(@"H:\school\programmierung\pruefung_19_20\aufgabe1_liste_staedte.txt");

            foreach (var item in cities)
            {
                Console.WriteLine(item.name+" "+item.population+" "+item.capital);
            }

            Console.ReadLine();
        }

        static List<City> readCities(string path)
        {
            List<City> cities = new List<City>();

            var list = File.ReadAllLines(path, Encoding.UTF8);
            foreach (var line in list)
            {                
                var parts = line.Split(';');
                bool cap = true;
                if(parts[2] == "nein")
                {
                    cap = false;
                }
                City city = new City(parts[0],Convert.ToInt32(parts[1]),cap);
                cities.Add(city);
            }

            return cities;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nLand: ");
            string land = Console.ReadLine();
            Console.WriteLine("\nProvinz: ");
            string provinz = Console.ReadLine();
            Console.WriteLine("\nEinwohner: ");
            decimal einwohner = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nHöhe: ");
            decimal höhe = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nLat: ");
            decimal lat = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nLon: ");
            decimal lon = Convert.ToDecimal(Console.ReadLine());

            mondialEntities entities = new mondialEntities();
            City city = new City()
            {
                Name = name,
                Population = einwohner,
                Latitude = lat,
                Longitude = lon,
                Elevation = höhe,
                Province = provinz,
                Country = land
            };

            entities.City.Add(city);
            entities.SaveChanges();
        }
    }
}

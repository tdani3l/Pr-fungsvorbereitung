using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parkplatz_nr:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Bahnhofsnummer:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Betreiber:");
            string betr = Console.ReadLine();
            Console.WriteLine("Anzahl_Parkplätze:");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ladestation:");
            string lade = Console.ReadLine();

            bahnEntities bahnEntities = new bahnEntities();
            Parkplaetze parkplaetze = new Parkplaetze();
            parkplaetze.Parkplatz_Nr = num;
            parkplaetze.Name = name;
            parkplaetze.Bahnhofsnummer = num2;
            parkplaetze.Betreiber = betr;
            parkplaetze.Anzahl_Parkplaetze = num3;
            parkplaetze.Ladestation = lade;

            bahnEntities.Parkplaetze.Add(parkplaetze);
            bahnEntities.SaveChanges();

            Console.ReadLine();
        }
    }
}

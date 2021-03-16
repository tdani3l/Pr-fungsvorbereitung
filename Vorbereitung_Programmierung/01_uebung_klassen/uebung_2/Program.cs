using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_2
{
    public class Pizza
    {
        private string name;
        private int dio;
        private decimal price;

        public Pizza(string _name, int _dio, decimal _price)
        {
            name = _name;
            dio = _dio;
            price = _price;
        }

        public string getName()
        {
            return name;
        }

        public int getSize()
        {
            return dio;
        }

        public decimal getPrice()
        {
            return price;
        }

        public double getArea()
        {
            return Math.Round(Math.PI * (dio / 2) * (dio / 2), 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pizza Funghi = new Pizza("Funghi", 27, 13.99m);
            Pizza Klassik = new Pizza("Klassik", 27, 13.99m);

            Console.WriteLine(Funghi.getName()+ " " + Funghi.getSize() + " " + Funghi.getPrice() + " " + Funghi.getArea());

            Console.ReadLine();
        }
    }
}

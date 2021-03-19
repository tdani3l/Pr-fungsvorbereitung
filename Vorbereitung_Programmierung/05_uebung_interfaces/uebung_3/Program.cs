using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_3
{
    public abstract class Pizza
    {
        public List<ITopping> toppings = new List<ITopping>();

        public decimal Preis { get; }

        protected Pizza(decimal _Preis)
        {
            Preis = _Preis;
        }

        public abstract void Prepare();

        public abstract void AddTopping(ITopping topping);

        public abstract decimal getPrice();
    }

    public class Napoletana : Pizza
    {
        public Napoletana() : base(7m) { }

        public override void AddTopping(ITopping topping)
        {
            toppings.Add(topping);
        }

        public override decimal getPrice()
        {
            decimal total = Preis;
            foreach (var item in toppings)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public override void Prepare()
        {
            Console.WriteLine("Napoletana: Napoletana-Teig ausrollen, Pizza belegen, 60-90 Sekunden im Holzofen backen");
        }
    }

    public class Romana : Pizza
    {
        public Romana(decimal _Preis) : base(_Preis) { }

        public override void AddTopping(ITopping topping)
        {
            toppings.Add(topping);
        }

        public override decimal getPrice()
        {
            decimal total = Preis;
            foreach (var item in toppings)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public override void Prepare()
        {
            Console.WriteLine("Romana: Romana-Teig auf Blech ausrollen, Pizza belegen, 10-20 Minuten im Ofen backen");
        }
    }

    public class Chicago : Pizza
    {
        public Chicago(decimal _Preis) : base(_Preis) { }

        public override void AddTopping(ITopping topping)
        {
            toppings.Add(topping);
        }

        public override decimal getPrice()
        {
            decimal total = Preis;
            foreach (var item in toppings)
            {
                total += item.GetPrice();
            }
            return total;
        }

        public override void Prepare()
        {
            Console.WriteLine("Chicago: Chicago-Teig auf Blech ausrollen, Pizza belegen, 30-40 Minuten im Ofen backen");
        }
    }

    public interface ITopping
    {
        string GetDescription();
        decimal GetPrice();
    }

    public class Käse : ITopping
    {
        decimal Preis = 1.20m;

        public string GetDescription()
        {
            return "Käse";
        }

        public decimal GetPrice()
        {
            return Preis;
        }
    }

    public class Ananas : ITopping
    {
        decimal Preis = 0.50m;

        public string GetDescription()
        {
            return "Ananas";
        }

        public decimal GetPrice()
        {
            return Preis;
        }
    }

    public class Spinat : ITopping
    {
        decimal Preis = 1.40m;

        public string GetDescription()
        {
            return "Spinat";
        }

        public decimal GetPrice()
        {
            return Preis;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

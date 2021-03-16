using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_1
{
    public class Person
    {
        private string Vorname;
        private string Nachname;

        private int GroesseInCm;

        private DateTime Geburtsdatum;

        public Person(string Vorname, string Nachname, int GroesseInCm, DateTime Geburtsdatum)
        {
            this.Vorname = Vorname;
            this.Nachname= Nachname;
            this.GroesseInCm = GroesseInCm;
            this.Geburtsdatum = Geburtsdatum;
        }

        public string getName()
        {
            return Vorname+" "+Nachname;
        }

        public void setName(string Vorname, string Nachname)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
        }

        public string getVorname()
        {
            return Vorname;
        }

        public string getNachname()
        {
            return Vorname;
        }

        //Uebung_4:

        public Person Copy()
        {
            return new Person(Vorname, Nachname, GroesseInCm, Geburtsdatum);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person erika = new Person("Erika", "Mustermann", 170, new DateTime(1989, 1, 20));
        }
    }
}

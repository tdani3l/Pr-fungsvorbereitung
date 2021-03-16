using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_2
{
    public class Konto
    {
        private string _vorname;
        public string vorname
        {
            get { return _vorname; }
        }

        private string _nachname;
        public string nachname
        {
            get { return _nachname; }
        }

        private string _kontonummer;
        public string kontonummer
        {
            get { return _kontonummer; }
        }

        private decimal _kontostand;
        public decimal kontostand
        {
            get { return _kontostand; }
            set
            {
                if (-value < _kreditrahmen)
                {
                    _kontostand = value;
                }
            }
        }

        private decimal _kreditrahmen;
        public decimal kreditrahmen
        {
            get { return _kreditrahmen; }
            set { _kreditrahmen = value;}
        }

        private decimal _disposatz;
        public decimal disposatz
        {
            get { return _disposatz; }
            set
            {
                if(value >= 0 && value <= 18)
                {
                    _disposatz = value;
                }
            }
        }

        const decimal CR = 500;
        const decimal DISPO = 6;

        public Konto(string vorname, string nachname, string kontonummer, decimal kontostand, decimal kreditrahmen, decimal disposatz)
        {
            _vorname = vorname;
            _nachname = nachname;
            _kontonummer = kontonummer;
            _kontostand = kontostand;
            _kreditrahmen = kreditrahmen;
            _disposatz = disposatz;
        }

        public Konto(string vorname, string nachname, string kontonummer)
        {
            _vorname = vorname;
            _nachname = nachname;
            _kontonummer = kontonummer;
            _kontostand = 0;
            _kreditrahmen = CR;
            _disposatz = DISPO;
        }

        public decimal berechneDispoZinsen()
        {
            if(_kontostand >= 0)
            {
                return 0;
            }
            else
            {
                return -_kontostand * _disposatz / 1200;
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

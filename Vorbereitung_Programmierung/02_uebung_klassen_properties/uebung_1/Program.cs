using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uebung_1
{
    public class Radio
    {
        private bool _isTurnedOn = false;
        public bool isTurnedOn
        {
            get { return _isTurnedOn; }
            set
            {
                isTurnedOn = value;
            }
        }

        private int _volume = 10;
        public int volume
        {
            get { return _volume; }
            set 
            { 
                if(value>=0 && value <= 40)
                {
                    volume = value;
                } 
            }
        }

        private float _frequency = 88.0f;
        public float frequency
        {
            get { return _frequency; }
            set
            {
                if (value >= 87.5f && value <= 108f)
                {
                    frequency = value;
                }
            }
        }

        public Radio()
        {

        }

        public Radio(bool status, int volume, float frequency)
        {
            isTurnedOn = status;
            _volume = volume;
            _frequency = frequency;
        }

        public void Louder()
        {
            if(isTurnedOn)
            volume++;
        }

        public void Quieter()
        {
            if(isTurnedOn)
            volume--;
        }

        public void On()
        {
            isTurnedOn = true;
        }

        public void Off()
        {
            isTurnedOn = false;
        }

        public void ChangeFrequency(float freq)
        {
            frequency = freq;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Radio R1 = new Radio();

            Radio R2 = new Radio(true, 15, 107.5f);

            Radio R3 = new Radio
            {
                isTurnedOn = true,
                volume = 17,
                frequency = 104f
            };
        }
    }
}

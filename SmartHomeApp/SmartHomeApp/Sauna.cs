using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeApp
{
    public class Sauna
    {
        private double aste;

        public double Aste 
        {
            get
            {
                return aste;
            }

            set
            {
                if ((value > 0) && (value <= 100))
                {
                    aste = value;
                }
                else
                {
                    aste = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public bool running { get; set; }



        public void Start()
        {
            running = true;
            Aste = 24.50;
        }


        public void Stop()
        {
            running = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeApp
{
    class Thermostat
    {
        public bool setting { get; set; }

        public void Start()
        {
            setting = true;
        }

        public void Stop()
        {
            setting  = false;
        }
    }
}

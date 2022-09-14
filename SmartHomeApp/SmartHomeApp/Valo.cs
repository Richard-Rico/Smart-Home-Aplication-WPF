using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeApp
{
    class Valo
    {
        public bool kytkin { get; set; }

        public void Start() 
        {
            kytkin = true;
        }

        public void Stop() 
        {
            kytkin = false;
        }
    }
}

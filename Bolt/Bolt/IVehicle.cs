using System;
using System.Collections.Generic;
using System.Text;

namespace Bolt
{
    interface IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public string ShowInfo();
    }
}

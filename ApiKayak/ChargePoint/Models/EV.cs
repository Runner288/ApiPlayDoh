using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargePoint.Models
{

    public class EV
    {
        public int Id { get; set; }
        public Maker Maker { get; set; }
        public string Model { get; set; }
        public double BatterySize { get; set; }
    }
}

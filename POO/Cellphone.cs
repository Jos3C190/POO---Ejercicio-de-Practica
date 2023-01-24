using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cellphone
    {
        public string Model { get; set; } = "";
        public int BatteryCharging { get; set; }
        public int ModelYear { get; set; }

        public void NoBatteryCharge()
        {
            BatteryCharging = 0;
        }
        public void FullCharge()
        {
            BatteryCharging = 100;
        }
        public string ModelYearCellphone()
        {
            if (ModelYear <= 2022)
            {
                return "tiene poco tiempo en el mercado";
            }
            else
            {
                return "ya tiene tiempo en el mercado";
            }
        }
    }
}

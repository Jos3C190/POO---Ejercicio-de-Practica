using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }

        public void IncreaseDailyMileage()
        {
            Mileage += 10;
        }

        public string NumberYears()
        {
            if (Year >= 2018)
            {
                return "El vehiculo tiene menos de 5 años";
            }
            else
            {
                return "El vehiculo tiene mas de 5 años";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Animal
    {
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public int Weight { get; set; }

        public void EatLittle()
        {
            Weight -= 1;
        }

        public string AgeCondition()
        {
            if (Age <= 4)
            {
                return "esta joven";
            }
            else
            {
                return "esta viejo";
            }
        }
    }
}

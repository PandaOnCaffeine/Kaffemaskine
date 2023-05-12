using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class BrewingMachine : Machine
    {
        public int water { get; set; }
        public int cup { get; set; } = 4;
        public bool filter { get; set; } = false;
        public int coffee { get; set; } = 0;
        public string brew { get; set; }
        public void Brew()
        {
            if (water >= 50 && filter == true)
            {
                water += -50;
                if (coffee >= 10)
                {
                    BrewCoffee();
                }
            }
            else
            {
                Console.WriteLine("Check Water and Filter");
            }
        }
        public void BrewCoffee()
        {
            coffee += -10;
            Console.WriteLine("");
        }
    }
}

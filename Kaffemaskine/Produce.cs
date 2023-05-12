using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class Produce
    {
        public void AddWater(BrewingMachine b)
        {
            b.water = 500;
        }
        public void AddFilter(BrewingMachine b)
        {
            b.filter = true;
        }
        public void AddCoffee(BrewingMachine b)
        {
            b.coffee = 200;
        }
    }
}

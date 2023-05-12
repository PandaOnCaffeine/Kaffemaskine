using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class BrewingMachine : Machine
    {
        private bool filter = false;
        public void EquipFilter()
        {
            filter = true;
        }
        public void Brew(int cups, CoffeePowder c)
        {
            if (on == false)
            {
                Console.WriteLine($"{GetType()} Not Turned On!");
                return;
            }
            else if (filter == false)
            {
                Console.WriteLine($"{GetType()} Filter Not Found!");
                return;
            }
            int count = 0;
            for (int i = 0; i < cups; i++)
            {
                count++;
                Console.WriteLine($"Cup number {count} of Coffee is done!");
            }
            filter = false;
        }
    }
}

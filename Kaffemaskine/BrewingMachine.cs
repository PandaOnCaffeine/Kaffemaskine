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
        public void Brew(int cups, BrewingPowder b)
        {
            int count = 0;
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
            for (int i = 0; i < cups; i++)
            {
                count++;
                Done(b, count);
            }
        }
        public void Done(BrewingPowder b, int count)
        {
            if (b is CoffeePowder)
            {
                Console.WriteLine($"Cup number {count} of Coffee is done!");
            }
            else if (b is Tea)
            {
                Console.WriteLine($"Cup number {count} of Tea is done!");
            }
        }
    }
}

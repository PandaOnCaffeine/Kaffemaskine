using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrewingMachine cm1 = new BrewingMachine();
            CoffeePowder c = new CoffeePowder();
            Tea t = new Tea();
            cm1.TurnOn();

            cm1.EquipFilter();
            cm1.Brew(5, t);

            Console.WriteLine();

            cm1.Brew(10,c);


            Console.ReadLine();
        }
    }
}

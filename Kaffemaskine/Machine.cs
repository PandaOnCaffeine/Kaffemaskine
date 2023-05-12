using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    abstract internal class Machine
    {
        protected bool on = false;
        public virtual void TurnOn()
        {
            on = true;
        }
        public virtual void TurnOff()
        {
            on = false;
        }
    }
}

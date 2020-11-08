using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Iface : IIface
    {
        public int Doppio(int i)
        {
            return i * 2;
        }
    }
}

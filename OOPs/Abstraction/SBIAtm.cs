using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Abstraction
{
    internal class SBIAtm:ATM
    {
        public override void ConnectingToBackend()
        {
            Console.WriteLine("Connecting to backend");
        }
    }
}

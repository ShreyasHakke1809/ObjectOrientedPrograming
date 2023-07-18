using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Abstraction
{
    abstract internal class ATM
    {
        public void WithdrawMoney()
        {
            Console.WriteLine("Wecan withdraw money from ATM");
        }
        public abstract void ConnectingToBackend()
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Encapsulation
{
    internal class Account
    {
        int accountbalance = 1000;

        public int Balance
        {
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("You can not pass negative values");
                }
                else
                {
                    accountbalance = value;
                }
            }
            get
            {
                return accountbalance;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism
{
    internal class MethodOverloading
    {
        public static void Add(int x ,int y)
        {
            int z = x + y;
            Console.WriteLine("Sum is: "+ z);
        }
          //changing no of parameters from 1st to 2nd method
        public static void Add(int x, int y, int z)
        {
            int res = x + y;
            Console.WriteLine("Sum is: " + z);
        }
          //changing one parameter datatype from 2nd to 3rd method
        public static void Add(int x, int y, long z)
        {
            long res = x + y + z;
            Console.WriteLine("Sum is: " + res);
        }
           //changing order of datatype
        public static void Add(int x, long z, int y)
        {
            long res = x + y + z;
            Console.WriteLine("Sum is: " +res);
        }
    }
}

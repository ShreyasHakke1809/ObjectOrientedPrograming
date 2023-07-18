using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.Polymorphism
{
    internal class MethodOverriding
    {
        public string name;
        public double salary;
        public virtual void GetSalary()
        {
            Console.WriteLine("50000");
        }
        public void EmpDetails()
        {
            Console.WriteLine("Name:{0} Salary:{1} ",name ,salary);
        }
    }
    class PartTime:MethodOverriding
    {
        public override void GetSalary()
        {
            Console.WriteLine("500");
        }
    }
}

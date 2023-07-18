using OOPs.Abstraction;
using OOPs.ClassAndObject;
using OOPs.Encapsulation;
using OOPs.Inheritence;
using OOPs.Polymorphism;

namespace OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.CLassAndObject\n2.Inheritance\n3.MethodOverloading\n4.MethodOverriding\n5.Abstraction\n6.Encapsulation");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                 Car car1 = new Car();
                 car1.model = "BMW";
                 car1.colour = "White";
                 car1.price = 9000000;
                 car1.CarDetails();
                 Car car2 = new Car();
                 car2.model = "Toyota";
                 car2.colour = "Red";
                 car2.price = 4500000;
                 car2.CarDetails();
                 break;
                case 2:
                 Lion lion = new Lion();
                 lion.name = "Lion";
                 lion.colour = "Reddish-Brown";
                 lion.Run();
                 lion.Coats();
                 break;
                case 3:
                 MethodOverloading.Add(9, 18);
                 MethodOverloading.Add(9, 18, 27);
                 break;
                case 4:
                 PartTime partTime = new PartTime();
                 partTime.GetSalary();
                 break;
                case 5:
                 SBIAtm sbiAtm = new SBIAtm();
                 sbiAtm.WithdrawMoney();
                 sbiAtm.ConnectingToBackend();
                 break;
                case 6:
                 Account account = new Account();
                 account.Balance = 5000;
                 break;
                default:
                 Console.WriteLine("Please enter valid number");
                 break;
            }
        }
    }
}
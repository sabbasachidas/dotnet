using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string age = "";
            string address = "";
            string contact = "";
            Console.WriteLine ("Enter ur name:");
            name = Console.ReadLine();
            Console.WriteLine ("Ur age:");
            age = Console.ReadLine();
            Console.WriteLine ("Ur address:");
            address= Console.ReadLine();
            Console.WriteLine ("Ur contact");
            contact = Console.ReadLine();


            Console.WriteLine("Hello " + name);
            Console.WriteLine("Ur age is " + age);
            Console.WriteLine("U Lives at " + address);
            Console.WriteLine("Ur contact no is  " + contact);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer(1, "Samed", "Musabaşoğlu", "Ordu");

            Customer customer1 = new Customer { City = "Kocaeli" };

            Console.WriteLine("{0}", customer.City);

            Console.WriteLine(customer1.City);


            Console.ReadLine();

        }
    }
}

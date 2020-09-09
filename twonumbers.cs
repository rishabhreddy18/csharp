using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int product;
            if (a == 0)
            {
                Console.WriteLine("Enter positive number");
                a = Convert.ToInt32(Console.ReadLine());
            }
            sum = a + b;
            product = a * b;
            Console.WriteLine(sum);
            Console.WriteLine(product);
            Console.ReadKey();
        }
    }
}

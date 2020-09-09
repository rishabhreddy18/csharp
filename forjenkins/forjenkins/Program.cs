using System;

namespace forjenkins
{
    class Program
    {
        static void Main(string[] args)
        {
			int a, b;
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			while (a == 0 && b == 0)
			{
				if (a == 0)
				{ a = Convert.ToInt32(Console.ReadLine()); }
				if (b == 0)
				{ b = Convert.ToInt32(Console.ReadLine()); }
			}

			int res1 = 0;
			int res2 = 0;
			res1 = a + b;
			res2 = a * b;
			Console.WriteLine("addition is {0} and multiplication is {1}", res1, res2);
			Console.ReadKey();
		}
    }
}

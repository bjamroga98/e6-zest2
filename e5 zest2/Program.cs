using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter n: ");
            string text = Console.ReadLine();
            if (!Int32.TryParse(text, out n))
                throw new ArgumentException("n is not an integer!\n");
            int fctrl = Factorial(n);
            Console.WriteLine("Factorial of {0} equals: {1}", n, fctrl);

            Console.ReadKey();
        }

            static int Factorial(int mm)
        {
            int i = 1;
            int result = 1;
            while (i <= mm)
                result *= i++;

            return result;
        }
    }
}

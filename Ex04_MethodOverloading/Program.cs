using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_MethodOverloading
{
    class Program
    {
        private static int Plus(int a, int b)
        {
            return a + b;
        }

        private static double Plus(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Plus(1, 2)");
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine("Plus(1.2, 3.4)");
            Console.WriteLine(Plus(1.2, 3.4));
        }

        
    }
}

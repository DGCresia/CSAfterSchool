using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Sum 실행 결과 : {Sum(1, 2, 3, 4, 5)}");

            PrintProfile(name: "류가미", phone: "010-1234-5678");
            PrintProfile(phone: "010-1234-5678", name: "류가미");
        }

        private static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name : {name}, Phone : {phone}");
        }

        private static int Sum(params int[] args)
        {
            int sum = 0;
            Console.WriteLine("매개 변수 : ");
            foreach (var item in args)
            {
                sum += item;
                Console.Write(item+" ");
            }
            Console.WriteLine();
            return sum;
        }
    }
}

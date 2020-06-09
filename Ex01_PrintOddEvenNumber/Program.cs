using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_PrintOddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력하세요 : ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine("홀수");
            }
            else
            {
                Console.WriteLine("정수가 아닙니다");
            }
        }
    }
}

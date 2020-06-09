using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2020, 6, 9, 17, 18, 00);
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Hour);

            dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(dateTime.Hour);

            Console.WriteLine("현재 "+dateTime.Hour+"시 입니다.");
        }
    }
}

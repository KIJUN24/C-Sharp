using System;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;

namespace _012_WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            float fNum = 0.014451f;
            double dNum = 123456789.1239142d;

            Console.WriteLine("{0} {1} {2} {0} {2} {2}", num, fNum, dNum);
            Console.WriteLine("{0:D} {0:D8}", num);
            Console.WriteLine("{0} {0:F} {0:F3}", fNum);
            Console.WriteLine("{0} {0:E} {0:E2} {0:E5}", dNum);

            Console.WriteLine("0x{0:X}", num);

            Console.WriteLine("{0:C3} {1}", num, num.ToString("C"));
            Console.WriteLine("{0:N} {0:N1} {0:N3}", num);
            Console.WriteLine("{0:P} {0:P1} {0:P3}", num);

            double d1 = 12345.445566;
            Console.WriteLine($"{d1:##.##}");
            Console.WriteLine($"{d1:#.####}");
            Console.WriteLine($"{d1:00.00}");
            Console.WriteLine($"{d1:0.0000}");

            double d2 = 987654.2;
            Console.WriteLine($"{d2:#,##0.0}  {d2:#,#}");

            double d3 = 01066665588;
            Console.WriteLine($"{d3:(###) ####-####}");
            // 제일 앞이 0이면 안 나옴
            // 전화번호를 출력하고 싶을 때는 밑에 있는 코드처럼 짜야함.
            Console.WriteLine($"{d3:(0##) ####-####}");

        }
    }
}

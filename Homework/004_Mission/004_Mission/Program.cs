using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // char데이터형 이용해서 Hello World출력

            char h = 'H';
            char e = 'E';
            char l1 = 'L';
            char l2 = 'L';
            char o1 = 'O';

            char w = 'W';
            char o2 = 'O';
            char r = 'R';
            char l3 = 'L';
            char d = 'D';


            char l = 'L';
            char o = 'O';

            Console.Write(h);
            Console.Write(e);
            Console.Write(l1);
            Console.Write(l2);
            Console.Write(o1);
            Console.Write(' ');
            Console.Write(w);
            Console.Write(o2);
            Console.Write(r);
            Console.Write(l3);
            Console.WriteLine(d);

            Console.WriteLine($"{h}{e}{l}{l}{o} {w}{o}{r}{l}{d}");
        }
    }
}

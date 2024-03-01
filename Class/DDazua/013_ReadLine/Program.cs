using System;
using System.Diagnostics;

namespace _013_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기초
            { 
                Console.Write("문장을 입력하세요 : ");
                var inputData = Console.ReadLine();
                Console.WriteLine($"입력한 값은 : {inputData}");
                Console.WriteLine($"type : {inputData.GetType()}");
            }
            Console.WriteLine();
            {
                Console.Write("정수를 입력하세요 : ");
                var strNum1 = Console.ReadLine();
                Console.Write("정수를 입력하세요 : ");
                var strNum2 = Console.ReadLine();
                Console.WriteLine($"입력문자 : {strNum1} {strNum2}");

                var num1 = int.Parse(strNum1);
                var num2 = Convert.ToInt32(strNum2);
                Console.WriteLine($"num1 : {num1}, type : {num1.GetType()}");
                Console.WriteLine($"num2 : {num2}, type : {num2.GetType()}");
            }
            Console.WriteLine();
            // Read : 문자 하나만 아스키 코드값을 가져온다. 문자를 출력하려면 형변환을 해줘야 한다.
            {
                Console.Write("문자를 입력하세요 : ");
                var readVar = Console.Read();
                Console.WriteLine($"입력문자 : {readVar}, type : {readVar.GetType()}");
                Console.WriteLine($"입력문자 : {(char)readVar}, type : {readVar.GetType()}");

            }
            Console.WriteLine();
            // ReadKey
            {
                ConsoleKeyInfo info;

                Console.Write("키를 누르세요 : ");
                info = Console.ReadKey();
                Console.WriteLine($"\n입력한 키는 : {info.Key}");

                Console.Write("키를 누르세요 : ");
                info = Console.ReadKey(false);
                Console.WriteLine($"\n입력한 키는 : {info.Key}");

                Console.Write("키를 누르세요 : ");
                info = Console.ReadKey(true);   // 누른 키를 안 보이게 할 수 있음
                Console.WriteLine($"\n입력한 키는 : {info.Key}");

                Console.WriteLine($"\n입력한 키는 : {info.KeyChar}");
                Console.WriteLine($"\n입력한 키는 : {info.Modifiers}");

            }
        }
    }
}

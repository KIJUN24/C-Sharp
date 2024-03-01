﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _032_Struct.Program;

namespace _032_Struct
{
    internal class Program
    {
        public struct sData
        {
            public int _num1;
            public int _num2;

            public sData(int num1, int num2)
            {
                _num1 = num1;
                _num2 = num2;
            }
        }

        struct MyPoint
        {
            public int x;
            public int y;

            public MyPoint(int xData, int yData)
            {
                x = xData;
                y = yData;
            }


        }


        struct sBook
        {
            public int id;
            public string title;
            public string author;

            public sBook(int _id, string _title, string _author)
            {
                id = _id;
                title = _title;
                author = _author;
            }
        }


        static void Main(string[] args)
        {
            {
                sData data = new sData(0, 10);
                Console.WriteLine($"_num1 : {data._num1}");
                Console.WriteLine($"_num2 : {data._num2}");
            }

            {
                MyPoint point1 = new MyPoint(10, 10);
                Console.WriteLine($"point1 : {point1.x}");
                Console.WriteLine($"point1 : {point1.y}");

                MyPoint point2;
                point2.x = 100;
                point2.y = 200;
                Console.WriteLine($"point2 : {point2.x}");
                Console.WriteLine($"point2 : {point2.y}");
            }
            Console.WriteLine();
            {
                sBook[] arrayBook = new sBook[3];

                arrayBook[0].id = 0;
                arrayBook[0].title = "aa";
                arrayBook[0].author = "aaa";

                arrayBook[1].id = 1;
                arrayBook[1].title = "bb";
                arrayBook[1].author = "bbb";

                arrayBook[2].id = 2;
                arrayBook[2].title = "cc";
                arrayBook[2].author = "ccc";

                foreach (var item in arrayBook)
                {
                    Console.WriteLine($"id : {item.id}");
                    Console.WriteLine($"title : {item.title}");
                    Console.WriteLine($"author : {item.author}");
                }


                Console.Write("찾으려는 책의 이름이 무엇입니까?");
                string name = Console.ReadLine();
                sBook findBook = new sBook();

                foreach (var item in arrayBook)
                {
                    if(item.title.Equals(name))
                    {
                        findBook = item;
                        break;
                    }
                }

                if(string.IsNullOrEmpty(findBook.title))
                {
                    Console.WriteLine("없습니다.");

                }
                else
                {
                    Console.WriteLine($"id : {findBook.id}");
                    Console.WriteLine($"title : {findBook.title}");
                    Console.WriteLine($"author : {findBook.author}");
                }

                sBook[] testBooks = { new sBook(0, "aa", "aaa"), new sBook(1, "bb", "bbb") };
            }
        }
    }
}

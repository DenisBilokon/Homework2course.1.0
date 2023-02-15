using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2c2s.hw1._1
{
    internal class Program
    {
        public delegate int MyDel(int a, int b);
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Введите действие--> +,-,*,/");
                string a = Console.ReadLine();
                Console.WriteLine("Первое число -->");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Второе число -->");
                int y = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case "+":
                        MyDel myDelegat = (c, b) => { return c + b; };
                        int del = myDelegat(x, y);
                        Console.WriteLine("Ответ:{0}", del);
                        break;
                    case "-":
                        MyDel myDelegat1 = (c, b) => { return c - b; };
                        int del1 = myDelegat1(x, y);
                        Console.WriteLine("Ответ:{0}", del1);
                        break;
                    case "*":
                        MyDel myDelegat2 = (c, b) => { return c * b; };
                        int del2 = myDelegat2(x, y);
                        Console.WriteLine("Ответ:{0}", del2);
                        break;
                    case "/":
                        MyDel myDelegat3 = (c, b) => { return c / b; };
                        int del3 = myDelegat3(x, y);
                        Console.WriteLine("Ответ:{0}", del3);
                        break;
                    default:
                        Console.WriteLine("Выберите из предложанного");
                        break;
                }

                Console.ReadKey();

            }
        }
    }
}

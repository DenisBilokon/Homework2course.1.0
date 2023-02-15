

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2c2s.hw._1._3
{
    internal class Program
    {
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("Середнє арифметичне: " + ((a + b + c) / 3).ToString());
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Ввiдiть 1 значення");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввiдiть 2 значення");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ввiдiть 3 значення");
            c = Convert.ToInt32(Console.ReadLine());

            Calculate(a, b, c);

        }
    }
}

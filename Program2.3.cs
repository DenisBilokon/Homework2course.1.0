using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2c2s.hw1._2
{
    internal class Program
    {
        delegate int MyDelegate();
        delegate double MyDel(MyDelegate[] a);


        static int GetRandom()
        {
            Random random = new Random();
            int number = random.Next(1, 100);
            Console.WriteLine(number);
            return number;
        }

        static void Main(string[] args)

        {
            {
               
                Console.WriteLine("Ввiдiте число елементiв массиву: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(new string('-', 50));

                var array = new MyDelegate[n];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = () => new MyDelegate(GetRandom)();
                }

                MyDel d = delegate (MyDelegate[] a)
                {
                    double sr = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        sr += a[i]();
                    }
                    return sr / array.Length;
                };
                Console.WriteLine("Середнє арифметичне = {0}", d(array));
                Console.WriteLine(new string('-', 50));

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]());
                }
            }
            Console.ReadKey();  
        }
    }
}
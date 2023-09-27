using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int value;
            int i = 2;
            bool simple = false;

            while (true)
            {
                Console.WriteLine("проверка числа:");
                value = Convert.ToInt32(Console.ReadLine());

                if ((value % i == 0)(i <= value - 1))
                {
                    i++;
                    Console.WriteLine("число не простое");
                    simple = true;
                    Console.WriteLine(simple);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("число простое");
                    Console.WriteLine(simple);
                    Console.ReadKey();
                }
                    break;
                }
                
            }
        }
    }
}

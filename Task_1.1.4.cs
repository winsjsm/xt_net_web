using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            var isnum = false;
            var n_next = "";
            var n = 0;

            do
            {
                Console.WriteLine("Введите величину N (количество треугольников):");
                n_next = Console.ReadLine();
                isnum = int.TryParse(n_next, out n);
                if (n <= 0)
                {
                    Console.WriteLine("Величина N должна быть неотрицательной и не равной 0!");
                    isnum = false;
                }
            } while (!isnum);


            Console.WriteLine("Изображение:");
            Console.WriteLine("");
            for (int height = 0; height <= n + 1; height++)
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = n; j >= i + 1; j--) { Console.Write(" "); }
                    for (int m = 0; m <= i * 2; m++) { Console.Write("*"); }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}

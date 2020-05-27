using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._1
{
    class Task_1_1_1
    {
        static void Main(string[] args)
        {
            var isnum = false;
            var side_a = "";
            var a = 0;

            var side_b= "";
            var b = 0;

            do {
                Console.WriteLine("Введите величину стороны а:");
                side_a = Console.ReadLine();
                isnum = int.TryParse(side_a, out a);
                if (a <= 0)
                {
                    Console.WriteLine("Величина стороны a должна быть неотрицательной и не равной 0!");
                    isnum = false;
                }
                    
            } while (!isnum);

            do
            {
                Console.WriteLine("Введите величину стороны b:");
                side_b = Console.ReadLine();
                isnum = int.TryParse(side_b, out b);
                if (b <= 0)
                {
                    Console.WriteLine("Величина стороны a должна быть неотрицательной и не равной 0!");
                    isnum = false;
                }
            } while (!isnum);

            Console.WriteLine("Площадь прямоугольника со сторонами a и b равна: " + a * b);
            Console.ReadKey();
        }
    }
}

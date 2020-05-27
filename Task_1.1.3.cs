using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var isnum = false;
            var n_next = "";
            var n = 0;
            var m = 1;

            do
            {
                Console.WriteLine("Введите величину N:");
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
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= m / 2 + 2; j--) { Console.Write(' '); }
                for (int j = 1; j <= m; j++) { Console.Write('*'); }      
                m += 2;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

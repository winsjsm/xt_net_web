using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._5
{
    class Program
    {
         static bool is_multiple_number(int k)
        {
            return (k % 3 == 0 || k % 5 == 0);
        }
        static void Main(string[] args)
        {
            var n = 1000;
            var summa = 0;
            for (int i = 1; i < n; i++)
            {
                if (is_multiple_number(i)) { summa += i; }  
            }
            Console.WriteLine("Сумма чисел кратных 3 или 5 и меньше 1000 равна: "+ summa);
            Console.ReadLine();
        }
    }
}

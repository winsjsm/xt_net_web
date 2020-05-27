using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
  
            var arr = new int[30];
            var rand = new Random();
            var summa = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-200, 200);
            }

            Console.WriteLine("Данный масиив:");
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            foreach (int i in arr)
            {
                summa = i > 0 ? summa + i : summa;
            }
            Console.WriteLine("");
            Console.WriteLine("Сумма неотрицательных значений массива равна: " + summa);
            Console.ReadKey();
        }
    }
}

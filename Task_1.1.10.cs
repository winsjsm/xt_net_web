using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var first_st = 3;
            var sec_st = 3;
            var  arr = new int[first_st, sec_st];
            var rand = new Random();
            var summa = 0;


            for(int i = 0; i < first_st; i++)
            {
                for (int j = 0; j < sec_st; j++) { arr[i, j] = rand.Next(-200, 200); }
            }


            Console.WriteLine("Данный массив: ");
            foreach (int i in arr)
            { 
                Console.Write(i);
                Console.Write(" ");
            }



            for (int i = 0; i < first_st; i++)
            {
                for (int j = 0; j < sec_st; j++)
                {
                    if ((i + j) % 2 == 0)
                        summa += arr[i, j];
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Сумма элементов, стоящих на четных позициях равна: "+ summa);
            Console.ReadKey();
        }
    }
}

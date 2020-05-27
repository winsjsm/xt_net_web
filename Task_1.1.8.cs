using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {

            var first_st = 3;
            var sec_st = 3;
            var third_st = 3;
            var arr = new int[first_st, sec_st, third_st];
            var rand = new Random();

            for (int i = 0; i < first_st; i++)
                for (int j = 0; j < sec_st; j++)
                    for (int m = 0; m < third_st; m++)
                        arr[i, j, m] = rand.Next(-200, 200);
            
            
            Console.WriteLine("Данный масиив");
            foreach (int i in arr)
            { 
                Console.Write(i);
                Console.Write(" ");

            }

            for (int i = 0; i < first_st; i++)
                for (int j = 0; j < sec_st; j++)
                    for (int m = 0; m < third_st; m++)
                        if (arr[i, j, m] > 0)
                            arr[i, j, m] = 0;


            Console.WriteLine("");
            Console.WriteLine("Преобразованный массив:");
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.ReadKey();
        }
    }
}

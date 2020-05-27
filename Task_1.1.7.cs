using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._7
{
    class Program
    {

        static int hight_low_element(int[] arr, bool type)
        {
            var tmp_value = arr[0];
            if (type)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] > tmp_value) { tmp_value = arr[i]; }

            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] < tmp_value) { tmp_value = arr[i]; }
            }
            return tmp_value;
        }

        static void sort_arr(ref int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            var arr = new int[10];
            var rand = new Random();

            Console.WriteLine("Данный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(200);
                Console.Write(arr[i] + " ");
            }
           
            Console.WriteLine("");
            Console.WriteLine("Минимальный элемент массива: " + hight_low_element(arr,false) );
            Console.WriteLine("Максимальный элемент массива: " + hight_low_element(arr,true));
            
            sort_arr(ref arr);
            
            Console.WriteLine("Отсортированный массив: ");
            for (int i = 0; i < arr.Length; i++) { Console.Write(arr[i]); Console.Write(" "); }
            Console.ReadKey();
        }

       

       
    }
}

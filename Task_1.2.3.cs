using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var word_count = 0;
            var punсt_marks_arr = new string[] { ".", "...", ",", ":", ";", "!", "?", "-", "[", "]", "{", "}", "(", ")", "<", ">" };
            
            Console.WriteLine("Вводимая строка:");
            var input_str = Console.ReadLine();
            
           
            for (int i = 0; i < punсt_marks_arr.Length; i++)
                input_str = input_str.Replace(punсt_marks_arr[i], " ");

            var arr = input_str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var el in arr)
                if (el[0] >= 'а' && el[0] <= 'я' || el[0] >= 'a' && el[0] <= 'z') { word_count++; }
                   

            Console.WriteLine("Количество слов начинающихся с маленькой буквы:"+word_count);
            Console.ReadKey();
        }
    }
}

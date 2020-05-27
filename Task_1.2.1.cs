using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var summa = 0;
            Console.WriteLine("Ввод: ");
            var str = Console.ReadLine();

            var punсt_marks_arr = new string [] { ".", "...", ",", ":", ";", "!", "?", "-", "[", "]", "{", "}", "(", ")",  "<", ">"};
            
            for (int i = 0; i < punсt_marks_arr.Length; i++)
                str = str.Replace(punсt_marks_arr[i], "");
          
            var arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var i in arr)
                summa += i.Length;

            var av_word_len = summa / arr.Length;

            Console.WriteLine("");
            Console.WriteLine("Средняя длина слова равна: " + av_word_len);
            Console.ReadKey();
        }
    }
}

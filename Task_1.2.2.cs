using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Строка ввода 1:");
            var str_first_input = Console.ReadLine();
            Console.WriteLine("Строка ввода 2:");
            var str_sec_input = Console.ReadLine();
            var str_output = new StringBuilder(200);
            
           
            for (int i = 0; i < str_first_input.Length; i++)
            {
                if (str_sec_input.Contains(str_first_input[i]))
                {
                    str_output.Append(str_first_input[i]);
                    str_output.Append(str_first_input[i]);
                }
                else
                {
                    str_output.Append(str_first_input[i]);
                }
            }


            Console.WriteLine("Строка вывода размерностью в 200 символов:");
            Console.WriteLine(str_output);
            Console.ReadLine();
        }
    }
}

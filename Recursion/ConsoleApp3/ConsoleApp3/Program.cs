using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        // Без третьего параметра не запомнить начальное значение, 
        // поэтому добавим a_beg
        static void RecursiveSubProgramPOW(int a_int, int x_int, int a_beg)
        {
            if (x_int == 1) Console.WriteLine(a_int);
            else RecursiveSubProgramPOW(a_int * a_beg, x_int - 1, a_beg);
        }

        static void Main(string[] args)
        {
            int a_int, x_int;
            bool a_bool, x_bool;
            string s_input;

            Console.Write("Введите число A: ");
            s_input = Console.ReadLine();
            a_bool = int.TryParse(s_input, out a_int);

            Console.WriteLine();
            Console.Write("Введите степень X: ");
            s_input = Console.ReadLine();
            x_bool = int.TryParse(s_input, out x_int);
            Console.WriteLine();

            if (a_bool && x_bool)
            {
                Console.Write("Число " + a_int + " в степени " + x_int + " = ");
                RecursiveSubProgramPOW(a_int, x_int, a_int);
            } else
            {
                Console.WriteLine("Вы ввели не число!");
            }

            Console.ReadKey();
        }
    }
}

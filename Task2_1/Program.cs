using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c);

            Console.Write("Переворачиваем:");
            int t = c;
            c = b; b = a; a = t;
            Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c);

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}

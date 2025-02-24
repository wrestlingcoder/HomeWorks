using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число дюймов: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double b = a * 2.54;

            int meters = (int)b / 1000;
            int santimeters = (int)b % 100 /10;
            double millimeters = b % 10;

            Console.WriteLine("метры" + meters + "; сантиметры" + santimeters + "; миллиметры = " + millimeters);

            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите число градусов a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число минут a: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число секунд a: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(a + " градусов " + b + " минут " + c + " секунд");

            double angle = (a + (b + c / 60) / 60) * Math.PI / 180;
            Console.WriteLine(angle);

        }
    }
}

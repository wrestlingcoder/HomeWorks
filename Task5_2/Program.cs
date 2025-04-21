using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //// Сформировать одномерный массив из 10 случайных чисел из диапазона [-20, 20].
        //// Определить количество положительных, отрицательных и равных нулю элементов

        const int n = 10;
        int[] t = new int[n]; //массив из 10 чисел
        Random rnd = new Random(); //переменная rnd типа рандом
        int s1 = 0; // >0
        int s2 = 0; // <0
        int s3 = 0; // =0

        foreach (int a in t)
        {
            (t[a]) = rnd.Next(-20, 21); // перегрузка метода Next
            Console.Write("{0} ", t[a]); // шаблон "{0} "

            if (t[a] > 0) s1++;
            else if (t[a] < 0) s2++;
            else s3++;

        }
        Console.WriteLine();

        if (s1 > s2 && s1 > s3)
        {
            Console.WriteLine("Положительных чисел больше");
        }
        else if(s2 > s1 && s2 > s3)
        {
            Console.WriteLine("Отрицательных чисел больше");
        }
        else Console.WriteLine("Нулей больше");
    }
}
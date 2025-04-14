using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
        ////Сформировать двумерный массив из 10 строк и 5 столбцов. 
        ////Заполнить его случайными числами в диапазоне [0, 10].
        ////Определить максимальный элемент в каждой строке

        const int n = 10;
        const int m = 5;
        int[,] t = new int[n, m];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int max = 0;
            for (int j = 0; j < m; j++)
            {
                t[i, j] = rnd.Next(0, 11);
                Console.Write("{0,3} ", t[i, j]);
                if (t[i, j] > max) 
                {
                    max = t[i, j];
                }
            }
            Console.WriteLine(" max =" + "{0,3}" , max);
        }
        Console.ReadKey();
    }
}
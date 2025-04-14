internal class Program
{
    private static void Main(string[] args)
    {
        //// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 50].
        //// Найти и вывести значение максимального, минимального элементов и их индексы
        
        const int n = 10;
        int[] t = new int[n]; //массив из 10 чисел
        Random rnd = new Random(); //переменная rnd типа рандом
        int max = t[0];
        int max_index = 0;
        int min = 50;
        int min_index = 0;


        for (int i = 0; i < n; i++)
        {
            (t[i]) = rnd.Next(0, 51); // перегрузка метода Next
            Console.Write("{0} ", t[i]); // шаблон "{0} "

            if (max < t[i])
            {
                max = t[i];
                max_index = i;
            }
            
            if (min > t[i])
            {
                min = t[i];
                min_index = i;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine(" максимальное число под идексом " + max_index + " - " + max);
        Console.WriteLine(" минимальное число под идексом " + min_index + " - " + min);


    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 10].
        //// Перевернуть массив, т.е. переставить элементы массива в обратном порядке

        const int n = 10;
        int[] t = new int[n]; //массив из 10 чисел
        Random rnd = new Random(); //переменная rnd типа рандом

        for (int i = 0; i < n; i++)
        {
            (t[i]) = rnd.Next(0, 11); // перегрузка метода Next
            Console.Write("{0} ", t[i]); // шаблон "{0} "
            
        }

        Console.WriteLine();

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write("{0} ", t[i]); // шаблон "{0} "
        }

    }
}
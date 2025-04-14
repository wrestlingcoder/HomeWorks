internal class Program
{
    static void Main(string[] args)
    {
        //// Сформировать одномерный массив из 10 случайных чисел из диапазона [0, 100]. 
        //// Определить, каких чисел больше – четных или нечетных

        const int n = 10;
        int[] t = new int[n]; //массив из 10 чисел
        Random rnd = new Random(); //переменная rnd типа рандом
        int s1 = 0;
        int s2 = 0;

        foreach (int a in t)
        {
            (t[a]) = rnd.Next(0, 101); // перегрузка метода Next
            Console.Write("{0} ", t[a]); // шаблон "{0} "

            if (t[a] % 2 == 0)
            {
                s1 += 1;
            }
            else
            {
                s2 += 1;
            }
        }
        Console.WriteLine();
        if (s1 > s2)
        {
            Console.WriteLine("Четных чисел больше");
        }
        else
        {
            Console.WriteLine("Нечетных чисел больше");
        }
    }
}
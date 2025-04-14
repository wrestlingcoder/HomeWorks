internal class Program
{
    private static void Main(string[] args)
    {
        //// Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50, 50]. 
        //// Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
        //// Вывести отсортированный таким образом массив на экран

        const int n = 10;
        int[] t = new int[n]; //массив из 10 чисел
        Random rnd = new Random(); //переменная rnd типа рандом
        int max = t[0];
        int max_index = 0;
        int min = 50;
        int min_index = 0;

        for (int i = 0; i < 10; i++)
        {
            (t[i]) = rnd.Next(-50, 51); // перегрузка метода Next
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
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (t[i] > t[j])
                {
                    int temp = t[i];
                    t[i] = t[j];
                    t[j] = temp;
                }
            }
            Console.Write("{0} ", t[i]);
            
        }

        for (int i = n-1; i > 4; i--)
        {
            for (int j = i - 1; j > 4; j--)
            {
                if (t[i] < t[j])
                {
                    int temp = t[i];
                    t[i] = t[j];
                    t[j] = temp;
                }
            }
            Console.Write("{0} ", t[i]);
            
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //Вводится n. Определить, является ли оно степенью 2-ки?

        Console.Write("Введите целое число: ");

        double n = Convert.ToDouble(Console.ReadLine());
        double s = 1;
        const int two = 2;
        double i = 0;

        for (i=0; i >= 0; i++)
        {

            if (s < n)
            {
                s *= two;
            }
            else
            {
                break;
            }
        }

        if (s == n)
        {
            Console.WriteLine($"Число {n} является {i} степенью 2-ки");
        }
        else
        { 
            Console.WriteLine($"Число {n} не является степенью 2-ки"); 
        }
    }
}
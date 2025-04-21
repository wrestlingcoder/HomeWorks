internal class Program
{
    private static void Main(string[] args)
    {
        // Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math


        Console.Write("Введите целое положительное число a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите целое положительное число b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        if ((a > 0) && (b > 0))
        {
            double s = 1;

            for (double i = 1; i <= b; i++)
            {
                s *= a;
            }
            Console.WriteLine($"a^b = {s}");

        }
        else
        {
            Console.WriteLine("Введеное число не положительное");
        }
    }
}
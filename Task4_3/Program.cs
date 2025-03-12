internal class Program
{
    private static void Main(string[] args)
    {
        // Вводятся целые числа a>0, b>0. Найти a^b. Не использовать класс Math


        Console.Write("Введите натуральное число a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите натуральное число b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double s = 1;

        for (double i = 1; i <= b; i++)
        {
            s = s * a ;
        }
        Console.WriteLine($"a^b = {s}");
    }
}
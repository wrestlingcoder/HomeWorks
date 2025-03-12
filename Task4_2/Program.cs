internal class Program
{
    private static void Main(string[] args)
    {
        // Вводится натуральное число n. Найти 1 + 1/2 + 1/3 + … + 1/n

        Console.Write("Введите натуральное число n: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double s = 0;

        for (double i = 1; i <= n; i++)
        {
            s += (1/i);
        }
        Console.WriteLine($"1/n! = {s}");
    }
}
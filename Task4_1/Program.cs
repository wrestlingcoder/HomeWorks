internal class Program
{
    private static void Main(string[] args)
    {
        // Вводится натуральное число n. Найти n!Например, 6! = 1 * 2 * 3 * 4 * 5 * 6.

        Console.Write("Введите натуральное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 1;

        for (int i = 1; i <= n; i++)
        {
            a = a * i;
        }

        Console.WriteLine($"{n}!={a}");
    }
}
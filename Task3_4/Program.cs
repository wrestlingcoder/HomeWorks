internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if ((a <= b && c >= b) || (c <= b && a >= b))
        {
            Console.WriteLine(b);
        }
        else
        if ((b <= c && a >= c) || (a <= c && b >= c))
        {
            Console.WriteLine(c);
        }
        else
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadKey(); //
    }
}
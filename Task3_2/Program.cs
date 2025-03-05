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


        if (a <= b && b <=c)
        {
            Console.WriteLine(c);
        }
        else
            if (b <= c && c <= a)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }

        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadKey();
    }
}
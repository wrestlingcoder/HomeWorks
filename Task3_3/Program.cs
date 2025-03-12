internal class Program
{
    private static void Main(string[] args)
    {
        ////Вводятся четыре числа. Вывести большее из них.

        Console.Write("Введите первое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число c: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число d: ");
        int d = Convert.ToInt32(Console.ReadLine());


        if (a <= b && c <= b && d <= b)
        {
            Console.WriteLine(b);
        }
        else
        if (b <= c && a <= c && d <= c)
        {
            Console.WriteLine(c);
        }
        else
        if (b <= d && a <= d && c <= d)
        {
            Console.WriteLine(d);
        }
        else
        {
            Console.WriteLine(a);
        }

        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadKey(); //
    }
}
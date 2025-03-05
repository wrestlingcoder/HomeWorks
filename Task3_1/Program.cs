internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadKey();
    }
}
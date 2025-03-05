internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 10 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

    }
}
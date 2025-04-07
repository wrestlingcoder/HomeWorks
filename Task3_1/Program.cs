internal class Program
{
    private static void Main(string[] args)
    {
        ////Вводятся два числа. Сравнить их и вывести правильный знак «<», «>» или «=».

        Console.Write("Введите первое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        if (a == b)
        {
            Console.WriteLine("=");
        }
        else
            if (a < b)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine(">");
        }

        Console.WriteLine("Нажмите любую клавишу");
        Console.ReadKey(); //
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        ////Вводится число. Вывести «Да», если оно попадает в диапазон[-10, 10], и «Нет» в противном случае.

        Console.Write("Введите первое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b;

        if (a >= 0)
        {
            b = a;
        }
        else
        {
            b = -a;
        }

        if (b <= 10)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }

    }

}
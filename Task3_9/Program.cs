internal class Program
{
    private static void Main(string[] args)
    {
        ////Вводится число. Вывести «Да», если оно попадает в диапазон (-∞; -10] Ս [10; +∞), и «Нет» в противном случае.


        Console.Write("Введите первое число a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b;

        if (a >= 0)
        {
            b = a;
        }
        else
        {
            b = -a;
        }

        if (b >= 10 )
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        ////Вводится число. Вывести «Да», если оно четное, и «Нет» в противном случае.

        Console.Write("Введите первое число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        ////Вводится число. Вывести «Да», если оно оканчивается на 0, и «Нет» в противном случае.
        
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
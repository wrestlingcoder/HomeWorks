internal class Program
{
    private static void Main(string[] args)
    {
        //Вводится n. Определить количество цифр в числе

        Console.Write("Введите целое число: ");

        int n = Convert.ToInt32(Console.ReadLine());

        int number = n;
        const int one = 1;
        const int ten = 10;
        int i = 0;

        for (i = 0; i >= 0; i++)
        {

            if (number >= one)
            {
                number /= ten;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"В числе {n} - количество цифр равно {i}");
        
        
    }
}
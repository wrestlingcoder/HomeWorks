internal class Program
{
    private static void Main(string[] args)
    {
        //Запрашивать у пользователя число до тех пор, пока он не введет число из диапазона [20; 60]

        for (int i = 1; i > 0; i++)
        {
            Console.Write("Введите число из диапазона [20; 60]: ");
            double a = Convert.ToDouble(Console.ReadLine());

            if ((a >= 20) && (a <= 60))
            {
                Console.WriteLine("Вы попали в указанный диапазон");
                break;
            }
            else
            {
                Console.WriteLine("Введены не верные исходные данные");
            }
        }
    }
}
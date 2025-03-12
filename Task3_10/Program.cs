internal class Program
{
    private static void Main(string[] args)
    {
        ////Застройщик построил n домов. Вывести фразу «Мы построили n домов», 
        ///обеспечив правильное согласование числа со словом «дом», 
        ///например: 20 — «Мы построили 20 домов», 32 — «Мы построили 32 дома», 41 — «Мы построили 41 дом».

        Console.Write("Введите число домов: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int b = n % 10;

        if (10 < n && n < 20)
        {
            Console.WriteLine($"Мы построили {n} домов");
        }
        else
        {

            switch (b)
            {
                case 1:
                    Console.WriteLine($"Мы построили {n} дом");
                    break;

                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"Мы построили {n} дома");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    Console.WriteLine($"Мы построили {n} домов");
                    break;
            }
        }
    }
}
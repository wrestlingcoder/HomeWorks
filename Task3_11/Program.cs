internal class Program
{
    private static void Main(string[] args)
    {
        // Можно ли на прямоугольном участке застройки размером
        // a* b метров разместить два дома размером в плане p *q и r *s метров?
        // Дома можно располагать только параллельно сторонам участка. Дома могу стоять «вплотную» друг к другу.//

        Console.Write("Введите число a:  ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b:  ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число p:  ");
        int p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число q:  ");
        int q = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Введите число r:  ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число s:  ");
        int s = Convert.ToInt32(Console.ReadLine());
        

        if     ((b >= p + s && a >= q + r) ||
                (b >= p + r && a >= q + s) ||
                (b >= q + s && a >= p + r) ||
                (b >= q + r && a >= p + s))
        {
            Console.Write($"2 дома с размерами {p} на {q} и {r} на {s} влезут на площадку с размерами {a} на {b}");
        }
        else
        {
            Console.Write($"2 дома с размерами {p} на {q} и {r} на {s} НЕ влезут на площадку с размерами {a} на {b}"); 
        }
    }
}
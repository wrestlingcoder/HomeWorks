internal class Program
{
    static void Main(string[] args)
    {
        const int n = 5;
        int[,] t = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                t[i, j] = i == j ? 1 : 0;
                Console.Write("{0} ", t[i, j]);
            }
            Console.WriteLine();    
        }
        Console.ReadKey();
    }
}
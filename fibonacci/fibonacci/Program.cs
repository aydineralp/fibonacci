namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci Serisi:");

            int a = 0;
            int b = 1;
            int c;

            Console.Write($"{a} {b} ");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }

            Console.WriteLine(); // Yeni satır ekler.
        }
    }
}

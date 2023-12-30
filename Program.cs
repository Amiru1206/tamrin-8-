namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plz en ur num");
            int x = int.Parse(Console.ReadLine());
            string y = Fibo(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        static string Fibo(int x)
        {
            int f1 = 0, f2 = 1;
            if (x == 1)
                return f1.ToString();
            else if (x == 2)
                return f2.ToString();
            else if (x >= 3)
                return (int.Parse(Fibo(x - 1)) + int.Parse(Fibo(x - 2))).ToString();
            else
                return "error";
        }
    }
}
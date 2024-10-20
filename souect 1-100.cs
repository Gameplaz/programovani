namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  value = 0;

            for (int i = 0; i <= 100; i++) {
                value += i;
            }

            Console.WriteLine(value);
        }
    }
}

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aString = Console.ReadLine();
            int a = Convert.ToInt32(aString);
            int result = a;

            for (a = a - 1; a > 0; a--) { 
                result *= a;
            }

            Console.WriteLine(result);
        }
    }
}

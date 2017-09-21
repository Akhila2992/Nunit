using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter 2 numbers\n");
            int n1;
            int n2;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            MathsHelper helper = new MathsHelper();

            int x = helper.Add(n1, n2);

            Console.WriteLine("\n the sum is " + x);

            int y = helper.Subtract(n1, n2);

            Console.WriteLine("\n the difference is " + y);

            Console.ReadKey();
        }
    }

    public class MathsHelper
    {

        public MathsHelper()
        {
        }

        public int Add(int a, int b)
        {

            return a + b;


        }

        public int Subtract(int a, int b)
        {

            return a - b;

        }

    }
}

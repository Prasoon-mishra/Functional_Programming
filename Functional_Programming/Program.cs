namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Functional Programming");
            Console.WriteLine("Enter 1 for Fibonacci Series");
            int Ans=Convert.ToInt32(Console.ReadLine());
            switch(Ans)
            {
                case 1: Fibonacci FibonacciObj = new Fibonacci();
                    FibonacciObj.Fibonacci_Series();
                    break;
                default: Console.WriteLine("Entered Value is Wrong");
                    break;
            }
        }
    }
}
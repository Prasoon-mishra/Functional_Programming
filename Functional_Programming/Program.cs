namespace Functional_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Functional Programming");
            Console.WriteLine("Enter 1 for Fibonacci Series");
            Console.WriteLine("Enter 2 for Perfect Number");
            Console.WriteLine("Enter 3 for Prime Number");
            int Ans=Convert.ToInt32(Console.ReadLine());
            switch(Ans)
            {
                case 1: Fibonacci FibonacciObj = new Fibonacci();
                    FibonacciObj.Fibonacci_Series();
                    break;
                case 2: PerfectNumber PerfectObj= new PerfectNumber();
                    PerfectObj.Perfect();
                    break;
                case 3: PrimeNumber PrimeObj= new PrimeNumber();
                    PrimeObj.Prime();
                    break;
                default: Console.WriteLine("Entered Value is Wrong");
                    break;
            }
        }
    }
}
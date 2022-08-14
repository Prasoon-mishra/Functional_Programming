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
            Console.WriteLine("Enter 4 for Reverse Number");
            Console.WriteLine("Enter 5 for Coupon Number");
            Console.WriteLine("Enter 6 for Stop Watch");
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
                case 4: ReverseNumber ReverseObj= new ReverseNumber();  
                    ReverseObj.Reverse();
                    break;
                case 5:
                    Coupon couponObj = new Coupon();
                    couponObj.Coupon_Number();  
                    break;
                case 6:
                    StpWatch StopObj = new StpWatch();
                    StopObj.Stop_Watch();
                    break;
                default: Console.WriteLine("Entered Value is Wrong");
                    break;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class Fibonacci
    {
        public void Fibonacci_Series()
        {
            Console.WriteLine("Enter the Terms for Fibonacci Series");
            int Terms= Convert.ToInt32(Console.ReadLine());
            int First_Term = 0;
            int Second_Term = 1;
            int Third_Term = 0;
            Console.WriteLine(First_Term);
            Console.WriteLine(Second_Term);
            while( Terms > 0 )
            {
                Third_Term = First_Term + Second_Term;
                Console.WriteLine(Third_Term);
                First_Term = Second_Term;
                Second_Term = Third_Term;
                Terms--;
            }
        }
    }
}

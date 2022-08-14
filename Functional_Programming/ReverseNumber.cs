using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter the number to be reversed");
            int Number=Convert.ToInt32(Console.ReadLine());
            int Rev = 0;
            int sum = 0;
            while(Number != 0)
            {
                Rev = Number % 10;
                sum = Rev + sum * 10;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse of the number "+Number+" is "+sum);
        }
    }
}

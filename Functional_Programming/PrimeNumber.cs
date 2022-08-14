using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter the number to check whether prime or not");
            int Number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            int loop = Number / 2;
            for(int i = 2; i < loop; i++)
            {
                if(Number % i == 0)
                {
                    Console.WriteLine("Number is not prime"); 
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number is Prime");
            }
        }
    }
}

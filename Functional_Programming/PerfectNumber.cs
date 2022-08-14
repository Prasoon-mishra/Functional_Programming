using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functional_Programming
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("Enter the Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            int i,sum = 0;
            for(i = 1; i < Number; i++)
            {
                if(Number%i==0)
                {
                    sum=sum+i;
                }
            }
            if(sum==Number)
            {
                Console.WriteLine("Number is Perfect");
            }
            else
            {
                Console.WriteLine("Number is not Perfect");
            }
        }
    }
}

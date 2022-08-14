using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Functional_Programming
{
    public class StpWatch
    {
        public void Stop_Watch()
        {
            var timer = new Stopwatch();
            timer.Start();

            //B: Run stuff you want timed
            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");

        }
    }
}

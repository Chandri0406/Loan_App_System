using Loan_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class Counter
    {
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

        // Raises the event  and pass EventArgs custom data
        public void DoSomething()
        {
            ThresholdReachedEventArgs e = new ThresholdReachedEventArgs
            {
                Threshold = 100000
            };

            //Raise actual event
            ThresholdReached?.Invoke(this, e);
        }

        // 4. Handle the event which is raised by publisher
        internal static void OnThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine($"Loan Threshold {e.Threshold}!!!");
            Console.WriteLine("=============================================");
            Console.WriteLine("Loan amount exceeded the maximum threshold.");
            Console.WriteLine("Please enter a value under 100,000.");
        }
    }

    internal class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
    }
}

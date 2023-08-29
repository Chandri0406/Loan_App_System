using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    abstract class Loan : ILoanConstants
    {
        private string custFirstname, custLastname;
        private int loanNumber, term;
        private double loanAmount, primeInterestRate;

        public Loan()
        {
            
        }

        public Loan(string custFirstname, string custLastname, int term, int loanNumber, double loanAmount, double primeInterestRate)
        {
            this.CustFirstname = custFirstname;
            this.CustLastname = custLastname;
            this.LoanNumber = loanNumber;
            this.Term = term;
            if (term != shortTermLoan && term != mediumTermLoan && term!= longTermLoan)
            {
                this.term = shortTermLoan;
            }
            this.LoanAmount = loanAmount;
            this.InterestRate = primeInterestRate;
        }

        public string CustFirstname { get => custFirstname; set => custFirstname = value; }
        public string CustLastname { get => custLastname; set => custLastname = value; }
        public int Term { get => term; set => term = value; }
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => primeInterestRate; set => primeInterestRate = value; }
        public int shortTermLoan { get; set; } = 1;
        public int mediumTermLoan { get; set; } = 3;
        public int longTermLoan { get; set; } = 5;
        public string companyName { get; set; }


        public override string ToString()
        {
            return $"A customer name: \n{CustFirstname} {CustLastname} \nLoan number: {LoanNumber} \nloan amount of: R{LoanAmount} \nInterest rate of: % \nLoan term: {Term} \nTotal amount owed at due date: R ";
        }

        // Handle the event which is raised by publisher
        public static void OnThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine($"Loan Threshold {e.Threshold}!!!");
            Console.WriteLine("=============================================");
            Console.WriteLine("Please enter a value under 100,000.");

        }

        public static double LoanAmountExceeded(double loanAmount)
        {
            while (loanAmount >= 100000)
            {
                // Create instance of counter
                Counter counter = new Counter();
                // Attach the event handler on the publisher
                counter.ThresholdReached += OnThresholdReached;
                counter.DoSomething();
                Console.WriteLine("Loan Amount:");
                loanAmount = double.Parse(Console.ReadLine());
                return loanAmount;
            }
            return 0;
        }

        public virtual double CalculateLoan()
        {
            return 0;
        }
    }
}

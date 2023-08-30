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
        private string custFirstname, custLastname, term;
        private int loanNumber, termPeriod;
        private double loanAmount, primeInterestRate;

        public Loan()
        {
            
        }

        public Loan(string custFirstname, string custLastname, string term, int termPeriod, int loanNumber, double loanAmount, double primeInterestRate)
        {
            this.CustFirstname = custFirstname;
            this.CustLastname = custLastname;
            this.LoanNumber = loanNumber;
            this.Term = term;
            this.TermPeriod = termPeriod;
            this.LoanAmount = loanAmount;
            this.InterestRate = primeInterestRate;
        }

        public string CustFirstname { get => custFirstname; set => custFirstname = value; }
        public string CustLastname { get => custLastname; set => custLastname = value; }
        public string Term { get => term; set => term = value; }
        public int TermPeriod { get => termPeriod; set => termPeriod = value; }
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => primeInterestRate; set => primeInterestRate = value; }
        public int shortTermLoan { get; set; } = 1;
        public int mediumTermLoan { get; set; } = 3;
        public int longTermLoan { get; set; } = 5;
        public string companyName { get; set; }

        public override string ToString()
        {
            return $"Customer name: {CustFirstname} \nCustomer surname: {CustLastname} \nLoan number: {LoanNumber} \nLoan amount: R {LoanAmount} \nInterest rate: % \nLoan term: {Term} \nTotal amount owed at due date: R "; ;
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
            if (loanAmount < 100000)
            {
                return loanAmount;
            }
            else if (loanAmount >= 100000)
            {
                // Create instance of counter
                Counter counter = new Counter();
                // Attach the event handler on the publisher
                counter.ThresholdReached += OnThresholdReached;
                counter.DoSomething();
                Console.WriteLine("Loan Amount:");
                loanAmount = double.Parse(Console.ReadLine());
                return LoanAmountExceeded(loanAmount);
            }
            return loanAmount;
        }

        public virtual double CalculateLoan()
        {
            return 0;
        }
    }
}

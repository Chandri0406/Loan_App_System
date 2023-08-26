using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    abstract class Loan
    {
        private string custFirstname, custLastname, term;
        private int loanNumber;
        private double loanAmount, primeInterestRate;

        public Loan()
        {
            
        }

        public Loan(string custFirstname, string custLastname, string term, int loanNumber, double loanAmount, double primeInterestRate)
        {
            this.CustFirstname = custFirstname;
            this.CustLastname = custLastname;
            this.LoanNumber = loanNumber;
            this.Term = term;
            this.LoanAmount = loanAmount;
            this.InterestRate = primeInterestRate;
        }

        // need an event for when loan greater than 100 000
        public string CustFirstname { get => custFirstname; set => custFirstname = value; }
        public string CustLastname { get => custLastname; set => custLastname = value; }
        public string Term { get => term; set => term = value; }
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => primeInterestRate; set => primeInterestRate = value; }

        public override string ToString()
        {
            return $"A customer name: \n{custFirstname} {custLastname} \nLoan number: {loanNumber} \nloan amount of: R{loanAmount} \nInterest rate of: % \nLoan term: {term}";
        }
    }
}

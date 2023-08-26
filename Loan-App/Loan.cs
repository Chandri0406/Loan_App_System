using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    public abstract class Loan
    {
        private string custFirstname, custLastname;
        private int loanNumber, term;
        private double loanAmount, interestRate;

        public Loan()
        {
            term = 1;
        }

        protected Loan(string custFirstname, string custLastname, int loanNumber, int term, double loanAmount, double interestRate)
        {
            this.CustFirstname = custFirstname;
            this.CustLastname = custLastname;
            this.LoanNumber = loanNumber;
            this.Term = term;
            this.LoanAmount = loanAmount;
            this.InterestRate = interestRate;
        }

        // need an event for when loan greater than 100 000
        public string CustFirstname { get => custFirstname; set => custFirstname = value; }
        public string CustLastname { get => custLastname; set => custLastname = value; }
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public int Term { get => term; set => term = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }

        public override string ToString()
        {
            return $"A customer named: {custFirstname} {custLastname} has loan number: {loanNumber} with a loan amount of: R{loanAmount}, an interest rate of: %, and a loan term of: {term} years.";
        }
    }
}

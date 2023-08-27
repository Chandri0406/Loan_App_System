using System;
using System.Collections.Generic;
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
            this.LoanAmount = loanAmount;
            this.InterestRate = primeInterestRate;
        }

        protected abstract void LoanTerm(int term);


        // need an event for when loan greater than 100 000
        public event EventHandler loanAmountExceeded;
        public string CustFirstname { get => custFirstname; set => custFirstname = value; }
        public string CustLastname { get => custLastname; set => custLastname = value; }
        public int Term { get => term; set => term = value; }
        public int LoanNumber { get => loanNumber; set => loanNumber = value; }
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => primeInterestRate; set => primeInterestRate = value; }
        public int shortTermLoan { get; set; } = 1;
        public int mediumTermLoan { get; set; } = 3;
        public int longTermLoan { get; set; } = 5;
        public string companyName { get; set; } = "Unique Building Services Loan Company";
        public double maxLoanAmount { get; set; } = 100000;

        public override string ToString()
        {
            return $"A customer name: \n{custFirstname} {custLastname} \nLoan number: {loanNumber} \nloan amount of: R{loanAmount} \nInterest rate of: % \nLoan term: {term}";
        }

        void ILoanConstants.LoanTerm(int term)
        {
            if (term != shortTermLoan || term != mediumTermLoan || term != longTermLoan)
            {
                this.term = shortTermLoan;
            }
        }
    }
}

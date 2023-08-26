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
<<<<<<< HEAD
        private double loanAmount, interestRate;
=======
        private double loanAmount, primeInterestRate;
>>>>>>> 3cda6e6f82701d8301f4b132c27697e35cc0fb9e

        public Loan()
        {
            
        }

<<<<<<< HEAD
        protected Loan(string custFirstname, string custLastname, int loanNumber, string term, double loanAmount)
=======
        public Loan(string custFirstname, string custLastname, string term, int loanNumber, double loanAmount, double primeInterestRate)
>>>>>>> 3cda6e6f82701d8301f4b132c27697e35cc0fb9e
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
<<<<<<< HEAD
        public string Term { get => term; set => term = value; }
=======
>>>>>>> 3cda6e6f82701d8301f4b132c27697e35cc0fb9e
        public double LoanAmount { get => loanAmount; set => loanAmount = value; }
        public double InterestRate { get => primeInterestRate; set => primeInterestRate = value; }

        public override string ToString()
        {
            return $"A customer named: {custFirstname} {custLastname} has loan number: {loanNumber} with a loan amount of: R{loanAmount}, an interest rate of: %, and a loan term of: {term} years.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class BusinessLoan : Loan
    {
        private double businessInterestrate, totalAmount;
        private string businessName;
        /*
        how this would work 
        basically the program would start by asking if the person is a business or an individual
        if they are a business then all it would need to do is add 1 to the banks interest rate
         */

        public BusinessLoan(string businessName, string custFirstname, string custLastname, string term, int termPeriod, int loanNumber,  double loanAmount, double interestRate) : base(custFirstname, custLastname, term, termPeriod, loanNumber,  loanAmount , interestRate)
        {
            this.BusinessInterestrate = InterestRate + 1; // BusinessLoan constructor sets the interest rate to 1% more than the current prime interest rate.
            this.BusinessName = businessName;
        }

        public double BusinessInterestrate { get => businessInterestrate; set => businessInterestrate = value; }
        public string BusinessName { get => businessName; set => businessName = value; }

        public override double CalculateLoan()
        {
            totalAmount = LoanAmount * (1 + (businessInterestrate / 100) * TermPeriod);
            return totalAmount;
        }

        public override string ToString()
        {
            return $"Business Name: {businessName} \nCustomer name: {CustFirstname} \nCustomer surname: {CustLastname} \nLoan number: {LoanNumber} \nLoan amount: R {LoanAmount} \nInterest rate: {businessInterestrate}% \nLoan term: {Term} of {TermPeriod} year(s) \nTotal amount owed at due date: R {totalAmount}";
        }
    }
}

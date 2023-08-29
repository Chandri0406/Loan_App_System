using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class PersonalLoan : Loan
    {
        private double personalInterestrate;

        public PersonalLoan(string custFirstname, string custLastname, string term, int loanNumber, double loanAmount, double interestRate, double termPeriod) : base(custFirstname, custLastname, term, loanNumber, loanAmount, interestRate, termPeriod)
        {
            this.PersonalInterestrate = InterestRate + 2; // instructions : "PersonalLoan constructor sets the interest rate to 2% more than the current prime interest rate. "
        }

        //Add Calculation override method based on personal interrest rate

        public double PersonalInterestrate { get => personalInterestrate; set => personalInterestrate = value; }

        public override double CalculateLoan()
        {
            return LoanAmount * ((1 + personalInterestrate * TermPeriod) / 100);
        }

        public override string ToString()
        {
            return $"A customer name: \n{CustFirstname} {CustLastname} \nLoan number: {LoanNumber} \nloan amount of: R{LoanAmount} \nInterest rate of: {personalInterestrate}% \nLoan term: {Term} \nTotal amount owed at due date: R{CalculateLoan()}";
        }
    }

}

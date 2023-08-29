using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class PersonalLoan : Loan
    {
        private double personalInterestrate, totalAmount;
        private int termPeriod;

        private double personalInterestrate;

        public PersonalLoan(string custFirstname, string custLastname, int loanNumber, int term, double loanAmount, double interestRate) : base(custFirstname, custLastname, term, loanNumber, loanAmount, interestRate)
        {
            this.PersonalInterestrate = InterestRate + 2; // instructions : "PersonalLoan constructor sets the interest rate to 2% more than the current prime interest rate. "
        }

        public int termPeroid { get => termPeriod; set => termPeriod = value; }
        public double PersonalInterestrate { get => personalInterestrate; set => personalInterestrate = value; }

        public override double CalculateLoan()
        {
            totalAmount = LoanAmount * (1 + (personalInterestrate / 100) * termPeriod);
            return totalAmount;
        }

        public override string ToString()
        {
            return $"Customer name: {CustFirstname} \nCustomer surname: {CustLastname} \nLoan number: {LoanNumber} \nLoan amount: R {LoanAmount} \nInterest rate: {personalInterestrate}% \nLoan term: {Term} \nTotal amount owed at due date: R {totalAmount}";
        }
    }

}

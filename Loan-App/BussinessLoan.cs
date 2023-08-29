using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class BussinessLoan : Loan
    {   
        private double bussinessInterestrate ;
        private string bussinessName;
        /*
        how this would work 
        basically the program would starrt by asking if the person is a business or an individual
        if they are a business then all it would need to do is add 1 to the banks interest rate
         */

        /*public BussinessLoan(string businessName, double businessInterestrate, string custFirstname, string custLastname, int loanNumber, string term, double loanAmount, double interestRate) : base(custFirstname, custLastname, term, loanNumber,  loanAmount , interestRate)
        {
            this.BussinessInterestrate = InterestRate + 1; // instructions : "BusinessLoan constructor sets the interest rate to 1% more than the current prime interest rate. "
            this.BussinessName = businessName;
        }*/

        public BussinessLoan(string custFirstname, string custLastname, string term, int loanNumber,  double loanAmount, double interestRate) : base(custFirstname, custLastname, term, loanNumber, loanAmount, interestRate)
        {
            this.BussinessInterestrate = InterestRate + 1; // instructions : "PersonalLoan constructor sets the interest rate to 2% more than the current prime interest rate. "

        }

        //Add Calculation override method based on bussiness interrest rate

        public double BussinessInterestrate { get => bussinessInterestrate; set => bussinessInterestrate = value; }
        public string BussinessName { get => bussinessName; set => bussinessName = value; }

        /*public void bLoan() // call this method in the eveht of a business loan
        {
            businessInterestrate = InterestRate + 1;
        }*/

        public override string ToString()
        {
            return $"A customer name: \n{CustFirstname} {CustLastname} \nLoan number: {LoanNumber} \nloan amount of: R{LoanAmount} \nInterest rate of: {bussinessInterestrate}% \nLoan term: {Term}";
        }

        public override double CalculateLoan()
        {
            return base.CalculateLoan();
        }
    }
}

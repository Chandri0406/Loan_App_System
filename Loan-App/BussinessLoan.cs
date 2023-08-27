﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class BussinessLoan : Loan
    {   
        private double businessInterestrate ;
        private string businessName;
        /*
        how this would work 
        basically the program would starrt by asking if the person is a business or an individual
        if they are a business then all it would need to do is add 1 to the banks interest rate
         */

        /*public BussinessLoan(string businessName, double businessInterestrate, string custFirstname, string custLastname, int loanNumber, string term, double loanAmount, double interestRate) : base(custFirstname, custLastname, term, loanNumber,  loanAmount , interestRate)
        {
            this.BusinessInterestrate = InterestRate + 1; // instructions : "BusinessLoan constructor sets the interest rate to 1% more than the current prime interest rate. "
            this.BusinessName = businessName;
        }*/

        public BussinessLoan(string custFirstname, string custLastname, int loanNumber, string term, double loanAmount, double interestRate) : base(custFirstname, custLastname, term, loanNumber, loanAmount, interestRate)
        {
            this.BusinessInterestrate = InterestRate + 1; // instructions : "PersonalLoan constructor sets the interest rate to 2% more than the current prime interest rate. "

        }
        public double BusinessInterestrate { get => businessInterestrate; set => businessInterestrate = value; }
        public string BusinessName { get => businessName; set => businessName = value; }

        /*public void bLoan() // call this method in the eveht of a business loan
        {
            businessInterestrate = InterestRate + 1;
        }*/

        public override string ToString()
        {
            return $"A customer name: \n{CustFirstname} {CustLastname} \nLoan number: {LoanNumber} \nloan amount of: R{LoanAmount} \nInterest rate of: {businessInterestrate}% \nLoan term: {Term}";
        }
    }
}

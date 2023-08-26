using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class BussinessLoan : Loan
    {   

        /*
         
        how this would work 
         
        basically the program would starrt by asking if the person is a business or an individual

        if they are a business then all it would need to do is add 1 to the banks interest rate
         */
        private double businesInterestrate ;

        public BussinessLoan() 
        {
        
        }
        public BussinessLoan( double businesInterestrate, string custFirstname, string custLastname, int loanNumber, int term, double loanAmount, double interestRate) : base(custFirstname, custLastname, loanNumber, term, loanAmount , interestRate)
        {
            this.BusinesInterestrate = businesInterestrate ;

        }

        public double BusinesInterestrate { get => businesInterestrate; set => businesInterestrate = value; }

        public void bLoan() // call this method in the eveht of a business loan
        {
            businesInterestrate = InterestRate + 1;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

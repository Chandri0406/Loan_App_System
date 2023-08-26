using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class BussinessLoan : Loan
    {   

        private double businesInterestrate ;
        private string businessName;

        public BussinessLoan() 
        {
        
        }
        public BussinessLoan(string businessName, string custFirstname, string custLastname, int loanNumber, int term, double loanAmount, double interestRate) : base(custFirstname, custLastname, loanNumber, term, loanAmount , interestRate)
        {
            this.BusinesInterestrate = InterestRate + 1; // instructions : "BusinessLoan constructor sets the interest rate to 1% more than the current prime interest rate. "
            this.BusinessName = businessName;
        }
        
        public double BusinesInterestrate { get => businesInterestrate; set => businesInterestrate = value; }
        public string BusinessName { get => businessName; set => businessName = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    public interface ILoanConstants
    {
        // Constant values for Loan Terms, Company Name and Max Loan Amount
        string companyName { get; set; }
        double maxLoanAmount { get; set; }
        int shortTermLoan { get; set; }
        int mediumTermLoan { get; set; }
        int longTermLoan { get; set; }
        void LoanTerm(int term);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    enum Menu 
    {
        AddBL = 1,
        AddPl,
        Exit
    }
    internal class CreateLoans
    {
        string custFirstname, custLastname;
        int loanNumber, term;
        double loanAmount;
        bool Continue = true;
        List<BussinessLoan> Bloan = new List<BussinessLoan>();
        List<PersonalLoan> Ploan = new List<PersonalLoan>();
        

        while(Continue)
        {
            Console.WriteLine("1. Add Business Loan");
            Console.WriteLine("2. Add Personal Loan");
            Console.WriteLine("3. Exit");
        }
    }
}

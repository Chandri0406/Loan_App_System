using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class CreateLoans
    {
        static void Main(string[] args)
        {
            //An application that creates an array of five Loans. Prompt the user for the current 
            //prime interest rate.Then, in a loop, prompt the user for a loan type and all relevant information for
            //that loan. Store the created Loan objects in the array.When data entry is complete, display all the
            //loans.
            
            /*IMPORTANT LIST
             Loan Amount needs to be calculated
             Loan Amount limit must be set
             Form display needs fixing
             Form linking needs to be done
             Bussiness class does nor need cust name or cust lastname, but needs bussiness name
             User manual needs to be created DO THAT TODAY
             Comments need to be added
             Names & Student nums need to be added
             */

            string custFirstname, custLastname;
            int loanNumber, term;
            double loanAmount, primeInterestRate;
            Loan[] loans = new Loan[5];

            //A prompt for the prime interest rate
            Console.WriteLine("Enter the prime interest rate");
            primeInterestRate = double.Parse(Console.ReadLine());

            //A loop for 5 loans
            for (int i=0; i<1; i++)
            {
                Console.WriteLine("Type of loan: \n 1. Business Loan \n 2. Personal Loan");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) // Business Loan
                {
                    Console.WriteLine("Loan Number:");
                    loanNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Customer Name:");
                    custFirstname = Console.ReadLine();

                    Console.WriteLine("Customer Surname:");
                    custLastname = Console.ReadLine();

                    Console.WriteLine("Loan Amount:");
                    loanAmount = double.Parse(Console.ReadLine());

                    Console.WriteLine("Term:");
                    term = int.Parse(Console.ReadLine());
                    


                    loans[i] = new BusinessLoan(custFirstname, custLastname, loanNumber, term, loanAmount, primeInterestRate);
                    
                }
                else // Personal Loan
                {
                    Console.WriteLine("Loan Number:");
                    loanNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Customer Name:");
                    custFirstname = Console.ReadLine();

                    Console.WriteLine("Customer Surname:");
                    custLastname = Console.ReadLine();

                    Console.WriteLine("Loan Amount:");
                    loanAmount = double.Parse(Console.ReadLine());

                    Console.WriteLine("Term:");
                    term = int.Parse(Console.ReadLine());

                    loans[i] = new PersonalLoan(custFirstname, custLastname, loanNumber, term, loanAmount, primeInterestRate);
                }
   
            }


            Console.WriteLine("\nLoans created:");
            foreach (Loan loan in loans)
            {
                if (loan != null)
                {
                    Console.WriteLine("\n" + loan.ToString());
                }
            }

            Console.ReadLine();
        
        }
    }
}

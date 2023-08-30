using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_App
{
    internal class CreateLoans
    {    /* STUDENTS
          * Chandri Breytenbach 577398
          * Frank Peter Smal 577298
          * Ashley Vetter 577605
          * Kelo Letsoalo 577613
          */
        static void Main(string[] args)
        {
            //An application that creates an array of five Loans. Prompt the user for the current 
            //prime interest rate.Then, in a loop, prompt the user for a loan type and all relevant information for
            //that loan. Store the created Loan objects in the array.When data entry is complete, display all the
            //loans.

            string custFirstname, custLastname, term, businessName;
            int loanNumber, termChoice, termPeriod;
            double loanAmount, primeInterestRate;
            Loan[] loans = new Loan[6];

            //A prompt for the prime interest rate
            Console.WriteLine("Enter the prime interest rate");
            primeInterestRate = double.Parse(Console.ReadLine());

            //A loop for 5 loans
            for (int i=1; i<6; i++)
            {
                Console.WriteLine($"Loan {i} of 5");
                Console.WriteLine("Type of loan: \n 1. Business Loan \n 2. Personal Loan");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) // Business Loan
                {
                    Console.WriteLine("Loan Number:");
                    loanNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Business Name:");
                    businessName = Console.ReadLine();

                    Console.WriteLine("Customer Name:");
                    custFirstname = Console.ReadLine();

                    Console.WriteLine("Customer Surname:");
                    custLastname = Console.ReadLine();

                    Console.WriteLine("Loan Amount:");
                    loanAmount = double.Parse(Console.ReadLine());

                    if (loanAmount >= 100000)
                    {
                        loanAmount = Loan.LoanAmountExceeded(loanAmount);
                    }

                    Console.WriteLine("Term:");
                    Console.WriteLine("1. Short Term");
                    Console.WriteLine("2. Medium Term");
                    Console.WriteLine("3. Long Term");

                    termChoice = int.Parse(Console.ReadLine());

                    switch (termChoice)
                    {
                        case 1:
                            termPeriod = 1;
                            term = "Short Term";
                            break;
                        case 2:
                            termPeriod = 3;
                            term = "Medium Term";
                            break;
                        case 3:
                            termPeriod = 5;
                            term = "Long Term";
                            break;
                        default:
                            termPeriod = 1;
                            term = "Short Term";
                            break;
                    }

                    loans[i] = new BusinessLoan(businessName, custFirstname, custLastname, term, termPeriod, loanNumber, loanAmount, primeInterestRate);
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

                    if (loanAmount >= 100000)
                    {
                        loanAmount = Loan.LoanAmountExceeded(loanAmount);
                    }

                    Console.WriteLine("Term:");
                    Console.WriteLine("1. Short Term");
                    Console.WriteLine("2. Medium Term");
                    Console.WriteLine("3. Long Term");

                    termChoice = int.Parse(Console.ReadLine());

                    switch (termChoice)
                    {
                        case 1:
                            termPeriod = 1;
                            term = "Short Term";
                            break;
                        case 2:
                            termPeriod = 3;
                            term = "Medium Term";
                            break;
                        case 3:
                            termPeriod = 5;
                            term = "Long Term";
                            break;
                        default:
                            termPeriod = 1;
                            term = "Short Term";
                            break;
                    }

                    loans[i] = new PersonalLoan(custFirstname, custLastname, term, termPeriod, loanNumber,  loanAmount, primeInterestRate);
                }
            }
            Console.Clear();

            Console.WriteLine("\nLoans created:");
            foreach (Loan loan in loans)
            {
                if (loan != null)
                {
                    loan.CalculateLoan();
                    Console.WriteLine("\n" + loan.ToString());
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}

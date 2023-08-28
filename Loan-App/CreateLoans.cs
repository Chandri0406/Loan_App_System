using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_App
{
    internal class CreateLoans
    {   //Chandri Breytenbach 577398
        static void Main(string[] args)
        {
            /*IMPORTANT LIST
             Loan Amount needs to be calculated
             Loan Amount limit must be set
             Form display needs fixing
             Form linking needs to be done
             Bussiness class does not need cust name or cust lastname, but needs bussiness name
             User manual needs to be created 
             Comments need to be added
             Names & Student nums need to be added
                  
            Simple Interest (SI) = Principal (P) * Rate (R) * Time (T) / 100
                                   Loan Amount   * B/P Rate * int terms / 100

            Compound Interest (CI) = Principal (P) * (1 + Rate (R) / n)^(n * Time (T)) - Principal
            
            Terms                                   
            Short-Term = 1 year
            Medium-Term = 3 years
            Long-Term = 5 years
            */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms());

            string custFirstname, custLastname, term;
            int loanNumber;
            double loanAmount, primeInterestRate;
            Loan[] loans = new Loan[5];

            //A prompt for the prime interest rate
            Console.WriteLine("Enter the prime interest rate");
            primeInterestRate = double.Parse(Console.ReadLine());

            //A loop for 5 loans
            for (int i=0; i<2; i++)
            {
                Console.WriteLine("Type of loan: \n 1. Business Loan \n 2. Personal Loan");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1) // Business Loan
                {
                    Console.WriteLine("Loan Number:");
                    loanNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("Bussiness Name:");
                    Console.WriteLine("Customer Name:");
                    custFirstname = Console.ReadLine();

                    Console.WriteLine("Customer Surname:");
                    custLastname = Console.ReadLine();

                    Console.WriteLine("Loan Amount:");
                    loanAmount = double.Parse(Console.ReadLine());

                    Console.WriteLine("Term:");
                    term = Console.ReadLine();

                    loans[i] = new BussinessLoan(custFirstname, custLastname, loanNumber, term, loanAmount, primeInterestRate);
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
                    term = Console.ReadLine();

                    loans[i] = new PersonalLoan(custFirstname, custLastname, loanNumber, term, loanAmount, primeInterestRate);
                }
            }

            Console.Clear();

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

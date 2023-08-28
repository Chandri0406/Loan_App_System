using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
             IF we do forms Personal and Business need seperate displays
             AND we can possibly add search if we really wanted to
             Bussiness class does not need cust name or cust lastname, but needs bussiness name
             User manual needs to be created 
             Comments need to be added
             Names & Student nums need to be added
             
                  
            Simple Interest (SI) = Principal (P) * Rate (R) * Time (T) / 100
                                   Loan Amount   * B/P Rate * int termPeriod / 100

            Compound Interest (CI) = Principal (P) * (1 + Rate (R) / n)^(n * Time (T)) - Principal
                                     Loan Amount

            Change Loan class aka base class. Does not need contraints
            
            Terms                                   
            Short-Term = 1 year
            Medium-Term = 3 years
            Long-Term = 5 years
            */

            string custFirstname, custLastname, term;
            int loanNumber, termChoice;
            double loanAmount, primeInterestRate, termPeriod;
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
                    Console.WriteLine("1. Short Term");
                    Console.WriteLine("2. Medium Term");
                    Console.WriteLine("3. Long Term");

                    termChoice = int.Parse(Console.ReadLine());

                    // Create event like this switch and then call event after term choice

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

                    // Calculation Method should be added here
                    
                    loans[i] = new BussinessLoan(custFirstname, custLastname, term, loanNumber, loanAmount, primeInterestRate);
                    
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
                    Console.WriteLine("1. Short Term");
                    Console.WriteLine("2. Medium Term");
                    Console.WriteLine("3. Long Term");

                    termChoice = int.Parse(Console.ReadLine());

                    switch (termChoice)
                    {
                        case 1:
                            double termPeriod = 1;
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

                    loans[i] = new PersonalLoan(custFirstname, custLastname, term, loanNumber,  loanAmount, primeInterestRate);
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

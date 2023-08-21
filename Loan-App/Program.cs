using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_App
{
    internal class Program
    {
        enum Menu
        {
            AddBL = 1,
            AddPl,
            Exit
        }

        static void Main(string[] args)
        {
            //An application that creates an array of five Loans. Prompt the user for the current 
            //prime interest rate.Then, in a loop, prompt the user for a loan type and all relevant information for
            //that loan. Store the created Loan objects in the array.When data entry is complete, display all the
            //loans.
            
            string custFirstname, custLastname;
            int loanNumber, term;
            double loanAmount;
            bool Continue = true;
            List<BussinessLoan> Bloan = new List<BussinessLoan>();
            List<PersonalLoan> Ploan = new List<PersonalLoan>();


            while (Continue)
            {
                Console.WriteLine("1. Add Business Loan");
                Console.WriteLine("2. Add Personal Loan");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch ((Menu)choice)
                {
                    case Menu.AddBL:
                        Console.WriteLine("Customer Name:");
                        custFirstname = Console.ReadLine();

                        Console.WriteLine("Customer Surname:");
                        custLastname = Console.ReadLine();

                        Console.WriteLine("");

                        break;

                    case Menu.AddPl:
                        break;

                    case Menu.Exit:
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

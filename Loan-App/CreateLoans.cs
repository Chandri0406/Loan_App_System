﻿using System;
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
        List <BussinessLoan> Bloan = new List <BussinessLoan>();
        List <PersonalLoan> Ploan = new List <PersonalLoan>();
    }
}

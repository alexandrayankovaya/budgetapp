﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    public class Transaction
    {
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public string User { get; set; }
    }
}

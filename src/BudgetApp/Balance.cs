using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    public class Balance
    {
       
        private static Balance instance = null;

        private static readonly object xxxx = new object();
        public decimal _balance { get; set; }

        public delegate void BalanceEventHandler(Balance sender);
        public delegate void RefreshHandler();

        public event BalanceEventHandler onBalanceChanged;
        public event RefreshHandler drawChart;

        public string file { get; set; }

        Balance()
        {
            Users = AddToCSV.ReadUserDataCSV();
        }

        public static Balance Instance
        {
            get
            {
                lock (xxxx)
                {
                    if (instance == null)
                    {
                        instance = new Balance();
                    }

                    return instance;
                }
            }
        }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public HashSet<string> Users { get; set; } = new HashSet<string>();

        public decimal AddTransaction(DateTime date, decimal amount, string user)
        {
            Transactions.Add(new Transaction()
            {
                Date = date,
                Amount = amount,
                User = user
            });

            _balance += amount;

            onBalanceChanged?.Invoke(this);
            // drawChart?.Invoke();

            return _balance;
        }

        public void Refresh()
        {
            this.drawChart?.Invoke();
        }
    }
}
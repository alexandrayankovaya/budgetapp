using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class DeleteTransactionForm : Form
    {
        public Balance _balance { get; set; }
        public DeleteTransactionForm()
        {
            InitializeComponent();
            this._balance = Balance.Instance;
            for (int i = 0; i < this._balance.Transactions.Count(); i++)
            {
                this.DeleteTransactionDataGrid.Rows.Add(i, this._balance.Transactions[i].Date, this._balance.Transactions[i].User, this._balance.Transactions[i].Amount);
            }
        }

        private void DeleteProductionBT_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in DeleteTransactionDataGrid.SelectedRows)
            {
                this.DeleteTransactionDataGrid.Rows.RemoveAt((int)item.Cells[0].Value);
                this._balance.Transactions.RemoveAt((int)item.Cells[0].Value);
            }

            StringBuilder builder = new StringBuilder();
            foreach (var transaction in _balance.Transactions)
            {
                builder.AppendLine($"{transaction.Date},{transaction.Amount},{transaction.User}");
            }

            AddToCSV.UpdateTransactionsFile(_balance.file, builder.ToString());
        }
    }
}

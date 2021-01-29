using System;
using System.Linq;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class TransactionForm : Form
    {
        public Balance _balance { get; set; } 
        public TransactionForm()
        {
            InitializeComponent();
            this._balance = Balance.Instance;

            this.ChooseUserCB.Items.AddRange(this._balance.Users.ToArray());
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            DateTime date = addTransactionDP.Value; //date is value from datepicker
            decimal Amount;
            string user = ChooseUserCB.Text;

            if (!(decimal.TryParse(enterAmountTB.Text, System.Globalization.NumberStyles.Float, null, out Amount) && Amount > 0)) 
            {              
                MessageBox.Show("Enter the valid value") ;
                this.label1.Text = string.Format("Invalid value {0}", enterAmountTB.Text);
                this.label1.Visible = true;
                return;
            }

            if (addExpenceRB.Checked)
            {
                Amount = Amount * (-1);
            }

            if (string.IsNullOrWhiteSpace((string)ChooseUserCB.SelectedItem))
            {
                MessageBox.Show("Choose the user");
                return;
            }
          
            var balance = _balance.AddTransaction(date, Amount, user);
            this.label1.Text = string.Format("added: {0}", Amount);
            this.label1.Visible = true;

            //_balance.Refresh();

            AddToCSV.WriteLineToFile($"{date},{Amount},{user}", _balance.file);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

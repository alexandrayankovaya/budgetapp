using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class MainPage : Form
    {
        public Balance _balance { get; set; }

        public MainPage()
        {
            InitializeComponent();
            this._balance = Balance.Instance;

            this._balance.onBalanceChanged += ChangeBalance;
            this._balance.drawChart += Plot;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionForm();
            transactionForm.Show();
        }

        private void ChangeBalance(Balance sender)
        {
            this.BalanceView.Text = $"{sender._balance} $";
        }

        private void BalanceView_Click(object sender, EventArgs e) { }

        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var NewUserForm = new NewUser();
            NewUserForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _balance.file = openFileDialog.FileName;
                    _balance.Transactions = new System.Collections.Generic.List<Transaction>();
                    _balance._balance = 0;
                    var fileStream = openFileDialog.OpenFile();
                    string line;
                    using (var reader = new StreamReader(fileStream))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            var res = line.Split(',');
                            var date = DateTime.Parse(res[0]);
                            var amount = decimal.Parse(res[1]);

                            _balance.AddTransaction(date, amount, res[2]);
                        }
                    }
                }
            }

            this.Plot();
        }

        private void Plot()
        {
            if (_balance != null)
            {
                this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
                this.chart1.Series.Clear();
                var expences = this.chart1.Series.Add("Expences");
                var income = this.chart1.Series.Add("Income");
                Func<Transaction, bool> dateSpan = x =>
                {
                    return dateTimePicker1.Value < x.Date && dateTimePicker2.Value > x.Date;
                };

                if (this.checkBox1.Checked)
                {
                    expences.Points.AddXY("Expence", _balance.Transactions.Where(x => x.Amount < 0 && dateSpan(x)).Sum(x => x.Amount));
                    income.Points.AddXY("Income", _balance.Transactions.Where(x => x.Amount > 0 && dateSpan(x)).Sum(x => x.Amount));
                }
                else
                {
                    var transactionByUser = _balance.Transactions.GroupBy(x => x.User);
                    foreach (var item in transactionByUser)
                    {
                        var exp = item.Where(x => x.Amount < 0 && dateSpan(x)).Sum(x => x.Amount);
                        var inc = item.Where(x => x.Amount > 0 && dateSpan(x)).Sum(x => x.Amount);
                        expences.Points.AddXY(item.Key, exp);
                        income.Points.AddXY(item.Key, inc);
                    }
                }
            }
        }

        private void CreateChartBT_Click(object sender, EventArgs e)
        {
            this.Plot();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.Plot();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.Plot();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            this.Plot();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AboutForm = new AboutForm();
            AboutForm.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DeleteUser = new DeleteUserForm();
            DeleteUser.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var DeleteTransaction = new DeleteTransactionForm();
            DeleteTransaction.Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder bld = new StringBuilder();
                    foreach (var item in this._balance.Transactions)
                    {
                        bld.AppendLine($"{item.Date},{item.Amount},{item.User}");
                    }

                      File.WriteAllText(saveFileDialog.FileName, bld.ToString());
                }
            }
        }
    }
}

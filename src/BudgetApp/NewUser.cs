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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();       
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            string user = EnterNameTB.Text.Trim().ToLower();

            if (user.Length == 0 || user.Length > 16)
            {
                UnvalidValueLB.Visible = true;
                UnvalidValueLB.ForeColor = Color.Red;
            }
            else
            {
                if (Balance.Instance.Users.Contains(user))
                {
                    UnvalidValueLB.Visible = true;
                    UnvalidValueLB.ForeColor = Color.Red;
                    UnvalidValueLB.Text = "User already exists"; 
                }
                else
                {
                    Balance.Instance.Users.Add(user);
                    this.Close();
                }
            }
            
            AddToCSV.CreateUserDataCSV(user);
        }

    }
}

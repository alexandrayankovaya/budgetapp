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
    public partial class DeleteUserForm : Form
    {
        public Balance _balance { get; set; }
        public DeleteUserForm()
        {
            InitializeComponent();
            this._balance = Balance.Instance;
            this.DeleteUserListBox.Items.AddRange(this._balance.Users.ToArray());
        }

        private void DeleteUserBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace((string)DeleteUserListBox.SelectedItem))
            {
                DeleteUserErrorLB.Visible = true;
                DeleteUserErrorLB.ForeColor = Color.Red;
            }
            else
            {
                DialogResult = MessageBox.Show("Are you sure?", "Delete user", MessageBoxButtons.OKCancel);
                if (DialogResult == DialogResult.OK && this._balance.Users.Contains(DeleteUserListBox.SelectedItem))
                {
                        this._balance.Users.Remove(DeleteUserListBox.SelectedItem.ToString());
                        
                        HashSet<string> Users = this._balance.Users;
                        StringBuilder builder = new StringBuilder();
                        foreach (var user in Users)
                        {
                            builder.AppendLine(user);
                        }
                        AddToCSV.UpdateUsersFile(builder.ToString());
                        DeleteUserSuccessLB.Visible = true;
                        DeleteUserSuccessLB.ForeColor = Color.Green;
                        this.DeleteUserListBox.Items.Remove(DeleteUserListBox.SelectedItem);
                }
            }
        }
    }
}

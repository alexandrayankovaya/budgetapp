namespace BudgetApp
{
    partial class DeleteUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteUserListBox = new System.Windows.Forms.ListBox();
            this.DeleteUserLB = new System.Windows.Forms.Label();
            this.DeleteUserBT = new System.Windows.Forms.Button();
            this.DeleteUserErrorLB = new System.Windows.Forms.Label();
            this.DeleteUserSuccessLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteUserListBox
            // 
            this.DeleteUserListBox.FormattingEnabled = true;
            this.DeleteUserListBox.Location = new System.Drawing.Point(29, 76);
            this.DeleteUserListBox.Name = "DeleteUserListBox";
            this.DeleteUserListBox.Size = new System.Drawing.Size(149, 95);
            this.DeleteUserListBox.TabIndex = 0;
            // 
            // DeleteUserLB
            // 
            this.DeleteUserLB.AutoSize = true;
            this.DeleteUserLB.Location = new System.Drawing.Point(26, 27);
            this.DeleteUserLB.Name = "DeleteUserLB";
            this.DeleteUserLB.Size = new System.Drawing.Size(117, 13);
            this.DeleteUserLB.TabIndex = 1;
            this.DeleteUserLB.Text = "Choose User to Delete:";
            // 
            // DeleteUserBT
            // 
            this.DeleteUserBT.Location = new System.Drawing.Point(163, 204);
            this.DeleteUserBT.Name = "DeleteUserBT";
            this.DeleteUserBT.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserBT.TabIndex = 2;
            this.DeleteUserBT.Text = "Delete";
            this.DeleteUserBT.UseVisualStyleBackColor = true;
            this.DeleteUserBT.Click += new System.EventHandler(this.DeleteUserBT_Click);
            // 
            // DeleteUserErrorLB
            // 
            this.DeleteUserErrorLB.AutoSize = true;
            this.DeleteUserErrorLB.Location = new System.Drawing.Point(29, 178);
            this.DeleteUserErrorLB.Name = "DeleteUserErrorLB";
            this.DeleteUserErrorLB.Size = new System.Drawing.Size(84, 13);
            this.DeleteUserErrorLB.TabIndex = 3;
            this.DeleteUserErrorLB.Text = "Choose the user";
            this.DeleteUserErrorLB.Visible = false;
            // 
            // DeleteUserSuccessLB
            // 
            this.DeleteUserSuccessLB.AutoSize = true;
            this.DeleteUserSuccessLB.Location = new System.Drawing.Point(29, 178);
            this.DeleteUserSuccessLB.Name = "DeleteUserSuccessLB";
            this.DeleteUserSuccessLB.Size = new System.Drawing.Size(67, 13);
            this.DeleteUserSuccessLB.TabIndex = 4;
            this.DeleteUserSuccessLB.Text = "User deleted";
            this.DeleteUserSuccessLB.Visible = false;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteUserSuccessLB);
            this.Controls.Add(this.DeleteUserErrorLB);
            this.Controls.Add(this.DeleteUserBT);
            this.Controls.Add(this.DeleteUserLB);
            this.Controls.Add(this.DeleteUserListBox);
            this.Name = "DeleteUserForm";
            this.Text = "Delete user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DeleteUserListBox;
        private System.Windows.Forms.Label DeleteUserLB;
        private System.Windows.Forms.Button DeleteUserBT;
        private System.Windows.Forms.Label DeleteUserErrorLB;
        private System.Windows.Forms.Label DeleteUserSuccessLB;
    }
}
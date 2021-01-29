namespace BudgetApp
{
    partial class NewUser
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
            this.AddUserButton = new System.Windows.Forms.Button();
            this.EnterNameLB = new System.Windows.Forms.Label();
            this.EnterNameTB = new System.Windows.Forms.TextBox();
            this.UnvalidValueLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(104, 90);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(64, 23);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // EnterNameLB
            // 
            this.EnterNameLB.AutoSize = true;
            this.EnterNameLB.Location = new System.Drawing.Point(61, 20);
            this.EnterNameLB.Name = "EnterNameLB";
            this.EnterNameLB.Size = new System.Drawing.Size(158, 13);
            this.EnterNameLB.TabIndex = 1;
            this.EnterNameLB.Text = "Enter the name of the new user:";
            // 
            // EnterNameTB
            // 
            this.EnterNameTB.Location = new System.Drawing.Point(88, 47);
            this.EnterNameTB.Name = "EnterNameTB";
            this.EnterNameTB.Size = new System.Drawing.Size(100, 20);
            this.EnterNameTB.TabIndex = 2;
            // 
            // UnvalidValueLB
            // 
            this.UnvalidValueLB.AutoSize = true;
            this.UnvalidValueLB.Location = new System.Drawing.Point(36, 70);
            this.UnvalidValueLB.Name = "UnvalidValueLB";
            this.UnvalidValueLB.Size = new System.Drawing.Size(205, 13);
            this.UnvalidValueLB.TabIndex = 3;
            this.UnvalidValueLB.Text = "Enter the valid value (up to 16 characters)";
            this.UnvalidValueLB.Visible = false;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 125);
            this.Controls.Add(this.UnvalidValueLB);
            this.Controls.Add(this.EnterNameTB);
            this.Controls.Add(this.EnterNameLB);
            this.Controls.Add(this.AddUserButton);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label EnterNameLB;
        private System.Windows.Forms.TextBox EnterNameTB;
        private System.Windows.Forms.Label UnvalidValueLB;
    }
}
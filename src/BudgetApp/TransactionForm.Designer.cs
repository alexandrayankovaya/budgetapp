namespace BudgetApp
{
    partial class TransactionForm
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
            this.addTransactionDP = new System.Windows.Forms.DateTimePicker();
            this.chooseDateLB = new System.Windows.Forms.Label();
            this.enterAmountLabel = new System.Windows.Forms.Label();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.enterAmountTB = new System.Windows.Forms.TextBox();
            this.addExpenceRB = new System.Windows.Forms.RadioButton();
            this.addIncomeRB = new System.Windows.Forms.RadioButton();
            this.ChooseUserCB = new System.Windows.Forms.ComboBox();
            this.ChooseUserLB = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTransactionDP
            // 
            this.addTransactionDP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addTransactionDP.Location = new System.Drawing.Point(150, 38);
            this.addTransactionDP.Name = "addTransactionDP";
            this.addTransactionDP.Size = new System.Drawing.Size(104, 20);
            this.addTransactionDP.TabIndex = 1;
            // 
            // chooseDateLB
            // 
            this.chooseDateLB.AutoSize = true;
            this.chooseDateLB.Location = new System.Drawing.Point(62, 45);
            this.chooseDateLB.Name = "chooseDateLB";
            this.chooseDateLB.Size = new System.Drawing.Size(70, 13);
            this.chooseDateLB.TabIndex = 2;
            this.chooseDateLB.Text = "Choose date:";
            // 
            // enterAmountLabel
            // 
            this.enterAmountLabel.AutoSize = true;
            this.enterAmountLabel.Location = new System.Drawing.Point(59, 71);
            this.enterAmountLabel.Name = "enterAmountLabel";
            this.enterAmountLabel.Size = new System.Drawing.Size(73, 13);
            this.enterAmountLabel.TabIndex = 3;
            this.enterAmountLabel.Text = "Enter amount:";
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Location = new System.Drawing.Point(202, 138);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(104, 23);
            this.addTransactionButton.TabIndex = 4;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // enterAmountTB
            // 
            this.enterAmountTB.Location = new System.Drawing.Point(150, 64);
            this.enterAmountTB.Name = "enterAmountTB";
            this.enterAmountTB.Size = new System.Drawing.Size(104, 20);
            this.enterAmountTB.TabIndex = 5;
            // 
            // addExpenceRB
            // 
            this.addExpenceRB.AutoSize = true;
            this.addExpenceRB.Checked = true;
            this.addExpenceRB.Location = new System.Drawing.Point(62, 12);
            this.addExpenceRB.Name = "addExpenceRB";
            this.addExpenceRB.Size = new System.Drawing.Size(67, 17);
            this.addExpenceRB.TabIndex = 6;
            this.addExpenceRB.TabStop = true;
            this.addExpenceRB.Text = "Expence";
            this.addExpenceRB.UseVisualStyleBackColor = true;
            // 
            // addIncomeRB
            // 
            this.addIncomeRB.AutoSize = true;
            this.addIncomeRB.Location = new System.Drawing.Point(150, 12);
            this.addIncomeRB.Name = "addIncomeRB";
            this.addIncomeRB.Size = new System.Drawing.Size(60, 17);
            this.addIncomeRB.TabIndex = 7;
            this.addIncomeRB.Text = "Income";
            this.addIncomeRB.UseVisualStyleBackColor = true;
            // 
            // ChooseUserCB
            // 
            this.ChooseUserCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseUserCB.FormattingEnabled = true;
            this.ChooseUserCB.Location = new System.Drawing.Point(150, 90);
            this.ChooseUserCB.Name = "ChooseUserCB";
            this.ChooseUserCB.Size = new System.Drawing.Size(104, 21);
            this.ChooseUserCB.TabIndex = 8;
            // 
            // ChooseUserLB
            // 
            this.ChooseUserLB.AutoSize = true;
            this.ChooseUserLB.Location = new System.Drawing.Point(59, 98);
            this.ChooseUserLB.Name = "ChooseUserLB";
            this.ChooseUserLB.Size = new System.Drawing.Size(71, 13);
            this.ChooseUserLB.TabIndex = 9;
            this.ChooseUserLB.Text = "Choose User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Added";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChooseUserLB);
            this.Controls.Add(this.ChooseUserCB);
            this.Controls.Add(this.addIncomeRB);
            this.Controls.Add(this.addExpenceRB);
            this.Controls.Add(this.enterAmountTB);
            this.Controls.Add(this.addTransactionButton);
            this.Controls.Add(this.enterAmountLabel);
            this.Controls.Add(this.chooseDateLB);
            this.Controls.Add(this.addTransactionDP);
            this.Name = "TransactionForm";
            this.Text = "New Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker addTransactionDP;
        private System.Windows.Forms.Label chooseDateLB;
        private System.Windows.Forms.Label enterAmountLabel;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.TextBox enterAmountTB;
        private System.Windows.Forms.RadioButton addExpenceRB;
        private System.Windows.Forms.RadioButton addIncomeRB;
        private System.Windows.Forms.ComboBox ChooseUserCB;
        private System.Windows.Forms.Label ChooseUserLB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
    }
}


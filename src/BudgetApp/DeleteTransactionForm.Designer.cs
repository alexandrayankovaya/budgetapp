namespace BudgetApp
{
    partial class DeleteTransactionForm
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
            this.DeleteTransactionLB = new System.Windows.Forms.Label();
            this.DeleteTransactionDataGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProductionBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTransactionDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteTransactionLB
            // 
            this.DeleteTransactionLB.AutoSize = true;
            this.DeleteTransactionLB.Location = new System.Drawing.Point(51, 23);
            this.DeleteTransactionLB.Name = "DeleteTransactionLB";
            this.DeleteTransactionLB.Size = new System.Drawing.Size(145, 13);
            this.DeleteTransactionLB.TabIndex = 1;
            this.DeleteTransactionLB.Text = "Choose transaction to delete:";
            // 
            // DeleteTransactionDataGrid
            // 
            this.DeleteTransactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeleteTransactionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Date,
            this.User,
            this.Amount});
            this.DeleteTransactionDataGrid.Location = new System.Drawing.Point(12, 50);
            this.DeleteTransactionDataGrid.Name = "DeleteTransactionDataGrid";
            this.DeleteTransactionDataGrid.ReadOnly = true;
            this.DeleteTransactionDataGrid.Size = new System.Drawing.Size(370, 150);
            this.DeleteTransactionDataGrid.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DeleteProductionBT
            // 
            this.DeleteProductionBT.Location = new System.Drawing.Point(275, 215);
            this.DeleteProductionBT.Name = "DeleteProductionBT";
            this.DeleteProductionBT.Size = new System.Drawing.Size(107, 23);
            this.DeleteProductionBT.TabIndex = 3;
            this.DeleteProductionBT.Text = "DeleteTransaction";
            this.DeleteProductionBT.UseVisualStyleBackColor = true;
            this.DeleteProductionBT.Click += new System.EventHandler(this.DeleteProductionBT_Click);
            // 
            // DeleteTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 261);
            this.Controls.Add(this.DeleteProductionBT);
            this.Controls.Add(this.DeleteTransactionDataGrid);
            this.Controls.Add(this.DeleteTransactionLB);
            this.Name = "DeleteTransactionForm";
            this.Text = "DeleteTransactionForm";
            ((System.ComponentModel.ISupportInitialize)(this.DeleteTransactionDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DeleteTransactionLB;
        private System.Windows.Forms.DataGridView DeleteTransactionDataGrid;
        private System.Windows.Forms.Button DeleteProductionBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}
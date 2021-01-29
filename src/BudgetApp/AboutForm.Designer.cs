namespace BudgetApp
{
    partial class AboutForm
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
            this.AboutLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutLB
            // 
            this.AboutLB.AutoSize = true;
            this.AboutLB.Location = new System.Drawing.Point(27, 19);
            this.AboutLB.MaximumSize = new System.Drawing.Size(150, 0);
            this.AboutLB.Name = "AboutLB";
            this.AboutLB.Size = new System.Drawing.Size(127, 52);
            this.AboutLB.TabIndex = 0;
            this.AboutLB.Text = "Курсовая работа. Выполнила - студентка группы КИУКИз-16-3 Янковая Александра";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 119);
            this.Controls.Add(this.AboutLB);
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutLB;
    }
}
namespace ExpenseTracker
{
    partial class Home
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
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.viewreportButton = new System.Windows.Forms.Button();
            this.expenseTrackerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.addExpenseButton.Location = new System.Drawing.Point(130, 142);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(172, 85);
            this.addExpenseButton.TabIndex = 1;
            this.addExpenseButton.Text = "Add Expense";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // viewreportButton
            // 
            this.viewreportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewreportButton.Location = new System.Drawing.Point(130, 242);
            this.viewreportButton.Name = "viewreportButton";
            this.viewreportButton.Size = new System.Drawing.Size(172, 85);
            this.viewreportButton.TabIndex = 2;
            this.viewreportButton.Text = "View Report";
            this.viewreportButton.UseVisualStyleBackColor = true;
            this.viewreportButton.Click += new System.EventHandler(this.viewreportButton_Click);
            // 
            // expenseTrackerLabel
            // 
            this.expenseTrackerLabel.AutoSize = true;
            this.expenseTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseTrackerLabel.Location = new System.Drawing.Point(15, 19);
            this.expenseTrackerLabel.Name = "expenseTrackerLabel";
            this.expenseTrackerLabel.Size = new System.Drawing.Size(403, 110);
            this.expenseTrackerLabel.TabIndex = 0;
            this.expenseTrackerLabel.Text = "Welcome to \r\nExpense Tracker";
            this.expenseTrackerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.expenseTrackerLabel.UseWaitCursor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 365);
            this.Controls.Add(this.expenseTrackerLabel);
            this.Controls.Add(this.viewreportButton);
            this.Controls.Add(this.addExpenseButton);
            this.Name = "Home";
            this.Text = "Expense Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.Button viewreportButton;
        private System.Windows.Forms.Label expenseTrackerLabel;
    }
}


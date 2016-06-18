namespace ExpenseTracker
{
    partial class AddExpenses
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
            this.expenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Comments = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.expenseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.addExpenseLabel = new System.Windows.Forms.Label();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.expenseAmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.expenseCommentsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseDateTimePicker
            // 
            this.expenseDateTimePicker.Location = new System.Drawing.Point(237, 112);
            this.expenseDateTimePicker.Name = "expenseDateTimePicker";
            this.expenseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expenseDateTimePicker.TabIndex = 13;
            this.expenseDateTimePicker.Value = new System.DateTime(2016, 6, 14, 19, 10, 45, 0);
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comments.Location = new System.Drawing.Point(125, 183);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(106, 24);
            this.Comments.TabIndex = 12;
            this.Comments.Text = "Comments:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(150, 145);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(81, 24);
            this.amountLabel.TabIndex = 11;
            this.amountLabel.Text = "Amount:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(77, 107);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(154, 24);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Date of Expense:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(173, 69);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(58, 24);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type:";
            // 
            // expenseTypeComboBox
            // 
            this.expenseTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseTypeComboBox.FormattingEnabled = true;
            this.expenseTypeComboBox.Items.AddRange(new object[] {
            "Office Supplies",
            "Office Rent",
            "Utilities",
            "Other"});
            this.expenseTypeComboBox.Location = new System.Drawing.Point(237, 69);
            this.expenseTypeComboBox.Name = "expenseTypeComboBox";
            this.expenseTypeComboBox.Size = new System.Drawing.Size(200, 33);
            this.expenseTypeComboBox.TabIndex = 8;
            // 
            // addExpenseLabel
            // 
            this.addExpenseLabel.AutoSize = true;
            this.addExpenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseLabel.Location = new System.Drawing.Point(65, 16);
            this.addExpenseLabel.Name = "addExpenseLabel";
            this.addExpenseLabel.Size = new System.Drawing.Size(384, 39);
            this.addExpenseLabel.TabIndex = 7;
            this.addExpenseLabel.Text = "Please Add an Expense";
            // 
            // viewReportButton
            // 
            this.viewReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportButton.Location = new System.Drawing.Point(37, 234);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(147, 72);
            this.viewReportButton.TabIndex = 14;
            this.viewReportButton.Text = "View Report";
            this.viewReportButton.UseVisualStyleBackColor = true;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(331, 234);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(147, 72);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpenseButton.Location = new System.Drawing.Point(184, 234);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(147, 72);
            this.addExpenseButton.TabIndex = 16;
            this.addExpenseButton.Text = "Add Expense";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click);
            // 
            // expenseAmountNumericUpDown
            // 
            this.expenseAmountNumericUpDown.DecimalPlaces = 2;
            this.expenseAmountNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseAmountNumericUpDown.Location = new System.Drawing.Point(237, 142);
            this.expenseAmountNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.expenseAmountNumericUpDown.Name = "expenseAmountNumericUpDown";
            this.expenseAmountNumericUpDown.Size = new System.Drawing.Size(200, 31);
            this.expenseAmountNumericUpDown.TabIndex = 19;
            this.expenseAmountNumericUpDown.ThousandsSeparator = true;
            // 
            // expenseCommentsTextBox
            // 
            this.expenseCommentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseCommentsTextBox.Location = new System.Drawing.Point(237, 183);
            this.expenseCommentsTextBox.Name = "expenseCommentsTextBox";
            this.expenseCommentsTextBox.Size = new System.Drawing.Size(200, 31);
            this.expenseCommentsTextBox.TabIndex = 20;
            this.expenseCommentsTextBox.Text = " ";
            // 
            // AddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 349);
            this.Controls.Add(this.expenseCommentsTextBox);
            this.Controls.Add(this.expenseAmountNumericUpDown);
            this.Controls.Add(this.addExpenseButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewReportButton);
            this.Controls.Add(this.expenseDateTimePicker);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.expenseTypeComboBox);
            this.Controls.Add(this.addExpenseLabel);
            this.Name = "AddExpenses";
            this.Text = "Add Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.expenseAmountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Comments;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox expenseTypeComboBox;
        private System.Windows.Forms.Label addExpenseLabel;
        private System.Windows.Forms.Button viewReportButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.DateTimePicker expenseDateTimePicker;
        private System.Windows.Forms.NumericUpDown expenseAmountNumericUpDown;
        private System.Windows.Forms.TextBox expenseCommentsTextBox;
    }
}
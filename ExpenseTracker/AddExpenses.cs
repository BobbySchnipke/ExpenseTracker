using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ExpenseTracker
{
    public partial class AddExpenses : Form
    {
        public AddExpenses()
        {
            InitializeComponent();
        }

        private void viewReportButton_Click(object sender, EventArgs e)
        {
            // This button will take the user back to the reports form

            Report Report = new Report();
            //hide the current Home form
            this.Hide();

            //display the Report Form
            Report.ShowDialog();

            //close the Home form when Report form is exited so the entire program is terminated
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form and terminate the program
            this.Close();
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            // Call the addExpensesInputValidation method
            addExpenseInputValidation();
        }

        private void expenseCommentsTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // if the user presses enter after typing in comments call the addExpenseInputValidation event
            if (e.KeyCode == Keys.Enter)
            {
                addExpenseInputValidation();
            }
        }

        private void addExpenseInputValidation()
        {
            // First check that appropriate values are entered by the user for each input

            //expenseTypeComboBox check
            if (expenseTypeComboBox.Text == "")
            {
                MessageBox.Show("Please enter a value for Expense Type", "No expense type chosen");
            }

            // expenseDateTimePicker Check
            else if (expenseDateTimePicker.Value == null)
            {
                MessageBox.Show("Please choose a date", "No date chosen");
            }

            // expenseAmountNumericUpDown check
            else if (expenseAmountNumericUpDown.Value == 0)
            {
                // Ask the user if they intend to add a record with an amount of $0.00
                DialogResult amountDialogResult = MessageBox.Show("The amount of this record is $0, are you sure you want to" +
                    " add a record with the amount of $0?", "Expense Amount set to 0", MessageBoxButtons.YesNo);
                if (amountDialogResult == DialogResult.Yes)
                {
                    // if the user chooses to add the record with an amount of $0 check
                    // if comments box is empty
                    if (expenseCommentsTextBox.Text == " ")
                    {
                        // Ask the user if they intend to add a record with no comment
                        DialogResult commentDialogResult = MessageBox.Show("There is no comment in this record. Are you sure you want to" +
                            " add a record with no comment?", "No Comment", MessageBoxButtons.YesNo);
                        if (commentDialogResult == DialogResult.Yes)
                        {
                            // if the user wishes to add the record with no comment add the record
                            addDataToTable();
                        }

                        else if (commentDialogResult == DialogResult.No)
                        {
                        }
                    }
                    else
                    {
                        // if there is a comment add the record
                        addDataToTable();
                    }
                }
                else if (amountDialogResult == DialogResult.No)
                {
                    
                }
            }

            // expenseCommentsTextBox check
            else if (expenseCommentsTextBox.Text == " ")
            {
                // Ask the user if they intend to add a record with no comment
                DialogResult commentDialogResult = MessageBox.Show("There is no comment in this record. Are you sure you want to" +
                    " add a record with no comment?", "No Comment", MessageBoxButtons.YesNo);
                if (commentDialogResult == DialogResult.Yes)
                {
                    // if the user wishes to add the record with no comment add the record
                    addDataToTable();
                }

                else if (commentDialogResult == DialogResult.No)
                {

                }
            }

            // All pass
            else
            {
                // If all of the data checks out add the data to the database
                addDataToTable();
            }

        }

        private void addDataToTable()
        {
            // All code to add a record to the database will be here
            // Open a new connection
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Expense_Tracker\ExpenseTracker\ExpenseTracker\Expenses.mdf;Integrated Security=True");
            connection.Open();

            // Create the insert command
            SqlCommand sqlCom = new SqlCommand(("INSERT INTO [Expense] ([ExpenseType], [ExpenseDate], [ExpenseAmount], [ExpenseComments])" +
                "VALUES (@ExpenseType, @ExpenseDate, @ExpenseAmount, @ExpenseComments)"), connection);

            // Pull values from user input and add them to the database
            sqlCom.Parameters.Add("ExpenseType", SqlDbType.VarChar);
            sqlCom.Parameters["ExpenseType"].Value = expenseTypeComboBox.Text;

            sqlCom.Parameters.Add("ExpenseDate", SqlDbType.Date);
            sqlCom.Parameters["ExpenseDate"].Value = expenseDateTimePicker.Value.Date;

            sqlCom.Parameters.Add("ExpenseAmount", SqlDbType.Money);
            sqlCom.Parameters["ExpenseAmount"].Value = expenseAmountNumericUpDown.Value;

            sqlCom.Parameters.Add("ExpenseComments", SqlDbType.VarChar);
            sqlCom.Parameters["ExpenseComments"].Value = expenseCommentsTextBox.Text;
            sqlCom.ExecuteNonQuery();
            // Close the connection to the database
            connection.Close();
        }
     }
}


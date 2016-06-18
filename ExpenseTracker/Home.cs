using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addExpenseButton_Click(object sender, EventArgs e)
        {
            AddExpenses AddExpenses = new AddExpenses();
            //hide the current Home form
            this.Hide();

            //display the AddExpenses Form
            AddExpenses.ShowDialog();

            //close the Home form when AddExpenses form is exited so the entire program is terminated
            this.Close();
        }

        private void viewreportButton_Click(object sender, EventArgs e)
        {
            Report Report = new Report();
            //hide the current Home form
            this.Hide();

            //display the Report Form
            Report.ShowDialog();

            //close the Home form when Report form is exited so the entire program is terminated
            this.Close();
        }
    }
}

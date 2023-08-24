using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_App
{
    public partial class Forms : Form
    {
        public Forms()
        {
            InitializeComponent();
        }

        DataTable loanTable = new DataTable();

        private void Form_Load(object sender, EventArgs e)
        {
            loanTable.Columns.Add("Loan Type", typeof(string));
            loanTable.Columns.Add("Loan Number", typeof(int));
            loanTable.Columns.Add("First Name", typeof(string));
            loanTable.Columns.Add("Last Name", typeof(string));
            loanTable.Columns.Add("Loan Amount", typeof(double));
            loanTable.Columns.Add("Interest Rate (%)", typeof(double));
            loanTable.Columns.Add("Term", typeof(string));

            loanTable.Rows.Add("Business", 123,"John","Doe",5000,12,"Long-Term");

            dataGridView1.DataSource = loanTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void personalLoan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loanType_Click(object sender, EventArgs e)
        {

        }
    }
}

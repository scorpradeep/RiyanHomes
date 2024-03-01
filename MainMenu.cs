using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiyanHomes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deals deals = new Deals();
            deals.Show();
            //if (deals.ShowDialog() == DialogResult.OK)
            //{
            //     deals.Enabled = false;
            //}

        }

        private void BankTransactions_Click(object sender, EventArgs e)
        {
            Transactions tran = new Transactions();
            tran.Show();
            //if (tran.ShowDialog() == DialogResult.OK)
            //{
            //    tran.Enabled = false;
            //}
        }

        private void Rerun_Click(object sender, EventArgs e)
        {
            Rerun rerun = new Rerun();
            rerun.Show();
            //if (rerun.ShowDialog() == DialogResult.OK)
            //{

            //    rerun.Enabled = false;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransactionsByTenent tran = new TransactionsByTenent();
            tran.Show();
            //if (tran.ShowDialog() == DialogResult.OK)
            //{
            //    tran.Enabled = false;
            //}
        }

        private void ProcessTran_Click(object sender, EventArgs e)
        {
            ProcessTransactions tran = new ProcessTransactions();
            tran.Show();
            //if (tran.ShowDialog() == DialogResult.OK)
            //{
            //    tran.Enabled = false;
            //}
        }

        private void DashBoard_Click(object sender, EventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            //if (db.ShowDialog() == DialogResult.OK)
            //{
            //    db.Enabled = false;
            //}

        }

        private void Properties_Click(object sender, EventArgs e)
        {
            Propertie prop = new Propertie();
            prop.Show();
            //if (prop.ShowDialog() == DialogResult.OK)
            //{
            //    prop.Enabled = false;
            //}
        }

        private void Status_Click(object sender, EventArgs e)
        {
            Status state = new Status();
            if (state.ShowDialog() == DialogResult.OK)
            {
                state.Enabled = false;
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            History hist = new History();
            hist.Show();
        }

        private void Expense_Click(object sender, EventArgs e)
        {
            ProcessExpense exp = new ProcessExpense();
            exp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchTransactions tran = new SearchTransactions();
            tran.Show();
        }

        private void FirmIncome_Click(object sender, EventArgs e)
        {
            FirmIncome db = new FirmIncome();
            db.Show();
        }

        private void Terminated_Click(object sender, EventArgs e)
        {
            Terminated term = new Terminated();
            term.Show();
        }
    }
}

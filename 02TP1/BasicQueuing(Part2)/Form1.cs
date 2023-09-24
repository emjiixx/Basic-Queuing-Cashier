using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Queuing_Cashier
{
    public partial class Form1 : Form
    {
        private CashierClass cashier;

        public Form1()
        {
            InitializeComponent();
            cashier = new CashierClass();

            CashierWindowQueueForm q = new CashierWindowQueueForm();
            q.Show();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}

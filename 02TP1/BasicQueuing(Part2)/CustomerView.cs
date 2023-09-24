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
    public partial class CustomerView : Form
    {
        public CustomerView(string servedNumber)
        {
            InitializeComponent();
            lblServing.Text = servedNumber;
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }
    }
}

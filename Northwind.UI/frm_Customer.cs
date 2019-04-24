using Northwind.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.UI
{
    public partial class frm_Customer : Form
    {
        public frm_Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CustomerBLL.GetCustomerList();
        }

        private void siparişListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Order frm = new frm_Order();
            frm.CustomerId = dataGridView1.SelectedRows[0].Cells["CustomerID"].Value.ToString();
            frm.Show();
        }

        private void yeniCustomerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddCustomer frm = new frm_AddCustomer();
            frm.ShowDialog();
        }
    }
}

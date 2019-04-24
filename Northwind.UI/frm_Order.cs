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
    public partial class frm_Order : Form
    {
        public frm_Order()
        {
            InitializeComponent();
        }

        public string CustomerId;

        private void frm_Order_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = OrderBLL.GetOrders(CustomerId);
        }
    }
}

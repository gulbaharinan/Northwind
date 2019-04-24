using Northwind.BLL;
using Northwind.ENTITY;
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
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }

        private void btn_CustomerAdd_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.CustomerID = txt_CustomerID.Text;
            customer.CompanyName = txt_Company.Text;
            customer.ContactName = txt_ContactName.Text;
            customer.ContactTitle = txt_ContactTitle.Text;
            customer.City = txt_Bolge.Text;
            customer.Country = txt_Country.Text;
            customer.Address = txt_Adres.Text;
            CustomerBLL.AddCustomers(customer);
        }
    }
}

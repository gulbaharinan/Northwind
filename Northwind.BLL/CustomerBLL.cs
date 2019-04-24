using Northwind.DAL;
using Northwind.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
  public  class CustomerBLL
    {
       static NorthwindDbContext dbcontext = new NorthwindDbContext();
        public static List<Customer> GetCustomerList()
        {
            
            return dbcontext.Customers.ToList();

        }

        public static void AddCustomers(Customer customer)
        {

            Customer cust = new Customer();
            cust.CustomerID = customer.CustomerID;
            cust.CompanyName = customer.CompanyName;
            cust.ContactName = customer.ContactName;
            cust.ContactTitle = customer.ContactTitle;
            cust.Address = customer.Address;
            cust.City = customer.City;
            cust.Country = customer.Country;

            dbcontext.Customers.Add(cust);
            dbcontext.SaveChanges();

        }
    }
}

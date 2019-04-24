using Northwind.DAL;
using Northwind.ENTITY;
using System.Collections.Generic;
using System.Linq;

namespace Northwind.BLL
{
    public class OrderBLL
    {
        public static List<Order> GetOrders(string customerId)
        {
            NorthwindDbContext DataContext = new NorthwindDbContext();
            return DataContext.Orders.Where(x => x.CustomerID == customerId).ToList();
           
        }
    
    }
}

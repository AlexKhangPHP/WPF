using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Order
    {
        public string OrderNo { get; } 
        public string OrderDate { get; }
        public string ClientName { get; }
        public string Address { get; }
        public double Amount { get; }
         
        public Order(string orderNo, string orderDate, string clientName, string address, double amount)
        {
            OrderNo = orderNo;
            OrderDate = orderDate;
            ClientName = clientName;
            Address = address;
            Amount = amount;
        }
    }
}

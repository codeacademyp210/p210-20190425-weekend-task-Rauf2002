using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    class Order
    {
        Client c1 = new Client();
        Product p1 = new Product();
        public int Count { get; set; }
        public int TotalPrice (int quantity , int price)
        {
            quantity = Count;
            price = p1.Price;
            return quantity * price;
        }
    }
}

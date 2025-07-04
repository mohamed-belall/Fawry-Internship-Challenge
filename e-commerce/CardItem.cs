using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class CardItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CardItem(Product product , int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
            
        }

        public double getTotalPrice()
        {
            return Product.Price * Quantity;
        }
    }
}

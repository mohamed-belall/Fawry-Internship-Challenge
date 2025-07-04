using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name , double price , int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }


        public void ReduceQuantity(int numOfProduct)
        {
            if (numOfProduct <= this.Quantity)
                this.Quantity -= numOfProduct;
        }

        public bool IsAvailable(int requestedQuantity)
        {
            return requestedQuantity <= this.Quantity;

        }

        public abstract bool IsExpired();
        public abstract bool RequiredShipping();
    }
}

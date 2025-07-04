using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class Cart
    {
        public List<CardItem> Items { get; set; } = new List<CardItem>();

        public void Add(Product product , int quantity)
        {
            Items.Add(new CardItem(product, quantity));
        }

        public bool IsEmpty()
        {
            return Items.Count() == 0;
        }

        public double SubTotal()
        {
           return Items.Sum(i => i.getTotalPrice());
        }
    }
}

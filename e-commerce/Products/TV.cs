using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Products
{
    public class TV : NonExpirableProduct, IShippable
    {
        protected double Weight;

        public TV( double price , int quantity , double weight):base("TV" ,price , quantity)
        {
            this.Weight = weight;
        }

        public string getName()
        {
            return this.Name;
        }

        public double getWeight()
        {
            return Weight;
        }

        public override bool RequiredShipping()
        {
            return true;
        }
    }
}

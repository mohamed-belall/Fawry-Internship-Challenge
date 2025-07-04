using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Products
{
    public class Biscuits : ExpirableProduct , IShippable
    {
        protected double Weight;

        public Biscuits( double price, int quantity, DateTime expirationDate, double weight)
             : base("Biscuits", price, quantity, expirationDate)
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




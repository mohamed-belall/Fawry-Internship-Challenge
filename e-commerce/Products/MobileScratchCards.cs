using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Products
{
    public class MobileScratchCards : NonExpirableProduct
    {

        public MobileScratchCards( double price , int quantity)
            : base("MobileScratchCards", price , quantity)
        {
            
        }

        public override bool RequiredShipping()
        {
            return false;
        }
    }
}

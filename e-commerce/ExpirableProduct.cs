using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public abstract class ExpirableProduct : Product
    {
        public DateTime ExpirationDate { get; set; }

        public ExpirableProduct(string name, double price, int quantity , DateTime expirationDate)
            : base(name , price , quantity)
        {
            this.ExpirationDate = expirationDate;
        }

        public override bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }
    }
}

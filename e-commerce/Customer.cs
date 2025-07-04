using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Customer(string name , double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public bool CanCheckout(double Amount)
        {
            return Amount < this.Balance;
        }

        public void deductBalance(double Amount)
        {
            this.Balance -= Amount;
        }

    }
}

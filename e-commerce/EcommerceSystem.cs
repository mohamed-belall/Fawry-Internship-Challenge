using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public class EcommerceSystem
    {
        public static void Checkout(Customer customer , Cart cart)
        {
            try
            {
                if (cart.IsEmpty())
                    throw new Exception("Cart is Empty");

                foreach (var item in cart.Items)
                {
                    if (!item.Product.IsAvailable(item.Quantity))
                        throw new Exception($"Product {item.Product.Name} is Out of Stock");

                    if (item.Product.IsExpired())
                        throw new Exception($"Product {item.Product.Name} is Expired");


                }

                var shippableItems = new List<IShippable>();

                foreach (var item in cart.Items)
                {
                    if (item.Product.RequiredShipping() && item.Product is IShippable)
                    {
                        for (int i = 0; i < item.Quantity; i++)
                        {
                            shippableItems.Add((IShippable)item.Product);
                        }
                    }
                }

                var totalAmount = cart.SubTotal() + ShippingService.Fees;

                if (!customer.CanCheckout(totalAmount))
                {
                    throw new Exception($"Insufficient balance, Requested = {totalAmount} , Available = {customer.Balance}");
                }

                if (shippableItems.Count > 0)
                    ShippingService.ProcessShipment(shippableItems);

                foreach (var item in cart.Items)
                    item.Product.ReduceQuantity(item.Quantity);

                customer.deductBalance(totalAmount);

                Console.WriteLine("** Checkout receipt **");
                foreach (var item in cart.Items)
                {
                    Console.WriteLine($"{item.Quantity}x {item.Product.Name}    {item.getTotalPrice()}");
                }

                Console.WriteLine("------------");
                Console.WriteLine($"Subtotal    {cart.SubTotal()}");
                Console.WriteLine($"Shipping    {ShippingService.Fees}");
                Console.WriteLine($"Amount    {totalAmount}");
            }
            catch (Exception e)
            {

                Console.WriteLine($"{e.Message}");
            }

           

        }
    }
}

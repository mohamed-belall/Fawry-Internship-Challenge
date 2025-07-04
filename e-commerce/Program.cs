using e_commerce.Products;

namespace e_commerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var cheese = new Cheese( 100, 10, DateTime.Now.AddDays(7), 0.4);
            var biscuits = new Biscuits( 150, 5, DateTime.Now.AddDays(30), 0.7);
            var tv = new TV( 500, 3, 15.0);
            var mobile = new Mobile( 300, 8, 0.2);
            var scratchCard = new MobileScratchCards( 25, 20);

            var customer = new Customer("Mohamed Belal", 1000.0);


            #region Empty Cart
            Console.WriteLine("\n\n======================= Empty Cart ===================================");
            var cart1 = new Cart();
            EcommerceSystem.Checkout(customer, cart1);
            #endregion



            #region Normal process
            Console.WriteLine("\n\n======================= Normal process ===============================");
          
            var cart2 = new Cart();
            cart2.Add(cheese, 2);
            cart2.Add(biscuits, 1);
            cart2.Add(scratchCard, 1);
            EcommerceSystem.Checkout(customer, cart2);
            #endregion

            #region Normal process
            Console.WriteLine("\n\n======================= Insufficient balance =========================");
            var cart3 = new Cart();
            var customer2 = new Customer("Ahmed", 50.0);
            cart3.Add(cheese, 2);
            cart3.Add(biscuits, 1);
            cart3.Add(scratchCard, 1);
            EcommerceSystem.Checkout(customer2, cart3);
            #endregion



            #region Normal process
            Console.WriteLine("\n\n======================= Cheese is Out of Stock =======================");
            var cart4 = new Cart();
            cart4.Add(cheese, 22222);
            cart4.Add(biscuits, 1);
            cart4.Add(scratchCard, 1);
            EcommerceSystem.Checkout(customer, cart4);
            #endregion

            #region Normal process
            Console.WriteLine("\n\n======================= Cheese is Expired ============================");
            var expiredCheese = new Cheese(100, 5, DateTime.Now.AddDays(-1), 0.4);
            var cart5 = new Cart();
            cart5.Add(expiredCheese, 2);
            cart5.Add(biscuits, 1);
            cart5.Add(scratchCard, 1);
            EcommerceSystem.Checkout(customer, cart5);
            #endregion



        }
    }
}

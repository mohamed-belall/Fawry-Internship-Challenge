using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce
{
    public static class ShippingService
    {
        public static int Fees = 30;

        public static void ProcessShipment(List<IShippable> items)
        {
            Console.WriteLine("** Shipment notice **");

            var itemGroups = items.GroupBy(i => i.getName()).Select(g => new
            {

                Name = g.Key,
                Count = g.Count(),
                Weight = g.Sum(g => g.getWeight())
            });

            foreach(var item in itemGroups)
            {
                Console.WriteLine($"{item.Count}x {item.Name}   {item.Weight}");
            }

            Console.WriteLine($"Total package weight {itemGroups.Sum(ig => ig.Weight)}Kg");
            Console.WriteLine();
        }

    }
}

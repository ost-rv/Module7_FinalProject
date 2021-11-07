using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public static class ExtensionOrder
    {
        public static void DisplayOrder(this Order<HomeDelivery> order)
        {
            Console.WriteLine(order.ToString());
            Console.WriteLine(order.Delivery.ToString());
        }

        public static void DisplayOrder(this Order<PickPointDelivery> order)
        {
            Console.WriteLine(order.ToString());
            Console.WriteLine(order.Delivery.ToString());
        }

        public static void DisplayOrder(this Order<ShopDelivery> order)
        {
            Console.WriteLine(order.ToString());
            Console.WriteLine(order.Delivery.ToString());
        }
    }
}

using System;
using System.Collections.Generic;

namespace Module7_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {

            OnlineStore store = new OnlineStore();

            store.AddProduct(new Product { Description = "Apple", Price = 2, UnitMeasure = "kg"});
            store.AddProduct(new Product { Description = "Apple", Price = 3, UnitMeasure = "kg" }); //проверка перегруженного оператора == для Product

            Customer customer = new Customer { Id = "sh", FirstName = "Sherlock", LastName = "Holmes", Type = TypeCustomer.Platino };
            
            Courier courier = new Courier { Id = 1, FirstName = "Jack", LastName = "London" };
            
            List<OrderProduct> products = new List<OrderProduct>() {
                new OrderProduct(store[0], 1), //индексатор по Product.Id
                new OrderProduct(store["TV"], 1), //индексатор по Product.Description
                new OrderProduct(store["Apple"], 1.5), //индексатор по Product.Description
                new OrderProduct(store.Products[3], 1)            
            };

            Address address = new Address("Англия", "Лондон", "Бейкер-стрит", "221b");

            Order<HomeDelivery> order = Order<HomeDelivery>.CreateOrder(0, products, customer, new HomeDelivery(courier) { Address = address});

            store.AddOrder(order);

            store.HomeOrders[0].DisplayOrder();// метод расширения


            Console.ReadLine();

        }
    }
}

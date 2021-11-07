using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class OnlineStore
    {
        #region
        private readonly List<Order<HomeDelivery>> _homeOrders;
        private readonly List<Order<PickPointDelivery>> _pickPointOrders;
        private readonly List<Order<ShopDelivery>> _shopOrders;
        
        private  readonly List<Product> _products;
        #endregion Поля

        #region Свойства

        public  List<Order<HomeDelivery>> HomeOrders { get { return _homeOrders; } }
        public List<Order<PickPointDelivery>> PickPointOrders { get { return _pickPointOrders; } }
        public List<Order<ShopDelivery>> ShopOrders { get { return _shopOrders; } }

        public  List<Product> Products { get { return _products; } }
        #endregion Свойства

        #region Индексаторы

        public  Product this[int id]
        {
            get { return _products.FirstOrDefault(p => p.Id == id); }
        }

        public Product this[string description]
        {
            get { return _products.FirstOrDefault(p => p.Description == description); }
        }

        #endregion Индексаторы

        #region Инициализация
        public OnlineStore()
        {
            //компазиция
            _homeOrders = new List<Order<HomeDelivery>>();
            _pickPointOrders = new List<Order<PickPointDelivery>>();
            _shopOrders = new List<Order<ShopDelivery>>();

            _products = new List<Product>
            {
                new Product() { Description = "Phone", UnitMeasure = "pcs", Price = 20 },
                new Product() { Description = "TV", UnitMeasure = "pcs", Price = 30 },
                new Product() { Description = "Cucumber ", UnitMeasure = "kg", Price = 1 },
                new Product() { Description = "Desk", UnitMeasure = "pcs", Price = 25 },
                new Product() { Description = "Potato", UnitMeasure = "kg", Price = 0.7M },
                new Product() { Description = "Broccoli", UnitMeasure = "kg", Price = 1.2M },
                new Product() { Description = "Watch ", UnitMeasure = "pcs", Price = 100 },
            };
            //компазиция
        }
        #endregion Инициализация

        #region Методы
        public  void AddOrder(Order<HomeDelivery> order) 
        {
            _homeOrders.Add(order);
        }

        public void AddOrder(Order<PickPointDelivery> order)
        {
            _pickPointOrders.Add(order);
        }

        public void AddOrder(Order<ShopDelivery> order)
        {
            _shopOrders.Add(order);
        }

        public void AddOrder<TDelivery>(Order<TDelivery> order) where TDelivery : Delivery
        {
            if (order is Order<HomeDelivery> homeOrder)
            {
                _homeOrders.Add(homeOrder);
            }

            if (order is Order<PickPointDelivery> pickPointOrder)
            {
                _pickPointOrders.Add(pickPointOrder);
            }

            if (order is Order<ShopDelivery> shopOrder)
            {
                _shopOrders.Add(shopOrder);
            }
        }

        #endregion Методы

        public void AddProduct(Product product)
        {
            bool productIsExists = false;
            foreach (Product prod in Products)
            {
                if (product == prod) //Перегрузка операторов == !=
                {
                    productIsExists = true;
                    Console.WriteLine($"{product} уже добавлен в список товаров.");
                    break;
                }
            }
            if (!productIsExists)
            {
                Products.Add(product);
            }
        }
    }
}

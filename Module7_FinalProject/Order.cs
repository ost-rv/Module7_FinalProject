using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public  class Order<TDelivery>
        where TDelivery : Delivery
    {
        #region Поля
        private TDelivery _delivery;
        #endregion

        #region Свойсва
        
        public int Id { get; protected set; }

        public string Note { get; set; }

        public Customer Customer { get; set; }

        public List<OrderProduct> Products { get; set; }

        public TDelivery Delivery { get { return _delivery; } set { _delivery = value; } }

        #endregion Свойства

        #region Инициализация
        public Order(int id)
        {
            Id = id;
            Products = new List<OrderProduct>();
        }

        public Order(int id, Customer customer) : this(id)
        {
            Customer = customer;//агрегация
        }

        public Order(int id, TDelivery delivery) : this(id)
        {
            Delivery = delivery;//агрегация
        }

        public Order(int id, Customer customer, TDelivery delivery) : this(id)
        {
            Customer = customer;//агрегация
            Delivery = delivery;//агрегация
        }

        public static Order<TDelivery> CreateOrder(int id, List<OrderProduct> products, Customer customer, TDelivery delivery)
        {
            Order<TDelivery> order = new Order<TDelivery>(id) { Products = products, Customer = customer, Delivery = delivery };

            return order;
        }

        public static Order<TDelivery> CreateOrder(int id, Customer customer)
        {
            Order<TDelivery> order = new Order<TDelivery>(id, customer);

            return order;
        }


        #endregion Инициализация

        #region Методы

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        public override string ToString()
        {
            string result = "";
            result = $"Заказ №{Id}\r\n";
            result += $"\tКлиент {Customer}\r\n";

            result += "\tПродукты: \r\n";

            foreach (OrderProduct prod in Products)
            {
                result += "\t\t" + prod.ToString() + "\r\n";
            }

            return result;
                
        }


        #endregion Методы



    }
}

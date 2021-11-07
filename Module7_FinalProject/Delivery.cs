using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public abstract class Delivery
    {
        public abstract Address Address { get; set; }

        public override string ToString()
        {
            return $"Адрес: {Address}";
        }
    }

    public class HomeDelivery : Delivery
    {
        private Address _address;
        public Courier Courier { get; set; }

        public override Address Address
        { 
            get {return _address; }
            set { _address = value; }
        }

        public HomeDelivery()
        { }

        public HomeDelivery(Courier courier)
        {
            Courier = courier;
        }

        public override string ToString()
        {
            string result = base.ToString() + "\r\n";
            result += $"Курьер: {Courier}"; 
            return  result;
        }
    }

    public class PickPointDelivery : Delivery
    {
        private Address _address;
        public PickPoint PickPoint { get; set; }

        public override Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public override string ToString()
        {
            string result = base.ToString() + "\r\n";
            result += PickPoint.ToString();
            return result;
        }
    }

    public class ShopDelivery : Delivery 
    {
        private Address _address;
        public RieteilShop RieteilShop { get; set;}

        public override Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public override string ToString()
        {
            string result = base.ToString() + "\r\n";
            result += RieteilShop.ToString();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class OrderProduct
    {
        public Product Product { get; set; }

        private double _qty;
        public double Qty
        {
            get { return _qty; }
            set
            {

                if (value > 0)
                {
                    _qty = value;
                }
            }
        }

        public decimal Cost 
        {
            get { return (decimal)Qty * (Product?.Price ?? 0); }
        }

        public OrderProduct()
        { 
        
        }

        public OrderProduct(Product product, double qty)
        {
            Product = product;
            Qty = qty;
        }

        public override string ToString()
        {
            return $"{Product} Qty = {Qty} UM = {Product.UnitMeasure} Cost = {Cost};";
        }


    }
}

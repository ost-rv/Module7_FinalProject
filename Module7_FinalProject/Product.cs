using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class Product
    {
        private static int newId;
        public int Id { get; set; }

        public string Description { get; set; }

        public string UnitMeasure { get; set; }

        decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            }
        }

        public Product()
        {
            Id = newId;
            newId += 1;

        }

        public override string ToString()
        {
            return $"№{Id} {Description} price {Price}";
        }
        public override bool Equals(object obj)
        {
            Product p = (Product)obj;
            return (this.Description == p.Description && this.UnitMeasure == p.UnitMeasure);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Product product1, Product product2)
        {
            return product1.Equals(product2);
        }

        public static bool operator !=(Product product1, Product product2)
        {
            return !product1.Equals(product2);
        }

    }
}

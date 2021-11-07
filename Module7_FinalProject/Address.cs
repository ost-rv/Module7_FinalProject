using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class Address
    {
        private string _country;
        private string _place;
        private string _street;
        private string _number;

        public Address()
        {
            
        }

        public Address(string country,
                       string place,
                       string street,
                       string number)
        {
            _country = country;
            _place = place;
            _street = street;
            _number = number;
        }

        public string Country 
        { 
            get { return _country; }
            set { _country = value; }
         }

        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public override string ToString()
        {
            return $"{Country}, {Place}, {Street}, {Number}";
        }
    }
}

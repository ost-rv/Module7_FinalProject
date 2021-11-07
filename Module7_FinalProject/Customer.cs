using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class Customer : Person<string>
    {
        public TypeCustomer Type { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} (Id = {Id}) (Type = {Type})";
        }
    }
}

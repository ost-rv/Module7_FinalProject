using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class RieteilShop
    {
        public string Description { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Пунк выдачи: {Description}; т.: {Phone};";
        }
    }
}

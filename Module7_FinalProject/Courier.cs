using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class Courier : Person<int>
    {
        public TypeOfMovement TypeOfMovement { get; set; }
    }
}

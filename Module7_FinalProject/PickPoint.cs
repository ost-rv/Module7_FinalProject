using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_FinalProject
{
    public class PickPoint
    {
        public string Description { get; set; }
        public int StorageTime { get; set; }

        public override string ToString()
        {
            return $"Пунк выдачи: {Description}; Срок хранения: {StorageTime};";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Storage
    {
        public string Type { get; set; } // HDD или SSD
        public int Size { get; set; } // В ГБ

        public Storage(string type, int size)
        {
            Type = type;
            Size = size;
        }
    }
}

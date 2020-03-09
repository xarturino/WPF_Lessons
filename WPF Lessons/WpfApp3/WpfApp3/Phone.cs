using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3
{
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Smartphone {this.Name};price {this.Price}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSIT2220_Lab3
{
    struct Additive
    {
        public int id;
        public string name;
        public decimal price;

        Additive ( int id, string name, decimal price )
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTesting.src.dataProject
{
    class Product:IProduct
    {
        public Product(){}
        public Product(int id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int id { get; set; }

        public string name{ get; set; }

        public decimal price{ get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class ProductSpecification
    {
        private string id;
        private float price;
        private string description;
        public ProductSpecification(string id, float price, string description)
        {
            this.id = id;
            this.price = price;
            this.description = description;
        }
        public string getltemID() {
            return id;
        }
        public float getPrice()
        {
            return price;
        }
        public String getDescription()
        {
            return description;
        }
    }
}

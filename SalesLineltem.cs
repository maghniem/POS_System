using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class SalesLineltem
    {
        private int quantity;
        private ProductSpecification productSpec;
        public SalesLineltem(ProductSpecification spec, int quantity)
        {
            this.productSpec = spec;
            this.quantity = quantity;
        }
        public float getSubtotal()
        {
            return productSpec.getPrice()*quantity;
        }
    }
}

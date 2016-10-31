using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class Register
    {
        private ProductCatalog catalog;
        private Sale sale;
        public Register(ProductCatalog catalog)
        {
            this.catalog = catalog;
        }
        public void endSale()
        {
            sale.becomeComplete();
        }
        public void enterltem(string id, int quantity)
        {
            ProductSpecification spec = catalog.getSpecification(id);
            sale.MakeLineItem(spec, quantity);
        }
        public void makeNewSale()
        {
            sale = new Sale();
        }

        public Sale GetSale()
        {
            return sale;
        }

        public ProductCatalog GetProductCatalog()
        {
            return catalog;
        }
        public void makePayment(float cashTendered)
        {
            sale.makePayment(cashTendered);
        }
    }
}

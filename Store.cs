using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class Store
    {
        private ProductCatalog catalog;

        private Register register;
        public Store()
        {
            catalog = ProductCatalog.Instance;//Sington
            register = new Register(catalog);
        }
        public Register getRegister() { return register; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    //Singleton
    public class ProductCatalog
    {
        private static ProductCatalog instance;

        private Dictionary<string, ProductSpecification> productSpecifications = new Dictionary<string, ProductSpecification>();

        private ProductCatalog()
        {

            productSpecifications.Add("100", new ProductSpecification("100", 2, "milk"));
            productSpecifications.Add("101", new ProductSpecification("101", 5, "cake"));
            productSpecifications.Add("102", new ProductSpecification("102", 3, "noodle"));

            productSpecifications.Add("201", new ProductSpecification("201", 2, "pen"));
            productSpecifications.Add("202", new ProductSpecification("202", 1, "pencil"));
            productSpecifications.Add("203", new ProductSpecification("203", 3, "paper"));
        }

        public static ProductCatalog Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductCatalog();
                }
                return instance;
            }
        }

       
        public ProductSpecification getSpecification(string id)
        {
            return productSpecifications[id];
        }
    }
}

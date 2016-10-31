using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class OntarioTaxCalculator : ITaxCalculator
    {
        public float GetTaxRate()
        {
            return new OntarioTaxRate().GetOntarioTaxRate();
        }
    }
}

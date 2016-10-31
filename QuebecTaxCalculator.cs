using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
     public class QuebecTaxCalculator : ITaxCalculator
    {
        //this method will call the tax rate defined in QuebecTaxRate class
        public float GetTaxRate()
        {
            return new QuebecTaxRate().GetQuebecTaxRate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class Payment
    {
        private float amount;
        public Payment(float cashTendered) { amount = cashTendered; }
        public float getAmount() { return amount; }
    }
}

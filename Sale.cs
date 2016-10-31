using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class Sale
    {
        private List<SalesLineltem> lineltems = new List<SalesLineltem>();
        private DateTime date = new DateTime();
        private bool isComplete = false;
        private Payment payment;
        ITaxCalculator taxCalculator;
        public float getBalance()
        {
            return payment.getAmount() -  getTotal() ;
        }

        public void becomeComplete()
        {
            isComplete = true;
        }

        public bool IsComplete()
        {
            return isComplete;
        }

        public void MakeLineItem(ProductSpecification spec, int quantity)
        {
            lineltems.Add(new SalesLineltem(spec, quantity));
        }

        public List<SalesLineltem> GetLineItems()
        {
            return lineltems;
        }

        public float getTotal()
        {
            float total = 0;

            foreach(SalesLineltem salesLineltem in lineltems)
            {
               
                total += salesLineltem.getSubtotal();
            }
            return total;
        }

        //Stragegy
        public float getTotalAfterDiscouting()
        {
            ISalePricingStrategy salePricingStrategy = SalePricingStrategyFactory.CreateInstance();
            return salePricingStrategy.GetTotal(this);
        }

        //Adapter
        public float getTotalTax()
        {
            if(taxCalculator==null)
            {
                taxCalculator = TaxCalculatorFactory.CreateInstance();
            }

            return taxCalculator.GetTaxRate() * getTotalAfterDiscouting();
        }

        public void makePayment(float cashTendered)
        {
            payment = new Payment(cashTendered);
        }
    }
}

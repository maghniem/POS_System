 

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public  class TaxCalculatorFactory
    {
        public static ITaxCalculator CreateInstance()
        {

            ITaxCalculator taxCalculator=null;
            string className = ConfigurationManager.AppSettings["ClassName"];
            if(className== "OntarioTaxCalculator")
            {
                taxCalculator = new OntarioTaxCalculator();
            }
            else if(className == "QuebecTaxCalculator")
            {
                taxCalculator =  new QuebecTaxCalculator();
            }

            return taxCalculator;
        }


        //public static ITaxCalculator CreateInstance()
        //{

        //    string assemblyName = ConfigurationManager.AppSettings["AssemblyName"] ;
        //    string className = ConfigurationManager.AppSettings["ClassName"];
            
        //    Assembly assembly = Assembly.Load(assemblyName);

        //    return assembly.CreateInstance(className) as ITaxCalculator;

        //}
		
	  
	}
	
}
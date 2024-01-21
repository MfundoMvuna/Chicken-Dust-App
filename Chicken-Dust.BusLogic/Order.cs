using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken_Dust.BusLogic
{
    internal class Order : ISauces
    {
        private double additional = 0;
        private double total = 0;
        public double sauceType(string name)
        {

            if (name == null)
            {
                throw new ArgumentNullException("name");
            }

            switch(name)
            {
                case "EXTRA":
                    return additional = 5;
                default:
                    return additional = 0;
            }
        }

       public double CalculateTotal()
        {
            var withExtraSuace = sauceType("EXTRA");

            if (withExtraSuace == 0) 
            { 
                return total; 
            }
            total += additional;
            return total;
        }

    }
}

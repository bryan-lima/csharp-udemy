using System;
using System.Collections.Generic;
using System.Text;

namespace section4.exercises
{
    class CurrencyConverter
    {
        public static double ConvertFromDollarToReal(double currentQuote, double dollarsBuy)
        {
            double conversion = currentQuote * dollarsBuy;
            double IOF = conversion * 0.06;
            
            return conversion + IOF;
        }
    }
}

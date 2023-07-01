using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoin.Utils
{
    static public class MathFunctions
    {
        static public decimal RoundUp(decimal value)
        {
            return Math.Ceiling(value * 100) / 100;
        }
        static public decimal RoundUp7Cents(decimal value)
        {
            decimal roundedValue = Math.Ceiling(value*100)/100;
            decimal remainder = roundedValue % 0.07m;
            return roundedValue + (0.07m - remainder);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class SquareRoots
    {    
        /// <summary>
        /// get sum of all square roots of digits of a number
        /// </summary>        
        public static int SquareDigits(int n)
        {
            if (n / 10 == 0)
                return n*n;            
            
            int lastdigit = n % 10;
            int lastdigitSquare = lastdigit * lastdigit;
            int multiplier = (lastdigitSquare > 9) ? 100 : 10;
            return lastdigitSquare + (SquareDigits(n / 10) * multiplier);
        }
    


}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecurionApplictions
{
    public static  class RecursionNumber
    {
        public static int RecursionFactorial(this int value ) {
            if ( value <= 1 ) return 1;
            return value * RecursionFactorial( value - 1 );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension__Method
{
    public static class IntExtension
    {
        public static Boolean IsBetween(this int Value, int min , int max)
        {
            return Value >= min && Value <= max;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Extention_Pow.Helpers
{
    public static class Extentions
    {
        public static double  Power( this int  num1,int pow1)
        {
            return Math.Pow(num1 , pow1 );
        }
    }
}

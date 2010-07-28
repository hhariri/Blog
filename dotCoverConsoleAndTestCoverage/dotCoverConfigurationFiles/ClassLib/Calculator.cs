using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib
{
   public class Calculator
   {
       public int Add(int a, int b)
       {
           return a + b;
       }


       public int Subtract(int a, int b)
       {
           return a - b;
       }

       public int Multiply(int a, int b)
       {
           return a*b;
       }

        public int Divide(int a, int b)
        {
            return a/b;
        }

   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Library
{
    public class Calculator
    {
        public static int Divide(int numerator, int demonirator)
        {
            if (demonirator == 0)
                throw new DivideByZeroException("Demonirator cannot be zero");
            int result = numerator / demonirator;
            return result;
        }
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public  int Add(int FN,int SN)
        {
            if (IsPositive(FN) && IsPositive(SN))
            {
                int result = FN + SN;
                return result;
            }
            else
            {
                throw new ArgumentException("Only positive numbers are allowed");
            }

        }
        private  bool IsPositive (int number)
        {

            return number > 0;
        }
       


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
     public class program
    {
        public static int Main(string[] args)
        {
            try
            { 
                int iTargetNumber=Convert.ToInt32(args[0]);
                if(iTargetNumber==0)
                {
                    Console.WriteLine("Factorial Of Zero=1");

                }
                else if(iTargetNumber<0)
                {
                    Console.WriteLine(" Please Enter Positive Nmber greater than zero");

                }
                else 
                {
                    double dFactorialResult = 1;
                    for(int i = iTargetNumber;i>=1;i--)
                    {
                        dFactorialResult = dFactorialResult * i;

                    }
                    Console.WriteLine("Factorial of  {0}={1}", iTargetNumber, dFactorialResult);
                }
                return 0;
            }   
            catch(FormatException)
            {
                Console.WriteLine("{0} is a not valid number",args[0]);
                return 1;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Please Enter Number Between 1 and {0}");
                return 1;
            }
            catch (Exception)
            {
                Console.WriteLine("There Is A Problem");
                return 1;
            }
        }

    }
}

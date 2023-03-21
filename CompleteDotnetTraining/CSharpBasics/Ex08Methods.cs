using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{

    class SampleClass
    {
        //Instance function
        public void FunctionName(string name)
        {
            
            Console.WriteLine("The function with the name {0} is implemented",name );
        }
        
        //Static function
        public static void StaticFunc()
        {
            Console.WriteLine("Static function is invoked");
        }

        public void ModifyOperation(ref int iValue)
        {
            Console.WriteLine("The Input passsed: " + iValue);
            iValue= iValue + 1123 * 45/4;
            Console.WriteLine("After modifying in the func: " + iValue);
        }

        public void MathOperation(int iVal1, int iVal2, ref long iAddValue, ref int iSubValue, ref double divValue)
        {
            iAddValue = iVal1 + iVal2;
            iSubValue = iVal1- iVal2;
            if(iVal2 != 0)
            {
                divValue= iVal1 / iVal2;
            }
        }

        public void SquareOperation(int iValue, out double sqrNo, out double sqrRtNo)
        {
            sqrNo = iValue * iValue;
            sqrRtNo = Math.Sqrt(iValue);
        }

        public long AddFunc(params int[] values) 
        {
            long res = 0;
            foreach (var item in values)
            {
                res += item;
            }
            return res;
        }
    }
    internal class Ex08Methods
    {
        static void Main(string[] args)
        {
            var exObj = new SampleClass();
            exObj.FunctionName("ExampleFunc");
            SampleClass.StaticFunc();
            //Test the ModifyOperation Func
            int someValue = 1234;
            exObj.ModifyOperation(ref someValue);
            Console.WriteLine("The Value of SomeValue after the Function call: " + someValue);

            long lRes = 0;
            int iRes = 0;
            double divVal = 0;
            exObj.MathOperation(123, 23, ref lRes, ref iRes, ref divVal);
            Console.WriteLine("The Result of Addition is " + lRes);
            Console.WriteLine("The Result of Subtraction is " + iRes);
            Console.WriteLine("The Result of Division is " + divVal);

            //Example on using out parameter
            double sqrt, sqr;//We are not required to initialize the variables. 
            exObj.SquareOperation(12, out sqr, out sqrt);
            Console.WriteLine($"The Square of {sqr} and Sqr root is {sqrt:##.##}");

            //Example on using params
            lRes = exObj.AddFunc(12, 13);
            Console.WriteLine("The Added value for the params func is " + lRes);
            lRes = exObj.AddFunc(12, 13, 56, 56, 34,66,33,3,6);
            Console.WriteLine("The Added value for the params func is " + lRes);
        }
    }
}

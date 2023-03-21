using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasics.Common;
namespace CSharpBasics
{
    internal class MathCalculator
    {
        public static int AddNumbers(int iVal1, int iVal2) => iVal1 + iVal2;
        public static int SubtractNumbers(int iVal1, int iVal2) => iVal1 - iVal2;
        public static int MultiplyNumbers(int iVal1, int iVal2) => iVal1 * iVal2;
        public static int DivideNumbers(int iVal1, int iVal2) => iVal1 / iVal2;
    }
    internal class Ex10CalcExample
    {
        const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~CALC PROGRAM~~~~~~~~~~~~~~~~~~\r\nADDING 2 VALUES------>PRESS 1\r\nSUBTRACTING---------->PRESS 2\r\nMULTIPLYING---------->PRESS 3\r\nDIVIDING---------->PRESS 4\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";

        static void Main()
        {
            do
            {
                int choice = MyConsole.GetNumber(menu);
                switch (choice)
                {
                    case 1:
                        addingNumbers();
                        break;
                    case 2:
                        subtractNumbers();
                        break;
                    case 3:
                        multiplyNumbers();
                        break;
                    case 4:
                        divideNumbers();
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        private static void multiplyNumbers()
        {
            int iVal1 = MyConsole.GetNumber("Enter the 1st Value");
            int iVal2 = MyConsole.GetNumber("Enter the 2nd Value");
            var result = MathCalculator.MultiplyNumbers(iVal1, iVal2);
            Console.WriteLine("The multiplied value is " + result);
        }

        private static void divideNumbers()
        {
            int iVal1 = MyConsole.GetNumber("Enter the 1st Value");
            int iVal2 = MyConsole.GetNumber("Enter the 2nd Value");
            var result = MathCalculator.DivideNumbers(iVal1, iVal2);
            Console.WriteLine("The Divided value is " + result);
        }
        private static void subtractNumbers()
        {
            int iVal1 = MyConsole.GetNumber("Enter the 1st Value");
            int iVal2 = MyConsole.GetNumber("Enter the 2nd Value");
            var result = MathCalculator.SubtractNumbers(iVal1, iVal2);
            Console.WriteLine("The Subtracted value is " + result);
        }

        static void addingNumbers()
        {
            int iVal1 = MyConsole.GetNumber("Enter the 1st Value");
            int iVal2 = MyConsole.GetNumber("Enter the 2nd Value");
            var result = MathCalculator.AddNumbers(iVal1, iVal2);
            Console.WriteLine("The Added value is " + result);
        }
    }
}

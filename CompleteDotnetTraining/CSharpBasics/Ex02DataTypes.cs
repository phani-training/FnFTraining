using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Ex02DataTypes
    {
        static void Main(string[] args)
        {
            //takeInputsAndDisplay();
            //displayRangeOfValueTypes();
            //dataConversionsOfValueTypes();
            //dateTimeConversionExample();
            //getDateAndDisplay();
            getTimeAndDisplay();
        }

        private static void getTimeAndDisplay()
        {
            Console.WriteLine("Enter the time of arrival as hh:mm");
            DateTime time = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The Time entered is " + time.ToString());
        }

        private static void getDateAndDisplay()
        {
            Console.WriteLine("Enter the date of Join in the format of dd-MM-yyyy");
            DateTime doJ = DateTime.Parse(Console.ReadLine());
            //Parse method is used to convert string to its type. 
            Console.WriteLine("The Date of Join is " + doJ.ToLongDateString());
        }

        private static void dateTimeConversionExample()
        {
            var date = DateTime.Now;//Here we are creating a DateTime object and setting its value to System Date and Time. 
            Console.WriteLine("The current date and Time is " + date);
            Console.WriteLine("The Year part is " + date.Year);
            Console.WriteLine("The Month part is " + date.Month);
            Console.WriteLine("The Day part is " + date.Day);
            Console.WriteLine("The Short date format is " + date.ToShortDateString());
            Console.WriteLine("The longer date format is " + date.ToLongDateString());
            Console.WriteLine("The Custom format of the date represented as dd-MM-yy is " + date.ToString("dd-MMM-yy"));
        }

        static void dataConversionsOfValueTypes()
        {
            int iValue = 123;
            long lValue = iValue;//Implicit casting as there is no need to provide any instruction to the compiler. 

            iValue = (int)lValue;//C# uses C Style casting. 
            Console.WriteLine("The value of int is " + iValue);

            //////////////Example to convert an int to double//////
            double dValue = iValue;//Implicit
            dValue += .456;
            Console.WriteLine("The Double value is " + dValue);
            iValue = (int)dValue;
            Console.WriteLine("The int value is " + iValue);

        }

        static void displayRangeOfValueTypes()
        {
            Console.WriteLine($"The Range of an integer is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine("The Range of long is {0} and {1}", long.MinValue, long.MaxValue);
        }

        static void takeInputsAndDisplay()
        {
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Organization");
            string orgName = Console.ReadLine();

            Console.WriteLine($"Mr. {name} is of the age {age} and works in {orgName}");
            Console.WriteLine($"With his details we assume that he was born in the Year {DateTime.Now.Year - age}");
        }
    }
}

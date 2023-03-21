using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Common
{
    internal class MyConsole
    {
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        public static int GetNumber(string question)
        {
            return int.Parse(GetString(question));  
        }

        public static double GetDouble(string question)
        {
            return double.Parse(GetString(question));
        }

        public DateTime GetDate()
        {
            Console.WriteLine("Enter the date as dd/MM/yyyy");
            return DateTime.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    enum DayOfWeek 
    { 
        Sun = 1, Mon, Tue, Wed,Thu , Fri, Sat
    }
    internal class Ex03EnumsExample
    {
        static void Main(string[] args)
        {
            DayOfWeek WeekEnd = DayOfWeek.Sun;
            Console.WriteLine("The Weekend is on " + WeekEnd);
            Console.WriteLine("The Integer value of weekend is " + (int)WeekEnd);
            Console.WriteLine("Enter the Start Day of UR Week from the list below");
            var list = Enum.GetValues(typeof(DayOfWeek));
            foreach (var item in list) { Console.WriteLine(item); }
            DayOfWeek StartDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            Console.WriteLine("The selected day is " + StartDay);

        }
    }
}

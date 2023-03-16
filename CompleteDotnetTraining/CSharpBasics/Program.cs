using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow World from C#");
            //Try adding few more console.WriteLines. Display UR Name, AddressCity and Organization name on the Console.

            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();

            //Try taking inputs from the User like address, Age and Organization name and display it on the Console in a proper Format. 

            Console.WriteLine("Enter the Age");
            var age = Console.ReadLine();

            Console.WriteLine("Enter the Organization Name");
            var orgName = Console.ReadLine();

            Console.WriteLine($"The Name entered is {name} . The Age of the person is {age}. He works in {orgName}"); //New syntax of C# 5.0
        }
    }
}

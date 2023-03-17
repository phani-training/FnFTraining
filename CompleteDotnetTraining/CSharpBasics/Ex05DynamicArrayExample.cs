using System;

namespace CSharpBasics
{
    internal class Ex05DynamicArrayExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Data type for the Array in CTS");

            Type dataType = Type.GetType(Console.ReadLine());
            Array array = Array.CreateInstance(dataType, size);
            Console.WriteLine("Lets enter the values for the array");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the position {i} of the data type {dataType.Name}");
                var input = Console.ReadLine();
                array.SetValue(Convert.ChangeType(input, dataType), i); 
            }
            Console.WriteLine("All the values are set, now lets read them!!");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}

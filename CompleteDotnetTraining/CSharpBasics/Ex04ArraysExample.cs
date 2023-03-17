using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex04ArraysExample
    {
        static void Main(string[] args)
        {
            //creatingArrayAndDisplay();
            //otherWaysOfCreatingArrays();
            //multiDimensionalArray();
            //jaggedArrayExample();
        }

        private static void jaggedArrayExample()
        {
            int[][] school = new int[4][];
            school[0] = new int[] { 34,45,65,45 };
            school[1] = new int[] { 56,66,33,23,67,87,48,82,79 };
            school[2] = new int[] { 12,23,44,55,78,94,23,68,93, 77,67 };
            school[3] = new int[] { 34,45 };

            for (int i = 0; i < school.Length; i++)
            {
                Console.WriteLine("Student score in Classroom no " + i);
                foreach (var score in school[i]) { Console.Write(score + " "); }
                Console.WriteLine();
            }
        }

        private static void multiDimensionalArray()
        {
            int[,] data = { { 1, 2, 3, 4 }, { 3, 4, 5, 6 }, { 5, 6, 7, 8 } };
            //Data is 3x4
            Console.WriteLine("The No of dimensions in the array is " + data.Rank);
            Console.WriteLine("The length of the 1st dimension is " + data.GetLength(0));
            Console.WriteLine("The length of the 2nd dimension is " + data.GetLength(1));

            for(int i =0; i < data.GetLength(0); i++) 
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void otherWaysOfCreatingArrays()
        {
            string[] cartItems = { "Apples", "Mangoes", "Oranges", "PineApples" };
            foreach (string item in cartItems) { Console.WriteLine(item); }
        }

        private static void creatingArrayAndDisplay()
        {
            int[] elements = new int[5];
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine("Enter the value for the location " + i);
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }
            //foreach is always forward only and read only. 
            foreach (int value in elements)
            {

                Console.WriteLine(value);
            }
        }
    }
}

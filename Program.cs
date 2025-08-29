using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Single Dim. Array

            int min;
            int[] ar = new int[11] { 12, 7, 4, 27, 1, 13, 19, 6, 30, 9, 8 };

            for (int num = 0; num < ar.Length; num++)
            {
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[num] < ar[i])
                    {
                        min = ar[num];

                        ar[num] = ar[i];
                        ar[i] = min;
                    }
                }
            }
            Console.WriteLine("SINGLE ARRAY SORTED:\n");

            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + "  ");
            }



            // 2. Multi Dim. Array
           
            int[,] sorted = new int[7, 10]
            {
                {54,3,21,50,57,7,73,24,85,79}, 
                {33,11,19,33,51,72,80,6,78,25}, 
                {1,65,4,86,71,52,16,77,29,13}, 
                {23,44,90,70,28,17,53,64,62,83}, 
                {55,98,22,89,34,75,56,58,27,35}, 
                {87,88,8,61,74,14,66,20,59,81},
                {18,76,2,5,26,84,15,82,9,60}
            };

            int minNum;

            //loops through arrays for num to be compared
            for (int row = 0; row < 7; row++) 
            {
                //loops through columns for num to be compared
                for (int column = 0; column < 10; column++)  
                {
                    // Looping through each array (for checking) -- goes to next array after each element is checked
                    for (int checkingRow = 0; checkingRow < 7; checkingRow++) 
                    {
                        // Loops through each element in an array (for checking)
                        for (int checkingColumn = 0; checkingColumn < 10; checkingColumn++)  
                        {
                            if (sorted[row, column] < sorted[checkingRow, checkingColumn])
                            {
                                minNum = sorted[row, column];  // hold smaller nums index 

                                //swaps positions
                                sorted[row, column] = sorted[checkingRow, checkingColumn]; 
                                sorted[checkingRow, checkingColumn] = minNum; 
                            }
                        }
                    }
                }
            }

            Console.WriteLine("\n\n\nMULTI ARRAY SORTED:\n");

            for (int i = 0; i < 7; i++)
            {
                for (int x = 0; x < 10; x++)
                {
                    Console.Write(sorted[i, x] + "   ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}

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

            //int min;
            //int[] ar = new int[11] { 12, 7, 4, 27, 1, 13, 19, 6, 30, 9, 8 };

            //for (int x = 0; x < ar.Length; x++)
            //{              
            //    for (int i = 0; i < 11; i++)
            //    {
            //        if (ar[x] < ar[i])
            //        {
            //            min = ar[x];

            //            ar[x] = ar[i];                      
            //            ar[i] = min;
            //        }
            //    }
            //}
            //Console.WriteLine("SINGLE ARRAY SORTED\n");

            //for (int i = 0; i < ar.Length; i++)
            //{
            //    Console.Write(ar[i] + "  ");
            //}



            // 2. Multi Dim. Array

            int[,] ar2 = new int[7, 10]
            {
                {54,3,21,50,57,7,73,24,85,79}, 
                {33,11,19,33,51,72,80,6,78,25}, 
                {1,65,4,86,71,52,16,77,29,13}, 
                {23,44,90,70,28,17,53,64,62,83}, 
                {55,98,22,89,34,75,56,58,27,35}, 
                {87,88,8,61,74,14,66,20,59,81},
                {18,76,2,5,26,84,15,82,9,60}
            };

            // ph_ARR --- placeholder array
            // ph_IND --- Placeholder index

            // loop_ARR--- Looping array
            // loop_IND--- Looping index

            //Array 1:   [0,0] - [0,9]

          //  int ph_ARR = 0;
           // int ph_IND = 0;
           // int loop_ARR = 0;
            int min2;


            for (int ph_ARR = 0; ph_ARR < 7; ph_ARR++)  //PLACEHOLDER ARRAY
            {
                for (int ph_IND = 0; ph_IND < 10; ph_IND++)  //PLACEHOLDER INDEX
                {
                    for (int loop_ARR = 0; loop_ARR < 7; loop_ARR++) //LOOPING ARRAY
                    {
                        for (int loop_IND = 0; loop_IND < 10; loop_IND++)  //LOOPING INDEX
                        {
                            if (ar2[ph_ARR, ph_IND] < ar2[loop_ARR, loop_IND])
                            {
                                // A B   B B   B A

                                min2 = ar2[ph_ARR, ph_IND];

                                ar2[ph_ARR, ph_IND] = ar2[loop_ARR, loop_IND];

                                ar2[loop_ARR, loop_IND] = min2;

                                    Console.WriteLine($"\n[{loop_ARR},{loop_IND}].  PLACEHOLDER: {ar2[ph_ARR, ph_IND]}");


                                //for (int i = 0; i < 7; i++)
                                //{
                                //    for (int x = 0; x < 10; x++)
                                //    {
                                //        Console.Write(ar2[i, x] + "   ");
                                //    }
                                //    Console.WriteLine("\n");
                                //}

                                //Console.WriteLine("\n\n\n\n\n");

                            }
                            else
                            {
                                Console.WriteLine($"\n[{loop_ARR},{loop_IND}].  PLACEHOLDER: {ar2[ph_ARR, ph_IND]}");
                            }
                        }
                    }
                }
            }


            Console.WriteLine("\n\nMULTI ARRAY SORTED\n");

            for (int i = 0; i < 7; i++)
            {
                for (int x=0; x < 10; x++)
                {
                    Console.Write(ar2[i,x] + "   ");
                }
                Console.WriteLine("\n\n");
            }


        }
    }
}

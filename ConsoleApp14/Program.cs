using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] arr1 = new int[4, 3];
            //// accept from user 
            //Console.WriteLine("Enter 12 values");
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //// then write below code
            //for (int i = 0; i < arr1.GetLength(0); i++) // 0 - row size
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++) // 1 - column size
            //    {
            //        Console.Write($"arr1[{i},{j}] = {arr1[i, j]}  ");
            //    }
            //    Console.WriteLine();
            //}
            //{
            //    int[,] m1 = new int[3, 3];
            //    int[,] m2 = new int[3, 3];
            //    Console.WriteLine("Enter values for m1");
            //    for (int i = 0; i < m1.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < m1.GetLength(1); j++)
            //        {
            //            m1[i, j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    Console.WriteLine("Enter values for m2");
            //    for (int i = 0; i < m1.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < m1.GetLength(1); j++)
            //        {
            //            m2[i, j] = Convert.ToInt32(Console.ReadLine());
            //        }
            //    }
            //    Console.WriteLine("Result of m1 & m2");
            //    for (int i = 0; i < m1.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < m1.GetLength(1); j++)
            //        {
            //            Console.Write($"m1[{i},{j}] + m2[{i},{j}] = {m1[i, j] + m2[i, j]} ");
            //        }
            //        Console.WriteLine();
            //    }
            //}
            // Jagged array
            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[3] { 1, 2, 3 };
            jaggedArray[1] = new int[5] { 10, 20, 30, 40, 50 };
            jaggedArray[2] = new int[2] { 100, 200 };
            jaggedArray[3] = new int[4] { 11, 22, 33, 44 };

            for (int i = 0; i < jaggedArray.Length; i++) // 4
            {
                Console.WriteLine($"elements at row {i + 1}");
                for (int j = 0; j < jaggedArray[i].Length; j++) // column Length
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }


        }
    }
}

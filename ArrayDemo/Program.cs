using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] noArray = { 1, 3, 2, 4 };
            Console.WriteLine(noArray.Length);

            int[] noArray2 = new int[] { 1, 3, 1, 2, 4 };
            Console.WriteLine(noArray2.Length);

            int[] noArray3 = new int[5];
            Console.WriteLine(noArray3.Length);

            int[] dynamicArray;
            int size;
            Console.Write("Enter the size of an array : ");
            bool success = int.TryParse(Console.ReadLine(), out size);
            if (success)
            {
                dynamicArray = new int[size];
            }
            else
            {
                Console.Beep();
                dynamicArray = new int[1];
                Thread.Sleep(500);
            }
            Console.WriteLine($"size of dynamic array : {dynamicArray.Length}");
            Console.WriteLine("value of noArray2");
            printArray(noArray2);
            Console.WriteLine();
            Console.WriteLine("value of dynamicArray");
            printArray(dynamicArray);
            Console.WriteLine();
            Console.WriteLine("value of param parameter");
            printParam(3, 4, 1, 2, 3, 32, 22);

            MAxParam(out int max, out int min, 3, 4, 1, 2, 3, 32, 22);
            Console.WriteLine($"Maximum element is : {max}");
            Console.WriteLine($"Minimum element is : {min}");

            int[,] d2 = new int[2, 3]
            {
                {1,2,3},
                {3,4,5}
            };
            Console.WriteLine(d2.Length);
            Console.WriteLine(d2.GetLength(0)); // o is consider as a row
            Console.WriteLine(d2.GetLength(1)); // 1 is consider as a column

            int[][] jarray = new int[3][];
            jarray[0] = new int[2] { 1, 2 };
            jarray[1] = new int[3] { 3, 4, 5 };
            jarray[2] = new int[1] { 6 };
            foreach(int[] v in jarray)
            {
                int s = 0;
                Array.ForEach(v, each => s += each);
                Console.WriteLine(s);
            }

            Console.Read();
        }
        static void printArray(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write($"{value}\t");
            }
        }
        static void printParam(int a, params int[] arr)
        {
            foreach (int value in arr)
            {

                Console.Write($"{value}\t");
            }
        }
        static void MAxParam(out int max, out int min, params int[] arr)
        {
            //int max = arr[0];
            //int min = arr[0];
            max = 0;
            min = int.MaxValue;
            // Console.WriteLine(int.MaxValue);
            foreach (int value in arr)
            {
                max = value > max ? value : max;
                min = value < min ? value : min;
                //if (value > max)
                //{
                //    max = value;
                //}
                //if (value < min)
                //{
                //    min = value;
                //}
            }

        }
        static void maxmin(out int min,out int max,params int[] arr)
        {
            //Array.ForEach(arr, each => Console.WriteLine(each));
            int tmax, tmin;
            tmin = tmax = arr[0];
            Array.ForEach(arr, each => tmax = each > tmax ? each : tmax);
            Array.ForEach(arr, each => tmin = each > tmin ? tmin : each);
            max = tmax;
            min = tmin;
        }

    }
}

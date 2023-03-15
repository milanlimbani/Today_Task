using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameterType
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int value = 10;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            PassByValue(value, 5);
            Console.WriteLine($"After the PassByValue method calling {value}");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            PassByReference(ref value, 5);
            Console.WriteLine($"After the PassByReferenceod calling {value}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Magenta;
            int val = 0;
            OutMethod(out val);
            Console.WriteLine($"After the out method calling {val}");


            int a = 5;
           int b = 10;
           // int a = int.TryParse(Console.ReadLine(), out a);
            //int.TryParse(Console.ReadLine(), out a);
            //int.TryParse(Console.ReadLine(), out b);
            MaxMin(a,b,out int Max,out int min);
            Console.WriteLine($"The max value is {Max}");
            //Console.WriteLine(MaxMin(ref a,b));
            Console.WriteLine($"The min value is {min}");


            Console.Read();
        }
        static void PassByValue(int value,int changeApply)
        {
            Console.WriteLine($"After the PassByValue method calling {value}");

            value = value + changeApply;
            Console.WriteLine($"After the PassByValue method calling {value}");

        }
        static void PassByReference(ref int value,int changeApply)
        {
            Console.WriteLine($"After the PassByValue method calling {value}");

            value = value + changeApply;
            Console.WriteLine($"After the PassByValue method calling {value}");

        }
        static void OutMethod(out int val)
        {
            val = 10;
            Console.WriteLine($"After the PassByValue method calling {val}");

        }
        static void MaxMin(int a ,int b ,out int min ,out int max)
        {
            min = a > b ? a : b;
            max = a > b ? b : a;
           
        }
    }
}

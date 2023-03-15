using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 5;
            //boxing value to objce type (implicit)
            object o = no;
            Console.WriteLine("object : " + o);

            float noo = 5f;
            //boxing value
            //to objce type (implicit)
            object oo = noo;


            Console.WriteLine("object : " + oo);
            //unboxing object to value type (Explicit)
            int no1 = (int)o;
            Console.WriteLine("no1 : " + no1);
            Console.WriteLine("no1  = {0}", no1);
            Console.WriteLine($"no1 = {no1}");


            bool b = true;
            print(b);
            int value = 12;
            print(value);
            long val = 12;
            print(val);
            char ch = 'A';
            print(ch);
            object obj = 20;
            print(obj);
            sbyte svalue = sbyte.MinValue + 10;
            print((object)svalue);

            Student s = new Student() { StudentId = 1, Name = "Milan", Marks = 88 };

            Employee e = new Employee { EmployeeId = 1, Name = "Smit", Salary = 33333 };

            Employee emp;
            emp.EmployeeId = 1;
            emp.Name = "Milan";
            emp.Salary = 2000;

            Data.Method(s);
            Data.Method(emp);

            //checked and uncheckd value 
            Console.WriteLine("Max : {0}", int.MaxValue);
            Console.WriteLine("Min : {0}", int.MinValue);
            int data = int.MaxValue;
            unchecked
            {
                int values = int.MaxValue + 1;
                Console.WriteLine("value : " + values);
            }
            try
            {
                checked
                {
                    Console.WriteLine("value : " + (data + 1));
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
        static void print(bool b)
        {
            Console.WriteLine($"Type {b.GetType()} and Value {b}");
        }
        static void print(int value)
        {
            Console.WriteLine($"Type {value.GetType()} and Value {value}");
            Console.WriteLine($"Min value {int.MinValue} max value {int.MaxValue}");
        }
        static void print(long val)
        {
            Console.WriteLine($"Type {val.GetType()} and Value {val}");
            Console.WriteLine($"Min value {long.MinValue} max value {long.MaxValue}");
        }
        static void print(char ch)
        {
            Console.WriteLine($"Type {ch.GetType()} and Value {ch}");
            Console.WriteLine($"Min value {char.MinValue} max value {char.MaxValue}");
        }
        static void print(object obj)
        {
            Console.WriteLine($"Type {obj.GetType()} and Value {obj}");
            Type objtype = obj.GetType();
            if(objtype  == typeof(int))
            {
                Console.WriteLine($"Min value {int.MinValue} max value {int.MaxValue}");

            }else if(objtype  == typeof(long))
            {
                Console.WriteLine($"Min value {long.MinValue} max value {long.MaxValue}");

            }
            else if(obj is sbyte)
            {
                Console.WriteLine($"Min value {sbyte.MinValue} max value {sbyte.MaxValue}");

            }
        }
    }
}

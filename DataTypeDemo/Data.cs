using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeDemo
{
    class Data
    {
        public static void Method(object o)
        {
            if(typeof(Student) == o.GetType())
            {
                Student student = (Student)o;
                Console.WriteLine($"Student name {student.Name} and Student Marks {student.Marks}");
            }else if(o is Employee)
            {
                Employee employee = (Employee)o;
                Console.WriteLine($"Employee name {employee.Name} and Employee Salary {employee.Salary}");

            }
        }
    }
}

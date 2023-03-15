using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ID");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            int Salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ID");
            int idd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string Named = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            int Salaryy = Convert.ToInt32(Console.ReadLine());
            //Person p = new Person(1, "jay", 6000);
            //Person p1 = new Person(1, "Milan", 6000);
            Person p = new Person(id,Name,Salary);
            Person p1 = new Person(idd,Named,Salaryy);
            if (p.ComparePerson(p1))
            {
                Console.WriteLine("Both the object are same");
            }
            else
            {
                Console.WriteLine("not same");
            }
            Console.WriteLine($"person id {p.getPersonId()}");
            Console.WriteLine(p.Name);

          
            Console.Read();
        }
    }
}

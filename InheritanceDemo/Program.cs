using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Enter Empid");
            // int empid =(Convert.ToInt32(Console.ReadLine()));
            // Console.WriteLine("Enter Salary");
            // int empsalary = (Convert.ToInt32(Console.ReadLine()));
            // Console.WriteLine("Enter Name");
            // String empame = Console.ReadLine();
            // Console.WriteLine("Enter Department");
            // String Depart = Console.ReadLine();
            // Console.WriteLine("Enter Person ID");
            // int personid = (Convert.ToInt32(Console.ReadLine()));
            // Console.WriteLine("Enter Person Name");
            // String PersonName = Console.ReadLine();
            // Console.WriteLine("Enter Adhar No");
            // long Aadharno = (Convert.ToInt64(Console.ReadLine()));
            //Employee e = new Employee(empid,empsalary,empame,Department.HR,personid,PersonName,Aadharno);
            // Console.WriteLine($"{e.EmpId} {e.Name} {e.Adharno} {e.Id} {e.Salary}");




            ArrayList list = new ArrayList();
            Employee e5 = new Employee(101, 8000, "Milan", "Wb", 1, "jenil", 123456789012);
            Employee e1 = new Employee(102, 7000, "SMit", "HR", 2, "harmik", 123456789014);
            Employee e2 = new Employee(103, 6000, "Ravi", "HR", 3, "jayom", 123456789017);
            Employee e3 = new Employee(104, 5000, "Raj", "Sales", 4, "jemin", 123456789042);
            Employee e4 = new Employee(105, 9000, "Demo", "Web", 5, "keval", 123456789312);

            list.Add(e1);
            list.Add(e2);
            list.Add(e3);
            list.Add(e4);
            list.Add(e5);
         
            foreach (Employee obj in list)
            {
                Console.WriteLine($"{obj.EmpId} \t {obj.Salary} \t {obj.Name}\t {obj.Adharno} \t{obj.Id} \t {obj.Department}");
            }
            Console.WriteLine("Enter Department Name");
            String Dename = Console.ReadLine();
            foreach (Employee obj in list)
            {
                if (obj.Department == Dename)
                {
                    Console.WriteLine($"{obj.EmpId} \t {obj.Salary} \t {obj.Name}\t {obj.Adharno} \t{obj.Id} \t {obj.Department}");

                }
            }

            Console.WriteLine("Max Salary");
            var odata =int.MaxValue;
           
            foreach (Employee obj in list)
            {


                if (obj.Salary > odata)
                {

                    Console.WriteLine($"{obj.EmpId} \t {obj.Salary} \t {obj.Name}\t {obj.Adharno} \t{obj.Id} \t {obj.Department}");

                }
                odata = obj.Salary;


            }


            Console.WriteLine("Min Salary");
            
            var odata1 = int.MaxValue;
          
            foreach (Employee obj in list)
            {


                if (obj.Salary < odata1)
                {
                    odata1 = obj.Salary;
                }


                //odata1 = obj.Salary;

            }
            //Console.WriteLine(odata1);
           // if(odata1 == object.)
            foreach (Employee item in list)
            {


                if (odata1 == item.Salary)
                {
                    Console.WriteLine($"{item.EmpId} \t {item.Salary} \t {item.Name}\t {item.Adharno} \t{item.Id} \t {item.Department}");

                }


                //odata1 = obj.Salary;

            }


            Console.Read();

        }
       


    }
}

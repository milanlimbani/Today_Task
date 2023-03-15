using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public enum Department
    {
        sales,
        Web,
        HR
    }
    internal class Employee : Person
    {
        int _empId;
        int _salary;
        String _pos;
        //Department _department;
        string _department;
        int bonus;
        public Employee(int empId, int salary, string pos, string department, int personId, String name, long adharNo) : base(personId, name, adharNo)
        {
            _empId = empId;
            _salary = salary;
            _pos = pos;
            _department = department;
        }
        public Employee() : base()
        {
            _empId = 0;
            _salary = 0;
            _pos = string.Empty;
            // _department = 0;
            _department = string.Empty;

        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Id
        {
            get
            {
                return _personId;
            }
        }
        public long Adharno
        {
            get
            {
                return _adharNo;
            }
        }
        public int EmpId
        {
            get
            {
                return _empId;
            }
        }
        public int Salary
        {
            get
            {
                return _salary;
            }
        }
        public string Department
        {
            get
            {
                return _department;
            }
        }
    }
}

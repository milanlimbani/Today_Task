using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
   internal class Person
    {
        protected int _personId;
        protected String _name;
        protected long _adharNo;

        public Person()
        {
            _personId = 0;
            _name = string.Empty;
            _adharNo = 0;
        }
        public Person(int personId,string name,long adharNo)
        {
            _personId = personId;
            _name = name;
            _adharNo = adharNo;
        }
    }
}

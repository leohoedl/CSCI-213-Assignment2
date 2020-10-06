using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Person
    {
        string name;
        string address;
        string phoneNum;

        public Person(string _name, string _address, string _phoneNum)
        {
            Name = _name;
            Address = _address;
            PhoneNum = _phoneNum;
        }

        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string PhoneNum
        {
            get
            {
                return phoneNum;
            }
            set
            {
                phoneNum = value;
            }
        }
    }
}

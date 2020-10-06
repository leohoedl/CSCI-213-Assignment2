using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Customer: Person
    {
        int cusNumber;
        bool mailList;

        public Customer(string _name, string _address, string _phoneNum, int _cusNumber, bool _mailList) : base(_name, _address, _phoneNum)
        {
            CusNumber = _cusNumber;
            MailList = _mailList;
        }

        public int CusNumber
        {
            get
            {
                return cusNumber;
            }
            set
            {
                cusNumber = value;
            }
        }

        public bool MailList
        {
            get
            {
                return mailList;
            }
            set
            {
                mailList = value;
            }
        }

        public string toString()
        {
            return "name: " + Name + "   address: " + Address + "   phone num: " + PhoneNum + "   cus num: " + CusNumber + "   maillist? " + MailList;
        }

    }
}

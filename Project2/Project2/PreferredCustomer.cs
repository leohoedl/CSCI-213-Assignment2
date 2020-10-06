using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class PreferredCustomer : Customer
    {
        decimal purchases;
        double discount;


        public PreferredCustomer(string name, string address, string phone, int cusNum, bool mailList, decimal purchases) : base(name,address,phone,cusNum,mailList)
        {
            Purchases = purchases;
            Discount = 0.0;
        }

        public decimal Purchases
        {
            get
            {
                return purchases;
            }
            set
            {
                purchases = value;
            }
        }

        public double Discount
        {
            get
            {
                return discount;
            }
            set
            {
                if(Purchases >= 500.00m && Purchases < 1000.00m)
                    discount = 0.05;
                if(Purchases >= 1000.00m && Purchases < 1500.00m)
                    discount = 0.06;
                if (Purchases >= 1500.00m && Purchases < 2000.00m)
                    discount = 0.07;
                if (Purchases >= 2000.0m)
                    discount = 0.10;
                else
                    discount = 0.0;
            }
        }
        public string toString()
        {
            return "name: " + Name + "   address: " + Address + "   phone num: " + PhoneNum + "   cus num: " + CusNumber + "   maillist? " + MailList+"   purchases: "+Purchases+"   discount: "+Discount;
        }
    }
}

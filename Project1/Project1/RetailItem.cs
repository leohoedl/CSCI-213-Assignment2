using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class RetailItem
    {
        string description;
        int unitsOnHand;
        decimal price;

       public RetailItem(string desc, int units, decimal price)
        {
            Description = desc;
            UnitsOnHand = units;
            Price = price;
            
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if(value == "" ||  value == null)
                {
                    throw new ArgumentException();
                }

                description = value;
            }
        }

        public int UnitsOnHand
        {
            get
            {
                return unitsOnHand;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(UnitsOnHand)} must be >= 0.");
                }

                unitsOnHand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Price)} must be >= 0.");
                }

                price = value;
            }
        }

        public string toString()
        {
            return "Item: " + Description + " Quantity: " + UnitsOnHand + " Price: " + Price;
        }
    }
}

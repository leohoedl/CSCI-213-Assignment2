using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<PreferredCustomer> myCusList = new List<PreferredCustomer>();

        private void Button1_Click(object sender, EventArgs e)
        {
            PreferredCustomer customer1 = new PreferredCustomer("David S.", "Fargo, ND", "7017017017", 8482834, true, 20000.00m);
            PreferredCustomer customer2 = new PreferredCustomer("David B.", "Moorhead, MN", "7017017565", 8482835, false, 1000.00m);
            myCusList.Add(customer1);
            myCusList.Add(customer2);
            foreach (var x in myCusList)
            {
                listBox1.Items.Add(x.toString());
            }
        }
    }
}

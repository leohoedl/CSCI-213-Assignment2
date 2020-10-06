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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<Customer> myCusList = new List<Customer>();

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer customer1 = new Customer("David S.","Fargo, ND","7017017017",8482834,true);
            Customer customer2 = new Customer("David B.", "Moorhead, MN", "7017017565", 8482835, false);
            myCusList.Add(customer1);
            myCusList.Add(customer2);
            foreach(var x in myCusList)
            {
                listBox1.Items.Add(x.toString());
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

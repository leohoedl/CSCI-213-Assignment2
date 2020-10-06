using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RetailItem[] itemArray = new RetailItem[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            itemArray[0] = new RetailItem("Jacket", 12, 59.95m);
            itemArray[1] = new RetailItem("Jeans", 40, 34.95m);
            itemArray[2] = new RetailItem("Shirt", 20, 24.95m);
           
            listBox1.Items.Add(itemArray[0].toString());
            listBox1.Items.Add(itemArray[1].toString());
            listBox1.Items.Add(itemArray[2].toString());
        }
    }
}

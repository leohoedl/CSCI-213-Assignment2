using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        PopulationDBEntity dbcon = new PopulationDBEntity();

        private void ShowData()
        {
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.City1
                         select x;

            dataGridView1.DataSource = result.ToList();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            City myCity = new City();
            myCity.City1 = textBox1.Text;
            myCity.Population = Convert.ToDouble(textBox2.Text);
            dbcon.Cities.Add(myCity);
            dbcon.SaveChanges();
            ShowData();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if((string)row.Cells[0].Value == textBox1.Text)
                {
                    row.Selected = true;
                    row.Cells[0].Value = textBox1.Text;
                    row.Cells[1].Value = Convert.ToDouble(textBox2.Text);
                }
            }


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dbcon.Cities.Load();

            var result = (from x in dbcon.Cities.Local
                          where x.City1 == textBox1.Text
                          orderby x.City1
                          select x).First();
            dbcon.Cities.Remove(result);
            ShowData();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.Population
                         select x;

            dataGridView1.DataSource = result.ToList();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.Population descending
                         select x;

            dataGridView1.DataSource = result.ToList();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.City1
                         select x;

            dataGridView1.DataSource = result.ToList();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int result = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                result += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            MessageBox.Show("The total population is: " + result);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int result = 0;
            double avg = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                result += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                avg = result / dataGridView1.Rows.Count;
            }
            MessageBox.Show("The average population is: " + avg);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            int highest = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int temp = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                if (i == 0) { highest = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value); }
                if (temp > highest)
                {
                    highest = temp;
                }
                else
                    continue;
            }
            MessageBox.Show("The highest population is: " + highest);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            int lowest = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value);
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                int temp = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                if (i == 0) { lowest = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value); }
                if (temp < lowest)
                {
                    lowest = temp;
                }
                else
                    continue;
            }
            MessageBox.Show("The lowest population is: " + lowest);
        }
    }
}

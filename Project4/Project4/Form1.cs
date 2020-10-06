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

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);

        }

        PopulationDBEntities dbcon = new PopulationDBEntities();

        private void ShowData()
        {
            dbcon.Cities.Load();

            var result = from x in dbcon.Cities.Local
                         orderby x.City1
                         select x;

            dataGridView1.DataSource = result.ToList();
        }

    




        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortPopAsc(this.populationDBDataSet.City);
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortPopDesc(this.populationDBDataSet.City);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortPopDesc(this.populationDBDataSet.City);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortCityName(this.populationDBDataSet.City);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Population: " + cityTableAdapter.TotalPop().ToString());
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Avg Population: " + cityTableAdapter.AvgPop().ToString());
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest Population: " + cityTableAdapter.MaxPop().ToString());
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lowest Population: " + cityTableAdapter.MinPop().ToString());
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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((string)row.Cells[0].Value == textBox1.Text)
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
    }
}

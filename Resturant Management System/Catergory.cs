using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class Catergory : Form
    {
        public Catergory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Catergory_Load(object sender, EventArgs e)
        {
            var db = new DBConnection();
            DataTable data = db.setcatergory();

            if (data.Rows.Count > 0)
            {
                foreach(DataRow item in data.Rows)
                {
                    string id = item["sr#"].ToString();
                    string name = item["Name"].ToString();

                    dataGridView1.Rows.Add(new object[] { id, name });
                }
            }
            else
            {
                MessageBox.Show("Please Add Food Catergory");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var db = new DBConnection();
            string cat = txtcatergory.Text.ToLower();
       

            DataTable data = db.setcatergory();
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    if (cat == item["Name"].ToString().ToLower())
                    {
                        MessageBox.Show(cat + " is already exits");
                        txtcatergory.Text = "";
                        return;

                    }
                }
            
            

                db.addCatdata(txtcatergory.Text);
                this.Close();
                var cats = new Catergory();
                cats.Show();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

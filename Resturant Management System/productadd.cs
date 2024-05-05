using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class productadd : Form
    {
        string imglocation = "";
        public productadd()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                picbox.ImageLocation = imglocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = txtid.Text;
            string name = txtname.Text;
            string price = txtprice.Text;
            string catergory = txtcombobox.Text;

            var db = new DBConnection();
            db.addProduct(imglocation, id, name, price, catergory);

            txtid.Focus();

            MessageBox.Show("New Prduct Added");

        }

        private void productadd_Load(object sender, EventArgs e)
        {
            var db = new DBConnection();
            getcatergory(db.getcatergorytypes());
        }

        public void getcatergory(DataTable data)
        {
            if (data.Rows.Count > 0)
            {

                foreach (DataRow item in data.Rows)
                {

                    string catergory = item["Name"].ToString();
                    txtcombobox.Items.Add(catergory);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtprice.Text = "";
            txtcombobox.Text = "";
        }
    }
}

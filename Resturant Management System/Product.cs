using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Resturant_Management_System
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            var db = new DBConnection();
            updatetable(db.FullData());
        }

        public void updatetable(DataTable data) 
        {
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    string id = item["P_ID"].ToString();
                    string name = item["P_Name"].ToString();
                    string unitprice = item["P_Price"].ToString();
                    string catergory = item["P_Catergory"].ToString();
                    dataGridView1.Rows.Add(new object[] { id,name,unitprice,catergory });


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var add = new productadd();
            add.Show();
        }
    }
}

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
    public partial class CompanyOrderList : Form
    {
        public CompanyOrderList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyOrderList_Load(object sender, EventArgs e)
        {
            var db = new DBConnection();
            LoadOrderList(db.getOrderlist());
        }

        public void LoadOrderList(DataTable data)
        {
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    string id = item["Order_ID"].ToString();
                    string tname = item["Table_Name"].ToString();
                    string wname = item["Waiter_Name"].ToString();
                    string type = item["Order_Type"].ToString();
                    string status = item["Status"].ToString();
                    string total = item["Total"].ToString();

                    orderlistdetails.Rows.Add(new object[] { id, tname, wname, type, status, total });
                }
            }
            else
            {
                MessageBox.Show("Not Available any prducts");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class StaffDetails : Form
    {
       

        public StaffDetails()
        {
            InitializeComponent();
           
        }


        private void StaffGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaff addstaffmember = new AddStaff();
            addstaffmember.Show();
            Visible = true;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            
            StaffGrid.Rows.Clear();
            
            var db = new DBConnection();

           string search = searchtxt.Text;
            

            if (search == "")
            {
                MessageBox.Show("Please Enter Staff member name!!!");
            }
            else
            {
                DataTable data = db.staffsearch(search);

                if (data.Rows.Count > 0)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        string id = item["Sno"].ToString();
                        string name = item["Sname"].ToString();
                        string type = item["Stype"].ToString();
                        string phone = item["Sphone"].ToString();

                        StaffGrid.Rows.Add(new object[] { id, name, type, phone });
                    }
                }
            }
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            var db = new DBConnection();
            DataTable data = db.getstaff(); 

            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    string id = item["Sno"].ToString();
                    string name = item["Sname"].ToString();
                    string type = item["Stype"].ToString();
                    string phone = item["Sphone"].ToString();

                    StaffGrid.Rows.Add(new object[] { id, name, type, phone });
                }
            }
            
        }

        private void spanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

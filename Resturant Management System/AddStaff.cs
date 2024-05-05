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
    public partial class AddStaff : Form
    {
       

        public AddStaff()
        {
            InitializeComponent();
          
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
           
            var db = new DBConnection();
            db.addstaff(NameTxt.Text, TypeCBox.Text, ContactTxt.Text);
            NameTxt.Clear();
            ContactTxt.Clear();
            TypeCBox.SelectedText = "";
            this.Close();
           
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }
    }
}

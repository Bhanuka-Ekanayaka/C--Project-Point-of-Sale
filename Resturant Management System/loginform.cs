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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Resturant_Management_System
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var db = new DBConnection();
            DataTable data = db.loggin(txt_username.Text, txt_password.Text);
            if (data.Rows.Count > 0)
            {
                menu form2 = new menu();
                    form2.Show();
                 this.Hide();
            }
            else
            {
                MessageBox.Show("invalid login", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U1T0KNP;Initial Catalog=RMS;Integrated Security=True");


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;  

            try
            {
                String query = "SELECT * FROM login WHERE username= '"+username+ "' AND password ='"+ user_password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query,conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;

                    menu form2 = new menu();
                    form2.Show();
                    this.Hide();


                }
                else 
                {
                    MessageBox.Show("invalid login","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
            catch 
            {
                MessageBox.Show("error");
            }
            finally 
            {
            
            conn.Close(); ;
            
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

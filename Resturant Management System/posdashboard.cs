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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Staff_Click(object sender, EventArgs e)
        {
            StaffDetails sdt = new StaffDetails();
            sdt.Show();
           
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var pos = new pos_addnewform();
            pos.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var Pr = new Product();
            Pr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var cat = new Catergory();
            cat.Show();

        }
    }
}

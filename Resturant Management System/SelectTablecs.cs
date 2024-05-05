using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Resturant_Management_System
{
    public partial class SelectTablecs : Form
    {
        public SelectTablecs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectTablecs_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var db = new DBConnection();
            getTabel(db.LoadTable());
        }

        public void getTabel(DataTable data)
        {
            var db = new DBConnection();
            if (data.Rows.Count > 0)
            {

                foreach (DataRow rows in data.Rows)
                {
                    System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                    b.Size = new Size(186, 43);
                    b.BackColor = Color.FromName("DarkOrange");
                    b.ForeColor = Color.FromName("ControText");

                    b.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
                    b.Text = rows["Table_Name"].ToString();

                    b.Click += new EventHandler(clickbutton);

                    flowLayoutPanel1.Controls.Add(b);

                    foreach (DataRow order in db.getOrderlist().Rows)
                    {
                        if (b.Text == order["Table_Name"].ToString())
                        {
                            b.Enabled = false;
                            b.BackColor = Color.FromName("ActiveBorder");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Please insert Table");
            }
        }

        private void clickbutton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            var db = new DBConnection();
            db.addTable(b.Text, db.getOrderID());
            b.Enabled = false;
            b.BackColor = Color.FromName("ActiveBorder");
            this.Close();
            var waiter = new SelectWaiter();
            waiter.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

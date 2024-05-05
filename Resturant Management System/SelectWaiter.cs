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
    public partial class SelectWaiter : Form
    {
        public SelectWaiter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void getwaiterbutton(DataTable data)
        {
            var db = new DBConnection();
            if (data.Rows.Count > 0)
            {

                foreach (DataRow rows in data.Rows)
                {
                    System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                    b.Size = new Size(171, 45);
                    b.BackColor = Color.FromName("ActiveCaption");
                    b.ForeColor = Color.FromName("ControText");

                    b.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Bold);
                    b.Text = rows["Sname"].ToString();


                    foreach (DataRow order in db.getOrderlist().Rows)
                    {
                        if (b.Text == order["Waiter_Name"].ToString())
                        {
                            b.Enabled = false;
                            b.BackColor = Color.FromName("Silver");
                        }
                    }

                    b.Click += new EventHandler(clickbutton);



                    flowLayoutPanel1.Controls.Add(b);

                }
            }
            else
            {
                MessageBox.Show("Please insert waiters");
            }
        }

        private void clickbutton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            var db = new DBConnection();
            db.addwaiter(b.Text, db.getOrderID());
            b.Enabled = false;
            b.BackColor = Color.FromName("Silver");
            this.Close();
        }

        private void SelectWaiter_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var db = new DBConnection();
            getwaiterbutton(db.LoadWaiters());
        }
    }
}

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
    public partial class OrderType : Form
    {
        public OrderType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.SetOrderBillList(db.getOrderID(), "Dilivery");
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.SetOrderBillList(db.getOrderID(), "Din In");

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            db.SetOrderBillList(db.getOrderID(), "Take Away");

            this.Close();
        }
    }
}

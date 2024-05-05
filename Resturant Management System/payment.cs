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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbill_TextChanged(object sender, EventArgs e)
        {

        }

        private void payment_Load(object sender, EventArgs e)
        {
            txtbill.Text = pos_addnewform.instance.bill.Text;
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            txtnetamount.Text = (Double.Parse(txtbill.Text) - Double.Parse(txtdiscount.Text)).ToString("N2");
        }

        private void txtreceived_TextChanged(object sender, EventArgs e)
        {
            txtchange.Text = (Double.Parse(txtreceived.Text) - Double.Parse(txtnetamount.Text)).ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            double netamount = Convert.ToDouble(txtnetamount.Text);
           
            double change = Convert.ToDouble(txtchange.Text);
            var db = new DBConnection();
            string bilid = db.getOrderID();
            if (change >= 0)
            {

                int count = Convert.ToInt32(bilid) + 1;
                string orderid = count.ToString();
                string status = "inComplete";
                decimal Total = Convert.ToDecimal(netamount);
                db.SetOrderBillList(orderid, status, Total);

            }
            else
            {
                MessageBox.Show("Not Enough Money!!!");
            }
            var type = new OrderType();
            type.Show();
            this.Close();
        }
    }
}

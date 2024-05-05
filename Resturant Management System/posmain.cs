using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Resturant_Management_System
{
    public partial class pos_addnewform : Form
    {
        public static pos_addnewform instance;
        public Label bill;
        public DataGridView ordertable;
        public pos_addnewform()
        {
            InitializeComponent();
            instance = this;
            bill = billlabel;
            ordertable = OrderList;
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pos_addnewform_Load(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();//clear product items
                                              // flowLayoutPanel1.Controls.Clear();this can remove the catergories buttons.
            DBConnection db = new DBConnection();
            getbutton(db.addcategory());
            getLoadData(db.FullData());
        }

        //For Close button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //For Order Items

      

        public void AddItems(string id, string name, string cat, float price, Image pimage)
        {
            var items = new prductItem()
            {
                Pname = name,
                Price = price,
                PCatergory = cat,
                Pimage = pimage,
                Id = id,
            };
            flowLayoutPanel2.Controls.Add(items);

            items.onSelect += (ss, ee) =>
            {
                var wdg = (prductItem)ss;

                foreach (DataGridViewRow item in OrderList.Rows)
                {
                    if (item.Cells["product"].Value.ToString().Equals(wdg.Pname))
                    {
                        item.Cells["quantity"].Value = int.Parse(item.Cells["quantity"].Value.ToString()) + 1;
                        item.Cells["amount"].Value = int.Parse(item.Cells["quantity"].Value.ToString()) * float.Parse(item.Cells["price"].Value.ToString());
                        calBill();
                        return;
                    }
                }
                OrderList.Rows.Add(new object[] { wdg.Pname, 1, wdg.Price, wdg.Price });

                calBill();
            };

        }

        //For Load the food items to flowlayoutpnel 2
        public void getLoadData(DataTable data)
        {
            if (data.Rows.Count > 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    byte[] img = (byte[])(item["P_Image"]);
                    MemoryStream ms = new MemoryStream(img);
                    Image food = Image.FromStream(ms);

                    decimal dec = (decimal)item["P_Price"];
                    float price = (float)dec;

                    AddItems(item["P_ID"].ToString(), item["P_Name"].ToString(), item["P_Catergory"].ToString(), price, food);
                }
            }
            else
            {
                MessageBox.Show("Not Available any prducts");
            }
        }

        //For Manually get catergory buttons to the flowlayoutpanel1
        public void getbutton(DataTable data)
        {
            if (data.Rows.Count > 0)
            {

                foreach (DataRow rows in data.Rows)
                {
                    System.Windows.Forms.Button b = new System.Windows.Forms.Button();
                    b.Size = new Size(195, 39);
                    b.BackColor = Color.FromName("Salmon");
                    b.ForeColor = Color.FromName("ControText");

                    b.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold);
                    b.Text = rows["P_Catergory"].ToString();

                    b.Click += new EventHandler(clickbutton);



                    flowLayoutPanel1.Controls.Add(b);

                }
            }
            else
            {
                MessageBox.Show("Please insert Products");
            }
        }

        //manully add button's search bar
        private void clickbutton(object sender, EventArgs e)
        {
            System.Windows.Forms.Button b = (System.Windows.Forms.Button)sender;
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var searchitems = (prductItem)item;
                searchitems.Visible = searchitems.PCatergory.ToLower().Contains(b.Text.Trim().ToLower());
            }

        }

        //For getting all catergories
        private void button7_Click(object sender, EventArgs e)
        {
            string searchtext = "";
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var searchitems = (prductItem)item;
                searchitems.Visible = searchitems.Pname.ToLower().Contains(searchtext.Trim().ToLower());
            }
        }

        //Clear the OrderList represent items using the selections
        private void button8_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in OrderList.SelectedRows)
            {
                OrderList.Rows.RemoveAt(row.Index);
                calBill();
            }
        }

        //for Calculation of Bills
        public void calBill()
        {
            billlabel.Text = "0.00";
            double total = 0;
            foreach (DataGridViewRow item in OrderList.Rows)
            {
                total += double.Parse(item.Cells["amount"].Value.ToString());
            }
            billlabel.Text = total.ToString("N2");
        }

        //Search bar of the windows form
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel2.Controls)
            {
                var searchitems = (prductItem)item;
                searchitems.Visible = searchitems.Pname.ToLower().Contains(txtsearch.Text.Trim().ToLower());
            }
        }

        //Clear the OrderList items to new bill add
        private void button1_Click(object sender, EventArgs e)
        {
            OrderList.Rows.Clear();
        }

        //Changing the coulur when typing
        private void txtsearch_MouseEnter(object sender, EventArgs e)
        {
            if (txtsearch.Text == "Search Here......")
            {
                txtsearch.Text = "";
                txtsearch.ForeColor = Color.Black;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var orderlist = new CompanyOrderList();
            orderlist.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var payment = new payment();
            payment.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            string ordertype = db.getOrderType();

            if (ordertype != "Din In")
            {
                MessageBox.Show("This is " + ordertype + " Order!!!", "CANNOT DO THAT");
            }
            else
            {
                var table = new SelectTablecs();
                table.Show();
            }
        }

        private void OrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var db = new DBConnection();
            string type = "Din In";

            if (type == db.getOrderType().ToString())
            {
                if (db.getOrderListWaiter() == null)
                {
                    MessageBox.Show("Please Assign Waiter", "Cannot Do That");
                    return;
                }
                MessageBox.Show("Send Order to the Kitchen");
            }
            MessageBox.Show("Send Order to the Kitchen");
        }
    }
}

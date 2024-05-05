using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Resturant_Management_System
{
    public class DBConnection
    {
        SqlConnection cnn = null;
        public DBConnection()
        {
            string connectionString;
            connectionString = @"Data Source=LAPTOP-M6PAA5KK;Initial Catalog=POS_System;Integrated Security=True";
            cnn = new SqlConnection(connectionString);
        }

        public void getDataitems(string cat)
        {
            cnn.Open();
            SqlCommand cmd;
            string query = "select * from Products where P_Catergory='" + cat + "'";
            cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                byte[] img = (byte[])(item["P_Image"]);
                MemoryStream ms = new MemoryStream(img);
                Image food = Image.FromStream(ms);

                decimal dec = (decimal)item["P_Price"];
                float price = (float)dec;

                var pos = new pos_addnewform();
                pos.AddItems(item["P_ID"].ToString(), item["P_Name"].ToString(), item["P_Catergory"].ToString(), price, food);
            }


            cnn.Close();
        }

        public DataTable getcatergorytypes()
        {
            cnn.Open();
            string query = "select * from Table_Catergory";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public DataTable getstaff()
        {
            cnn.Open();
            string query = "select * from staff";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public DataTable staffsearch(String search)
        {
            cnn.Open();
            string query = $"SELECT * FROM [Staff] WHERE Sname='{search}'";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             da.Fill(dt);
            //var reader = new SqlCommand(query, cnn).ExecuteReader();
            cnn.Close();
            return dt;
        }

        public DataTable setcatergory ()
        {
            cnn.Open();
            string query = "select * from Table_Catergory";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public void addCatdata(string name)
        {
            cnn.Open();
            string query = "INSERT INTO Table_Catergory(Name) VALUES('"+name+"')";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        

        public void addstaff(string name ,string type,string contact)
        {
            cnn.Open();
            string query = "INSERT INTO staff(Sname,Stype,Sphone) VALUES('" + name + "', '" + type + "' ,'" + contact + "')";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public DataTable loggin(string name,string password)
        {
            cnn.Open();
            String query = "SELECT * FROM login WHERE username= '" + name + "' AND password ='" + password + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            cnn.Close();
            return dtable;
        }

        public DataTable FullData()
        {
            cnn.Open();
            string query = "select * from products";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }



        public DataTable addcategory()
        {
            cnn.Open();
            string sql = "select distinct P_Catergory from products";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        public DataTable getOrderlist()
        {
            cnn.Open();
            string sql = "select * from OrderList";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void SetOrderBillList(string id, string status, decimal total)
        {
            cnn.Open();
            string sql = "insert into OrderList(Order_ID,Status,Total) values ('" + id + "','" + status + "','" + total + "')";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void SetOrderBillList(string id, string type)
        {
            cnn.Open();
            string sql = "update OrderList set Order_Type = '" + type + "' where Order_ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //getting id of the bill
        public string getOrderID()
        {
            cnn.Open();
            string sql = "select Top(1) Order_ID from OrderList order by Order_ID desc";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            string id = null;
            if (dr.Read())
            {
                id = dr.GetValue(0).ToString();
                cnn.Close();
                return id;
            }
            else
            {
                cnn.Close();
                return "0";

            }
        }

      
       
            public string getOrderType()
        {
            cnn.Open();
            string sql = "select Top(1) Order_Type from OrderList order by Order_ID desc";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            string type = null;
            if (dr.Read())
            {
                type = dr.GetValue(0).ToString();
                cnn.Close();
                return type;
            }
            return type;
        }

        //For getting Booking tables

        public DataTable LoadTable()
        {
            cnn.Open();
            string sql = "select * from tables";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }

        //For adding the Table buttons

        public void addTable(string tablename, string id)
        {
            cnn.Open();
            string sql = "update OrderList set Table_Name = '" + tablename + "' where Order_ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //For getting Waiters button
        public DataTable LoadWaiters()
        {
            cnn.Open();
            string sql = "select * from Staff where Stype='Waiter'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;

        }

        //For update the OrderList Table
        public void addwaiter(string name, string id)
        {
            cnn.Open();
            string sql = "update orderlist set Waiter_Name = '" + name + "' where Order_ID = '" + id + "'";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        //For getting the orderlist waiter name
        public string getOrderListWaiter()
        {
            cnn.Open();
            string sql = "select Top(1) waiter_Name from OrderList order by Order_ID desc";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();

            string name = null;
            if (dr.Read())
            {
                name = dr.GetValue(0).ToString();
                cnn.Close();
                return name;
            }
            else
            {

                cnn.Close();
                return name;
            }
        

        }

        public void addProduct(string imglocation,string id,string name,string unitprice,string catergory)
        {
            try
            {
                byte[] images = null;
                FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(streem);
                images = brs.ReadBytes((int)streem.Length);

                cnn.Open();
                decimal price = decimal.Parse(unitprice);
                string sqlQuery = "insert into products(P_ID,P_Name,P_Price,P_Catergory,P_Image) values('" + id + "','" + name + "','" + price + "','" + catergory + "',@images)";
                SqlCommand cmd = new SqlCommand(sqlQuery, cnn);
                cmd.Parameters.Add(new SqlParameter("@images", images));
                int n = cmd.ExecuteNonQuery();
                cnn.Close();
               
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}

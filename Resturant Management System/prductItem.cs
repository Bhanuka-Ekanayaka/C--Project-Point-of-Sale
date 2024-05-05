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
    public partial class prductItem : UserControl
    {
        public prductItem()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public string Id { get; set; }

        public float Price { get; set; }

        public string PCatergory { get; set; }

        public string Pname
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public Image Pimage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void prductItem_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

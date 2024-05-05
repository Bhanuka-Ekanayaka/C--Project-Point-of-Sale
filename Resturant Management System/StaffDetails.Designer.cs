namespace Resturant_Management_System
{
    partial class StaffDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDetails));
            this.StaffGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.spanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.staffimg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.searchbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.AddStaffBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).BeginInit();
            this.spanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffimg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffGrid
            // 
            this.StaffGrid.AllowUserToAddRows = false;
            this.StaffGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.StaffGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StaffGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StaffGrid.ColumnHeadersHeight = 18;
            this.StaffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sid,
            this.Sname,
            this.Stype,
            this.Sphone});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StaffGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.StaffGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGrid.Location = new System.Drawing.Point(223, 201);
            this.StaffGrid.Name = "StaffGrid";
            this.StaffGrid.ReadOnly = true;
            this.StaffGrid.RowHeadersVisible = false;
            this.StaffGrid.RowHeadersWidth = 51;
            this.StaffGrid.RowTemplate.Height = 24;
            this.StaffGrid.Size = new System.Drawing.Size(711, 324);
            this.StaffGrid.TabIndex = 11;
            this.StaffGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StaffGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StaffGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StaffGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StaffGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StaffGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StaffGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StaffGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StaffGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StaffGrid.ThemeStyle.HeaderStyle.Height = 18;
            this.StaffGrid.ThemeStyle.ReadOnly = true;
            this.StaffGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StaffGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StaffGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGrid.ThemeStyle.RowsStyle.Height = 24;
            this.StaffGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StaffGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StaffGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffGrid_CellContentClick);
            // 
            // Sid
            // 
            this.Sid.HeaderText = "SID";
            this.Sid.MinimumWidth = 6;
            this.Sid.Name = "Sid";
            this.Sid.ReadOnly = true;
            // 
            // Sname
            // 
            this.Sname.HeaderText = "Name";
            this.Sname.MinimumWidth = 6;
            this.Sname.Name = "Sname";
            this.Sname.ReadOnly = true;
            // 
            // Stype
            // 
            this.Stype.HeaderText = "Type";
            this.Stype.MinimumWidth = 6;
            this.Stype.Name = "Stype";
            this.Stype.ReadOnly = true;
            // 
            // Sphone
            // 
            this.Sphone.HeaderText = "Contact";
            this.Sphone.MinimumWidth = 6;
            this.Sphone.Name = "Sphone";
            this.Sphone.ReadOnly = true;
            // 
            // searchtxt
            // 
            this.searchtxt.AutoRoundedCorners = true;
            this.searchtxt.BorderRadius = 15;
            this.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtxt.DefaultText = "";
            this.searchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchtxt.Location = new System.Drawing.Point(667, 136);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.PlaceholderText = "Enter Name";
            this.searchtxt.SelectedText = "";
            this.searchtxt.Size = new System.Drawing.Size(229, 32);
            this.searchtxt.TabIndex = 9;
            // 
            // spanel
            // 
            this.spanel.Controls.Add(this.label2);
            this.spanel.Controls.Add(this.staffimg);
            this.spanel.Location = new System.Drawing.Point(209, 0);
            this.spanel.Name = "spanel";
            this.spanel.Size = new System.Drawing.Size(725, 100);
            this.spanel.TabIndex = 8;
            this.spanel.Paint += new System.Windows.Forms.PaintEventHandler(this.spanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff Details";
            // 
            // staffimg
            // 
            this.staffimg.BackColor = System.Drawing.Color.Transparent;
            this.staffimg.Image = ((System.Drawing.Image)(resources.GetObject("staffimg.Image")));
            this.staffimg.ImageRotate = 0F;
            this.staffimg.Location = new System.Drawing.Point(7, 12);
            this.staffimg.Name = "staffimg";
            this.staffimg.Size = new System.Drawing.Size(80, 81);
            this.staffimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffimg.TabIndex = 0;
            this.staffimg.TabStop = false;
            this.staffimg.UseTransparentBackground = true;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.searchbtn.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.searchbtn.ImageRotate = 0F;
            this.searchbtn.ImageSize = new System.Drawing.Size(25, 25);
            this.searchbtn.Location = new System.Drawing.Point(902, 136);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.searchbtn.Size = new System.Drawing.Size(32, 32);
            this.searchbtn.TabIndex = 12;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // AddStaffBtn
            // 
            this.AddStaffBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddStaffBtn.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddStaffBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddStaffBtn.Image")));
            this.AddStaffBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.AddStaffBtn.ImageRotate = 0F;
            this.AddStaffBtn.Location = new System.Drawing.Point(238, 136);
            this.AddStaffBtn.Name = "AddStaffBtn";
            this.AddStaffBtn.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.AddStaffBtn.Size = new System.Drawing.Size(32, 32);
            this.AddStaffBtn.TabIndex = 10;
            this.AddStaffBtn.Click += new System.EventHandler(this.AddStaffBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 537);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Resturant_Management_System.Properties.Resources.pos_logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(7, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 188);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(43, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.StaffGrid);
            this.Controls.Add(this.AddStaffBtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.spanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDetails";
            this.Load += new System.EventHandler(this.StaffDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffGrid)).EndInit();
            this.spanel.ResumeLayout(false);
            this.spanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffimg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton searchbtn;
        private Guna.UI2.WinForms.Guna2DataGridView StaffGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sphone;
        private Guna.UI2.WinForms.Guna2ImageButton AddStaffBtn;
        private Guna.UI2.WinForms.Guna2TextBox searchtxt;
        private Guna.UI2.WinForms.Guna2Panel spanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox staffimg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}
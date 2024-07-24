namespace The_Goate
{
    partial class My_Shop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(My_Shop));
            this.lab_Phones = new System.Windows.Forms.Label();
            this.lab_Used_Phones = new System.Windows.Forms.Label();
            this.lab_More_Items = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_User_Name = new System.Windows.Forms.Label();
            this.lab_Shop_name = new System.Windows.Forms.Label();
            this.Panl_MyShop_panel = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Phones
            // 
            this.lab_Phones.AutoSize = true;
            this.lab_Phones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_Phones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Phones.ForeColor = System.Drawing.Color.White;
            this.lab_Phones.Location = new System.Drawing.Point(76, 184);
            this.lab_Phones.Name = "lab_Phones";
            this.lab_Phones.Size = new System.Drawing.Size(74, 21);
            this.lab_Phones.TabIndex = 0;
            this.lab_Phones.Text = "Phones";
            this.lab_Phones.Click += new System.EventHandler(this.lab_Phones_Click);
            // 
            // lab_Used_Phones
            // 
            this.lab_Used_Phones.AutoSize = true;
            this.lab_Used_Phones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_Used_Phones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Used_Phones.ForeColor = System.Drawing.Color.White;
            this.lab_Used_Phones.Location = new System.Drawing.Point(285, 184);
            this.lab_Used_Phones.Name = "lab_Used_Phones";
            this.lab_Used_Phones.Size = new System.Drawing.Size(122, 21);
            this.lab_Used_Phones.TabIndex = 1;
            this.lab_Used_Phones.Text = "Used Phones";
            this.lab_Used_Phones.Click += new System.EventHandler(this.lab_Used_Phones_Click);
            // 
            // lab_More_Items
            // 
            this.lab_More_Items.AutoSize = true;
            this.lab_More_Items.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_More_Items.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_More_Items.ForeColor = System.Drawing.Color.White;
            this.lab_More_Items.Location = new System.Drawing.Point(529, 184);
            this.lab_More_Items.Name = "lab_More_Items";
            this.lab_More_Items.Size = new System.Drawing.Size(109, 21);
            this.lab_More_Items.TabIndex = 2;
            this.lab_More_Items.Text = "More Items";
            this.lab_More_Items.Click += new System.EventHandler(this.lab_More_Items_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 2);
            this.panel1.TabIndex = 3;
            // 
            // lab_User_Name
            // 
            this.lab_User_Name.AutoSize = true;
            this.lab_User_Name.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_User_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lab_User_Name.Location = new System.Drawing.Point(309, 139);
            this.lab_User_Name.Name = "lab_User_Name";
            this.lab_User_Name.Size = new System.Drawing.Size(77, 17);
            this.lab_User_Name.TabIndex = 7;
            this.lab_User_Name.Text = "User Name";
            // 
            // lab_Shop_name
            // 
            this.lab_Shop_name.AutoSize = true;
            this.lab_Shop_name.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Shop_name.ForeColor = System.Drawing.Color.White;
            this.lab_Shop_name.Location = new System.Drawing.Point(296, 108);
            this.lab_Shop_name.Name = "lab_Shop_name";
            this.lab_Shop_name.Size = new System.Drawing.Size(113, 21);
            this.lab_Shop_name.TabIndex = 6;
            this.lab_Shop_name.Text = "Shop Name";
            // 
            // Panl_MyShop_panel
            // 
            this.Panl_MyShop_panel.AutoScroll = true;
            this.Panl_MyShop_panel.BackColor = System.Drawing.Color.Transparent;
            this.Panl_MyShop_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panl_MyShop_panel.BackgroundImage")));
            this.Panl_MyShop_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panl_MyShop_panel.BorderRadius = 1;
            this.Panl_MyShop_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panl_MyShop_panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Panl_MyShop_panel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Panl_MyShop_panel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Panl_MyShop_panel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Panl_MyShop_panel.Location = new System.Drawing.Point(0, 374);
            this.Panl_MyShop_panel.Name = "Panl_MyShop_panel";
            this.Panl_MyShop_panel.Quality = 10;
            this.Panl_MyShop_panel.Size = new System.Drawing.Size(733, 319);
            this.Panl_MyShop_panel.TabIndex = 8;
            // 
            // pic_profile
            // 
            this.pic_profile.Image = global::The_Goate.Properties.Resources.user__1_;
            this.pic_profile.Location = new System.Drawing.Point(290, 17);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(119, 77);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_profile.TabIndex = 5;
            this.pic_profile.TabStop = false;
            // 
            // My_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(733, 693);
            this.ControlBox = false;
            this.Controls.Add(this.Panl_MyShop_panel);
            this.Controls.Add(this.lab_User_Name);
            this.Controls.Add(this.lab_Shop_name);
            this.Controls.Add(this.pic_profile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lab_More_Items);
            this.Controls.Add(this.lab_Used_Phones);
            this.Controls.Add(this.lab_Phones);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "My_Shop";
            this.Load += new System.EventHandler(this.My_Shop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Phones;
        private System.Windows.Forms.Label lab_Used_Phones;
        private System.Windows.Forms.Label lab_More_Items;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_User_Name;
        private System.Windows.Forms.Label lab_Shop_name;
        private System.Windows.Forms.PictureBox pic_profile;
        private Bunifu.UI.WinForms.BunifuGradientPanel Panl_MyShop_panel;
    }
}
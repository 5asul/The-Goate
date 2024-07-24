using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Goate
{
    public partial class My_Shop : Form
    {
        public My_Shop()
        {
            InitializeComponent();

            this.Panl_MyShop_panel.Controls.Clear();
            Phones my_shop_Load = new Phones() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panl_MyShop_panel.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_Phones.ForeColor = Color.FromArgb(0,156,149);
            lab_Used_Phones.ForeColor = Color.White;
            lab_More_Items.ForeColor = Color.White;
        }

        private void My_Shop_Load(object sender, EventArgs e)
        {

        }


        private void lab_Phones_Click(object sender, EventArgs e)
        {
            this.Panl_MyShop_panel.Controls.Clear();
            Phones my_shop_Load = new Phones() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panl_MyShop_panel.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_Phones.ForeColor = Color.FromArgb(0, 156, 149);
            lab_Used_Phones.ForeColor = Color.White;
            lab_More_Items.ForeColor = Color.White;
        }

        private void lab_Used_Phones_Click(object sender, EventArgs e)
        {
            this.Panl_MyShop_panel.Controls.Clear();
            User_Phones my_shop_Load = new User_Phones() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panl_MyShop_panel.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_Phones.ForeColor = Color.White;
            lab_Used_Phones.ForeColor = Color.FromArgb(0, 156, 149);
            lab_More_Items.ForeColor = Color.White;
        }

        private void lab_More_Items_Click(object sender, EventArgs e)
        {
            this.Panl_MyShop_panel.Controls.Clear();
            More_Items my_shop_Load = new More_Items() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panl_MyShop_panel.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_Phones.ForeColor = Color.White;
            lab_Used_Phones.ForeColor = Color.White;
            lab_More_Items.ForeColor = Color.FromArgb(0, 156, 149);
        }


    }
}

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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            this.Panel_Home.Controls.Clear();
            My_Shop my_shop_Load = new My_Shop() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();
        }

        private void btn_My_Shope_Click(object sender, EventArgs e)
        {
            this.Panel_Home.Controls.Clear();
            My_Shop my_shop_Load = new My_Shop() { Dock = DockStyle.Fill , TopLevel = false , TopMost = true};
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();
        }

        private void btn_Shops_Click(object sender, EventArgs e)
        {
            this.Panel_Home.Controls.Clear();
            Shops my_shop_Load = new Shops() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {

            this.Panel_Home.Controls.Clear();
            Reports my_shop_Load = new Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

        }

        private void btn_About_us_Click(object sender, EventArgs e)
        {
            this.Panel_Home.Controls.Clear();
            About_us my_shop_Load = new About_us() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Home.Controls.Add(my_shop_Load);
            my_shop_Load.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Panel_Home_Click(object sender, EventArgs e)
        {

        }
    }
}

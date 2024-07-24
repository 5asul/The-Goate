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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

        }

        private void Reports_Load(object sender, EventArgs e)
        {

            this.Panel_Report.Controls.Clear();
            File_Report my_shop_Load = new File_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Report.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_File_Report.ForeColor = Color.FromArgb(0, 156, 149);
            lab_View_Reports.ForeColor = Color.White;
            lab_Search_Report.ForeColor = Color.White;

        }

        private void lab_File_Report_Click(object sender, EventArgs e)
        {
            this.Panel_Report.Controls.Clear();
            File_Report my_shop_Load = new File_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Report.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_File_Report.ForeColor = Color.FromArgb(0, 156, 149);
            lab_View_Reports.ForeColor = Color.White;
            lab_Search_Report.ForeColor = Color.White;
        }

        private void lab_View_Reports_Click(object sender, EventArgs e)
        {

            this.Panel_Report.Controls.Clear();
            View_Reports my_shop_Load = new View_Reports() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Report.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_File_Report.ForeColor = Color.White;
            lab_View_Reports.ForeColor = Color.FromArgb(0, 156, 149);
            lab_Search_Report.ForeColor = Color.White;

        }

        private void lab_Search_Report_Click(object sender, EventArgs e)
        {

            this.Panel_Report.Controls.Clear();
            Search_Report my_shop_Load = new Search_Report() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.Panel_Report.Controls.Add(my_shop_Load);
            my_shop_Load.Show();

            lab_File_Report.ForeColor = Color.White;
            lab_View_Reports.ForeColor = Color.White;
            lab_Search_Report.ForeColor = Color.FromArgb(0, 156, 149);

        }
    }
}

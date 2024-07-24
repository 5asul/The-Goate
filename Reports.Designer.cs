namespace The_Goate
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_Search_Report = new System.Windows.Forms.Label();
            this.lab_View_Reports = new System.Windows.Forms.Label();
            this.lab_File_Report = new System.Windows.Forms.Label();
            this.Panel_Report = new Bunifu.UI.WinForms.BunifuPanel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(48, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 2);
            this.panel1.TabIndex = 7;
            // 
            // lab_Search_Report
            // 
            this.lab_Search_Report.AutoSize = true;
            this.lab_Search_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_Search_Report.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Search_Report.ForeColor = System.Drawing.Color.White;
            this.lab_Search_Report.Location = new System.Drawing.Point(606, 38);
            this.lab_Search_Report.Name = "lab_Search_Report";
            this.lab_Search_Report.Size = new System.Drawing.Size(71, 21);
            this.lab_Search_Report.TabIndex = 6;
            this.lab_Search_Report.Text = "Search";
            this.lab_Search_Report.Click += new System.EventHandler(this.lab_Search_Report_Click);
            // 
            // lab_View_Reports
            // 
            this.lab_View_Reports.AutoSize = true;
            this.lab_View_Reports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_View_Reports.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_View_Reports.ForeColor = System.Drawing.Color.White;
            this.lab_View_Reports.Location = new System.Drawing.Point(347, 38);
            this.lab_View_Reports.Name = "lab_View_Reports";
            this.lab_View_Reports.Size = new System.Drawing.Size(125, 21);
            this.lab_View_Reports.TabIndex = 5;
            this.lab_View_Reports.Text = "View Reports";
            this.lab_View_Reports.Click += new System.EventHandler(this.lab_View_Reports_Click);
            // 
            // lab_File_Report
            // 
            this.lab_File_Report.AutoSize = true;
            this.lab_File_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_File_Report.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_File_Report.ForeColor = System.Drawing.Color.White;
            this.lab_File_Report.Location = new System.Drawing.Point(106, 38);
            this.lab_File_Report.Name = "lab_File_Report";
            this.lab_File_Report.Size = new System.Drawing.Size(101, 21);
            this.lab_File_Report.TabIndex = 4;
            this.lab_File_Report.Text = "File Report";
            this.lab_File_Report.Click += new System.EventHandler(this.lab_File_Report_Click);
            // 
            // Panel_Report
            // 
            this.Panel_Report.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Panel_Report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Report.BackgroundImage")));
            this.Panel_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel_Report.BorderColor = System.Drawing.Color.Transparent;
            this.Panel_Report.BorderRadius = 3;
            this.Panel_Report.BorderThickness = 1;
            this.Panel_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Report.Location = new System.Drawing.Point(0, 101);
            this.Panel_Report.Name = "Panel_Report";
            this.Panel_Report.ShowBorders = true;
            this.Panel_Report.Size = new System.Drawing.Size(782, 592);
            this.Panel_Report.TabIndex = 8;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(782, 693);
            this.Controls.Add(this.Panel_Report);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lab_Search_Report);
            this.Controls.Add(this.lab_View_Reports);
            this.Controls.Add(this.lab_File_Report);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lab_Search_Report;
        private System.Windows.Forms.Label lab_View_Reports;
        private System.Windows.Forms.Label lab_File_Report;
        private Bunifu.UI.WinForms.BunifuPanel Panel_Report;
    }
}
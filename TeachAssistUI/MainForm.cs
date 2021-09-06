using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeachAssistUI.Forms;

namespace TeachAssistUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddTiWenMenuItem();
            OpenShangkeDianming();
        }

        void AddTiWenMenuItem()
        {
            var pic = new PictureBox();
            pic.Dock = DockStyle.Fill;
            pic.Image = TeachAssistUI.Properties.Resources.TiWen;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            this.tableLayoutPanel1.Controls.Add(pic, 0, 3);

            var btn = new Button();
            btn.Text = "上课提问";
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Dock = DockStyle.Fill;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Click += (s, e) =>
            {
                AddFormToPanel(new TiWenForm());
                this.toolStripStatusLabel2.Text = "[上课提问]";
            };

            this.tableLayoutPanel1.Controls.Add(btn, 1, 3);
        }

        private void 软件说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本功能，尚未开发，请等待 :)");
        }

        void AddFormToPanel(Form form)
        {
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.splitContainer1.Panel2.Controls.Clear();
            this.splitContainer1.Panel2.Controls.Add(form);
            this.ActiveControl = form;
        }

        void OpenShangkeDianming()
        {
            AddFormToPanel(new RollcallForm());
            this.toolStripStatusLabel2.Text = "[上课点名]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenShangkeDianming();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new KaoShiForm());
            this.toolStripStatusLabel2.Text = "[模拟考试]";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new StudentManageForm());
            this.toolStripStatusLabel2.Text = "[学生管理]";
        }
    }
}






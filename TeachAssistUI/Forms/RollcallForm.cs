using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;

namespace TeachAssistUI
{
    public partial class RollcallForm : Form
    {
        List<string> names;
        string studentListFile = @"e:\aaa.txt";

        public RollcallForm()
        {
            InitializeComponent();
            InitStudents();
            InitFileShow();
        }

        void InitStudents()
        {
            var students = GetNamesFromFile(studentListFile);

            // 列表
            names = ShufferNames(students);
            this.lbPresents.DataSource = names;
            this.lbPresents.SelectedIndex = -1;
            this.lbPresents.ItemHeight = 12;
            this.lbPresents.Height = this.lbPresents.PreferredHeight;

            // 请假的
            this.lbAbsents.DataSource = students
                .Where(n => n.StartsWith("--"))
                .Select(n => n.Substring(2))
                .ToList();
            this.lbAbsents.SelectedIndex = -1;
            this.lbAbsents.ForeColor = Color.Gray;
            this.lbPresents.ItemHeight = 12;
            this.lbAbsents.Height = this.lbAbsents.PreferredHeight;
        }

        void InitFileShow()
        {
            this.buttonFileinfo.Text = studentListFile;
            var tip = new ToolTip();
            tip.SetToolTip(this.buttonFileinfo, studentListFile);
        }

        List<string> GetNamesFromFile (string file)
        {
            return File.ReadAllLines(file).ToList();
        }

        List<string> ShufferNames (List<string> names)
        {
            var r = new Random();
            return names
                .Where(name => !string.IsNullOrEmpty(name) && name[0] != '-')
                .OrderBy(item => r.Next())
                .ToList();
        }

        void Speak(string content)
        {
            var speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Volume = 100;
            speechSynthesizer.SpeakAsync(content);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    if (lbPresents.SelectedIndex < names.Count - 1)
                    {
                        lbPresents.SelectedIndex += 1;
                        Speak(lbPresents.SelectedItem.ToString());
                    }
                    else
                    {
                        // 通过 Edge 浏览器，打开学校的学生管理系统首页
                        Process.Start("explorer.exe", "http://10.10.11.201/");
                    }
                    return true;
                case Keys.Space:
                    Speak(lbPresents.SelectedItem.ToString());
                    return true;
                case Keys.Back:
                    {
                        string name = lbPresents.SelectedItem.ToString();
                        if (!flowLayoutPanel1.Controls.Cast<Control>().Any(c => c.Text == name))
                        {
                            var lb = new Label
                            {
                                Text = name,
                                Width = 45
                            };
                            lb.Click += (s, args) =>
                            {
                                flowLayoutPanel1.Controls.Remove(s as Label);
                            };
                            flowLayoutPanel1.Controls.Add(lb);
                        }

                        return true;
                    }
                case Keys.Escape:
                    this.flowLayoutPanel1.Controls.Clear();
                    this.lbPresents.SelectedIndex = -1;
                    this.lbAbsents.SelectedIndex = -1;
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void lbPresents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbPresents.SelectedItems.Count == 1)
            {
                string name = (string)this.lbPresents.SelectedItem;
                var imgList = new Image[]
                {
                    Properties.Resources.d1,
                    Properties.MyGod.d2,
                    Properties.MyGod.d3,
                    Properties.MyGod.d4,
                };
                Image img = imgList[new Random().Next(imgList.Length)];
                this.pictureBox1.Image = img;
                this.label1.Text = name;
                this.label2.Text = "1999-12-12";
            }
            else
            {
                this.pictureBox1.Image = null;
                this.label1.Text = "";
                this.label2.Text = "";
            }
        }
       
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad", studentListFile);
        }
        
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"e:\";
            dialog.Filter = "文本文档|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                studentListFile = dialog.FileName;
                InitStudents();
                InitFileShow();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            InitStudents();
        }
    }
}

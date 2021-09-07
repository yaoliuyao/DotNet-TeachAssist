using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachAssistUI.Forms
{
    public partial class StudentManageForm : Form
    {

        StudentBLL bll = new StudentBLL();
        BindingSource bs = new BindingSource();

        public StudentManageForm()
        {
            InitializeComponent();

            InitDataGrid();
            InitInputForm();
        }

        void InitDataGrid()
        {
            this.dvStudents.AllowUserToAddRows = false;
            this.dvStudents.AllowUserToDeleteRows = false;
            this.dvStudents.EditMode = DataGridViewEditMode.EditProgrammatically;

            var students = bll.GetAllStudent();
            bs.DataSource = students;
            this.dvStudents.DataSource = bs;
        }

        void InitInputForm()
        {
            foreach (Control c in this.panelBottom.Controls)
            {
                var cc = c as TextBox;
                if (cc != null)
                {
                    cc.Clear();
                }
            }
            tbId.ReadOnly = false;
            tbName.ReadOnly = false;
            this.panelBottom.Visible = false;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            InitInputForm();
            btSave.Text = "保存新增";
            this.panelBottom.Visible = true;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            InitInputForm();
            if (dvStudents.SelectedRows.Count != 1)
            {
                MessageBox.Show("请您先选中一行，然后再进行操作");
            }
            else
            {
                var cells = dvStudents.SelectedRows[0].Cells;
                tbId.Text = cells[0].Value.ToString();
                tbName.Text = cells[1].Value.ToString();
                tbHc.Text = cells[2].Value.ToString();
                tbTel.Text = cells[3].Value.ToString();
                tbState.Text = cells[4].Value.ToString();

                tbId.ReadOnly = true;
                tbName.ReadOnly = true;

                btSave.Text = "保存更新";

                this.panelBottom.Visible = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // 首先需要验证
            try
            {
                if (btSave.Text == "保存新增")
                {
                    bll.SaveAdd(new Student()
                    {
                        Id = tbId.Text,
                        Name = tbName.Text,
                        Homecity = tbHc.Text,
                        Telephone = tbTel.Text,
                        State = int.Parse(tbState.Text)
                    });
                    MessageBox.Show("添加成功");
                }
                else if (btSave.Text == "保存更新")
                {
                    bll.SaveUpdate(new Student()
                    {
                        Id = tbId.Text,
                        Name = tbName.Text,
                        Homecity = tbHc.Text,
                        Telephone = tbTel.Text,
                        State = int.Parse(tbState.Text)
                    });
                    MessageBox.Show("更新成功");
                }

                bs.DataSource = bll.GetAllStudent();
                InitInputForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败，原因是: {ex.Message}");
            }
        }
    }
}

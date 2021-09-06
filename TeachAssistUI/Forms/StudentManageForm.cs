using BLL;
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
        public StudentManageForm()
        {
            InitializeComponent();

            InitDataGrid();
        }

        void InitDataGrid()
        {
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            var bll = new StudentBLL();
            var bs = new BindingSource { DataSource = bll.GetAllNormalStudents() };
            this.dataGridView1.DataSource = bs;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YALIMS.Model;

namespace YALIMS
{
    public partial class Add_marks : Form
    {
        string SelectedStudentID;
        public Add_marks()
        {
            InitializeComponent();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            UserFacade.AddMark(com_coursetype.Text,txt_level.Text,SelectedStudentID,txt_marks.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_marks_Load(object sender, EventArgs e)
        {
            DataGridView_mangstudents.DataSource = UserFacade.AllStudents();
            if (UserDetails.role == "Teacher")
            {   
                label5.Visible = false;
                label10.Visible = false;
                com_coursetype.Visible = false;
                txt_level.Visible = false;
            }
        }
        int course = 0;
        private void DataGridView_mangstudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedStudentID = DataGridView_mangstudents.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txt_level.Text = DataGridView_mangstudents.Rows[e.RowIndex].Cells["Level"].Value.ToString();
                course = Int32.Parse(DataGridView_mangstudents.Rows[e.RowIndex].Cells["Course"].Value.ToString());
                com_coursetype.Text = UserDetails.CourseTypeString(course);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_level.Text = "";
            txt_marks.Text = "";
            com_coursetype.Text = "";
        }
    }
}
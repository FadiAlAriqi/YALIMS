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
    public partial class New_teacher : Form
    {
        public New_teacher()
        {
            InitializeComponent();
        }

        private void New_teacher_Load(object sender, EventArgs e)
        {

        }
        DataTable? newTeachers = new DataTable();
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (UserFacade.AddTeacher(
                txt_name.Text,
                txt_username.Text,
                txt_password.Text,
                txt_email.Text,
                txt_mobile.Text,
                txt_salary.Text
                ))
            {
                newTeachers.Merge(Teacher.Find(txt_username.Text));
                DataGridView_teachers.DataSource = newTeachers;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Text = "";
            txt_salary.Text = "";
            txt_password.Text = "";
            txt_name.Text = "";
            txt_mobile.Text = "";
            txt_email.Text = "";
        }
    }
}

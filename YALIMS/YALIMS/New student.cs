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
    public partial class Newstudent : Form
    {
       // Studentclass student = new Studentclass();

        public Newstudent()
        {
            InitializeComponent();
        }

        private void Newstudent_Load(object sender, EventArgs e)
        {
            newStudents.Clear();
        }
        DataTable? newStudents = new DataTable();
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (UserFacade.AddStudent(
                txt_name.Text,
                txt_username.Text,
                txt_password.Text,
                txt_email.Text,
                txt_mobile.Text,
                txt_level.Text,
                com_time.Text,
                com_coursetype.Text,
                datetime_birthdate.Value
                ))
            {
                newStudents.Merge(Student.Find(txt_username.Text));
                DataGridView_students.DataSource = newStudents;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_username.Text = "";
            txt_password.Text = "";
            txt_email.Text = "";
            txt_mobile.Text = "";
            txt_level.Text = "";
            com_time.Text = "";
            com_coursetype.Text = "";
            datetime_birthdate.Value = new DateTime(2000,1,1);
        }
    }
}

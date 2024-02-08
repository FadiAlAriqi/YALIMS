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
    public partial class Student_Register : Form
    {
        public Student_Register()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            UserFacade.AddStudent(
                txt_name.Text,
                txt_username.Text,
                txt_password.Text,
                txt_email.Text,
                txt_phonenumber.Text,
                txt_level.Text,
                com_time.Text,
                com_coursetype.Text,
                datetime_birthdate.Value
                );
            SelectLogin login = new SelectLogin();
            this.Hide();
            login.Show();
            this.Close();
        }
    }
}

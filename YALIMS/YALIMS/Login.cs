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
    public partial class LoginStudent : Form
    {
        public LoginStudent()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable? userdata = UserFacade.LoginStudent(txt_usrname.Text);
            if (userdata != null && userdata.Rows.Count > 0)
            {
                UserDetails.AuthorizeUser(txt_password.Text, userdata, this, new StudentDashbord());
            }
            else
            {
                MessageBox.Show("password or Username are wrong!", "Warning!");
            }
        }

        private void linkLabel_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Student_Register newstudent = new Student_Register();
            this.Hide();
            newstudent.ShowDialog();
            this.Close();
        }
    }
}

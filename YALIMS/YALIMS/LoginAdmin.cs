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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable userdata = UserFacade.LoginAdmin(txt_usrname.Text);
            if (userdata != null && userdata.Rows.Count > 0)
            {
                UserDetails.AuthorizeUser(txt_password.Text, userdata, this, new admin_dashbord());
            }
            else 
            {
                userdata = UserFacade.LoginTeacher(txt_usrname.Text);
                if (userdata != null && userdata.Rows.Count > 0)
                {
                    UserDetails.AuthorizeUser(txt_password.Text, userdata, this, new TeacherDashbord());
                }
                else
                {
                    MessageBox.Show("password or Username are wrong!", "Warning!");
                }
            }
        }
    }
}

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
    public partial class SelectLogin : Form
    {
        public SelectLogin()
        {
            InitializeComponent();
        }

        private void pic_student_Click(object sender, EventArgs e)
        {
            LoginStudent loginStudent = new LoginStudent();
            this.Hide();
            loginStudent.ShowDialog();
            this.Close();
        }

        private void pic_admin_Click(object sender, EventArgs e)
        {
            LoginAdmin loginadmin = new LoginAdmin();
            this.Hide();
            loginadmin.ShowDialog();
            this.Close();
        }
    }
}

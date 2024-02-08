using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YALIMS
{
    public partial class admin_dashbord : Form
    {
        public admin_dashbord()
        {
            InitializeComponent();
            hidemenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_name.Text = UserDetails.username;
            label_role.Text = UserDetails.role;
        }

        private void hidemenu()
        {
            pnl_usersmenu.Visible = false;
            pnl_teachersmenu.Visible = false;
            pnl_studentsmenu.Visible = false;
            pnl_marksmenu.Visible = false;
        }

        private void showmenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidemenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            showmenu(pnl_usersmenu);
        }

        #region usersmenu
        private void btn_newuser_Click(object sender, EventArgs e)
        {
            openChildForm(new New_user());
            hidemenu();
        }

        private void btn_manageusers_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_users());
            hidemenu();
        }
        #endregion 

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            showmenu(pnl_teachersmenu);
        }

        #region teachersmenu
        private void btn_newteacher_Click(object sender, EventArgs e)
        {
            openChildForm(new New_teacher());
            hidemenu();
        }

        private void btn_manageteachers_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_teachers());
            hidemenu();
        }
        #endregion 

        private void btn_students_Click(object sender, EventArgs e)
        {
            showmenu(pnl_studentsmenu);
        }

        #region studentsmenu
        private void btn_newstudent_Click(object sender, EventArgs e)
        {
            openChildForm(new Newstudent());
            hidemenu();
        }

        private void btn_managestudents_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage_students());
            hidemenu();
        }
        #endregion 

        private void btn_marks_Click(object sender, EventArgs e)
        {
            showmenu(pnl_marksmenu);
        }

        #region marksmenu
        private void btn_addmark_Click(object sender, EventArgs e)
        {
             openChildForm(new Add_marks());
            hidemenu();
        }

        private void btn_managemarks_Click(object sender, EventArgs e)
        {
           openChildForm(new Manage_marks());
            hidemenu();
        }

        #endregion

        private void openChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

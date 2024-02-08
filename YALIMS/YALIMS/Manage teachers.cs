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
    public partial class Manage_teachers : Form
    {
        int SelectedTeacherID;
        public Manage_teachers()
        {
            InitializeComponent();
        }
        bool active;
        private void toggleBtnEnabled()
        {
            btn_active.Enabled = true;
            btn_active.BackColor = active ? Color.Orange : Color.Blue;
            btn_delete.Enabled = true;
            btn_delete.BackColor = Color.Red;
            btn_update.Enabled = true;
            btn_update.BackColor = Color.Green;
        }
        private void toggleBtnDisabled()
        {
            btn_active.Enabled = false;
            btn_active.BackColor = Color.Gray;
            btn_delete.Enabled = false;
            btn_delete.BackColor = Color.Gray;
            btn_update.Enabled = false;
            btn_update.BackColor = Color.Gray;
        }

        private void Manage_teachers_Load(object sender, EventArgs e)
        {
            DataGridView_mangteachers.DataSource = UserFacade.AllTeachers();
            toggleBtnDisabled();
        }
        string username;

        private void DataGridView_mangteachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_username.Text = DataGridView_mangteachers.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txt_mobile.Text = DataGridView_mangteachers.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txt_password.Text = DataGridView_mangteachers.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txt_email.Text = DataGridView_mangteachers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txt_salary.Text = DataGridView_mangteachers.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
                txt_name.Text = DataGridView_mangteachers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                SelectedTeacherID = Int32.Parse(DataGridView_mangteachers.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                username = txt_username.Text;
                active = DataGridView_mangteachers.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "1" ? true : false;
                btn_active.Text = active ? "Unactivate" : "Activate";
                toggleBtnEnabled();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UserFacade.UpdateTeacher(
                SelectedTeacherID,
                txt_name.Text,
                txt_username.Text,
                txt_password.Text,
                txt_email.Text,
                txt_salary.Text,
                txt_mobile.Text);
            Manage_teachers_Load(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            UserFacade.DeleteTeacher(username);
            Manage_teachers_Load(sender, e);
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            UserFacade.ActivateTeacher(username);
            Manage_teachers_Load(sender, e);
        }
    }
}

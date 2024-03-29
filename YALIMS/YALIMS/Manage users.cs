﻿namespace YALIMS
{
    public partial class Manage_users : Form
    {

        public Manage_users()
        {
            InitializeComponent();
        }
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
        private void Manage_users_Load(object sender, EventArgs e)
        {
            DataGridView_users.DataSource = UserFacade.AllAdmins();
            toggleBtnDisabled();
            DataGridView_users.ClearSelection();
        }
        int id;
        string username;
        bool passFlag;
        bool active;
        private void DataGridView_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                username = DataGridView_users.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txt_username.Text = username;
                txt_mobile.Text = DataGridView_users.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txt_password.Text = DataGridView_users.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txt_email.Text = DataGridView_users.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                id = Int32.Parse(DataGridView_users.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                active = DataGridView_users.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "1" ? true : false;
                btn_active.Text = active ? "Unactivate" : "Activate";
                toggleBtnEnabled();
                passFlag = false;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UserFacade.UpdateAdmin(
                id,
                txt_username.Text,
                passFlag ? txt_password.Text : "",
                txt_email.Text,
                txt_mobile.Text
                );
            Manage_users_Load(sender, e);
            passFlag = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            UserFacade.DeleteAdmin(id);
            Manage_users_Load(sender, e);
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            UserFacade.ActivateAdmin(username);
            Manage_users_Load(sender, e);
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            passFlag = true;
        }
    }
}

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
    public partial class New_user : Form
    {
        public New_user()
        {
            InitializeComponent();
        }
        DataTable? newAdmins = new DataTable();
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (UserFacade.AddAdmin(
                txt_username.Text,
                txt_password.Text,
                txt_mobile.Text,
                txt_email.Text
                ))
            {
                newAdmins.Merge(Admin.Find(txt_username.Text));
                DataGridView_users.DataSource = newAdmins;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_mobile.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
        }
    }
}

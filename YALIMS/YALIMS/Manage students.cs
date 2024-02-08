namespace YALIMS
{
    public partial class Manage_students : Form
    {
        int SelectedStudentID;
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

        public Manage_students()
        {
            InitializeComponent();
        }

        private void Manage_students_Load(object sender, EventArgs e)
        {
            DataGridView_mangstudents.DataSource = UserFacade.AllStudents();
            toggleBtnDisabled();
        }

        private void add_mark_Click(object sender, EventArgs e)
        {
            Add_marks mark = new Add_marks();
            mark.ShowDialog();
        }

        int course = 0;
        string username;
        private void DataGridView_mangstudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                username = DataGridView_mangstudents.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txt_username.Text = username;
                txt_mobile.Text = DataGridView_mangstudents.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txt_password.Text = DataGridView_mangstudents.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                txt_email.Text = DataGridView_mangstudents.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txt_name.Text = DataGridView_mangstudents.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txt_level.Text = DataGridView_mangstudents.Rows[e.RowIndex].Cells["Level"].Value.ToString();
                course = Int32.Parse(DataGridView_mangstudents.Rows[e.RowIndex].Cells["Course"].Value.ToString());
                com_coursetype.Text = UserDetails.CourseTypeString(course);
                com_time.Text = UserDetails.CourseStringTime(DataGridView_mangstudents.Rows[e.RowIndex].Cells["Time"].Value.ToString());
                string tempDate = DataGridView_mangstudents.Rows[e.RowIndex].Cells["BirthDate"].Value.ToString();
                if (tempDate == "0000-00-00")
                {
                    tempDate = "2000-01-01";
                }
                datetime_birthdate.Value = DateTime.Parse(tempDate);
                SelectedStudentID = Int32.Parse(DataGridView_mangstudents.Rows[e.RowIndex].Cells["ID"].Value.ToString()); active = DataGridView_mangstudents.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "1" ? true : false;
                btn_active.Text = active ? "Unactivate" : "Activate";
                toggleBtnEnabled();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UserFacade.UpdateStudent(
                SelectedStudentID,
                txt_name.Text,
                txt_username.Text,
                txt_password.Text,
                txt_email.Text,
                txt_level.Text,
                txt_mobile.Text,
                com_time.Text,
                datetime_birthdate.Value,
                com_coursetype.Text
                );
            Manage_students_Load(sender, e);
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            UserFacade.ActivateStudent(username);
            Manage_students_Load(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            UserFacade.DeleteStudent(username);
            Manage_students_Load(sender, e);
        }
    }
}

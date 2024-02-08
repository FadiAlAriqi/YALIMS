namespace YALIMS
{
    public partial class Manage_marks : Form
    {
        string SelectedMarkID;
        public Manage_marks()
        {
            InitializeComponent();
        }

        private void Manage_marks_Load(object sender, EventArgs e)
        {
            DataGridView_mangmarks.DataSource = UserFacade.AllMarks();
            if (UserDetails.role == "Teacher")
            {
                label5.Visible = false;
                label10.Visible = false;
                com_coursetype.Visible = false;
                txt_level.Visible = false;
            }
        }

        private void DataGridView_mangmarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txt_marks.Text = DataGridView_mangmarks.Rows[e.RowIndex].Cells["Mark"].Value.ToString();
                txt_level.Text = DataGridView_mangmarks.Rows[e.RowIndex].Cells["CourseLevel"].Value.ToString();
                com_coursetype.Text = UserDetails.CourseTypeString(Int32.Parse(DataGridView_mangmarks.Rows[e.RowIndex].Cells["CourseType"].Value.ToString()));
                SelectedMarkID = DataGridView_mangmarks.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UserFacade.UpdateMark(com_coursetype.Text, txt_level.Text, txt_marks.Text, SelectedMarkID);
            Manage_marks_Load(sender, e);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            UserFacade.DeleteMark(SelectedMarkID);
            Manage_marks_Load(sender, e);
        }
    }
}

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
    public partial class StudentDashbord : Form
    {
        public StudentDashbord()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentDashbord_Load(object sender, EventArgs e)
        {
            studentmrk_datagrid.DataSource = UserFacade.StudentMarks();
        }
    }
}

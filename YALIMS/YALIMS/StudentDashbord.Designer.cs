namespace YALIMS
{
    partial class StudentDashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_slide = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.studentmrk_datagrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnl_slide.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentmrk_datagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_slide
            // 
            this.pnl_slide.AutoScroll = true;
            this.pnl_slide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.pnl_slide.Controls.Add(this.btn_logout);
            this.pnl_slide.Controls.Add(this.pnl_logo);
            this.pnl_slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_slide.Location = new System.Drawing.Point(0, 0);
            this.pnl_slide.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_slide.Name = "pnl_slide";
            this.pnl_slide.Size = new System.Drawing.Size(264, 718);
            this.pnl_slide.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(0, 200);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_logout.Size = new System.Drawing.Size(264, 61);
            this.btn_logout.TabIndex = 8;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.label3);
            this.pnl_logo.Controls.Add(this.label2);
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(264, 200);
            this.pnl_logo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "YALI Institute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welecom to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "YALI";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(264, 0);
            this.panel_main.Margin = new System.Windows.Forms.Padding(4);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(968, 718);
            this.panel_main.TabIndex = 3;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.studentmrk_datagrid);
            this.panel_cover.Controls.Add(this.panel2);
            this.panel_cover.Controls.Add(this.panel1);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Margin = new System.Windows.Forms.Padding(4);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(968, 718);
            this.panel_cover.TabIndex = 0;
            // 
            // studentmrk_datagrid
            // 
            this.studentmrk_datagrid.AllowUserToAddRows = false;
            this.studentmrk_datagrid.AllowUserToDeleteRows = false;
            this.studentmrk_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentmrk_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.studentmrk_datagrid.Location = new System.Drawing.Point(3, 45);
            this.studentmrk_datagrid.Name = "studentmrk_datagrid";
            this.studentmrk_datagrid.RowHeadersWidth = 51;
            this.studentmrk_datagrid.RowTemplate.Height = 29;
            this.studentmrk_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentmrk_datagrid.Size = new System.Drawing.Size(962, 468);
            this.studentmrk_datagrid.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Location = new System.Drawing.Point(-4, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 19);
            this.panel2.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 45);
            this.panel1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(713, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Student Marks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "YALI Managment System";
            // 
            // StudentDashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 718);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.pnl_slide);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentDashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentDashbord";
            this.Load += new System.EventHandler(this.StudentDashbord_Load);
            this.pnl_slide.ResumeLayout(false);
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentmrk_datagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_slide;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private DataGridView studentmrk_datagrid;
    }
}
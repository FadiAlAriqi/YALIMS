namespace YALIMS
{
    partial class Add_marks
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
            this.txt_level = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.com_coursetype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_marks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DataGridView_mangstudents = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_mangstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(818, 611);
            this.txt_level.Margin = new System.Windows.Forms.Padding(2);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(143, 23);
            this.txt_level.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(698, 613);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "Level :";
            // 
            // com_coursetype
            // 
            this.com_coursetype.FormattingEnabled = true;
            this.com_coursetype.Items.AddRange(new object[] {
            "Level Course",
            "Writing Course",
            "Listing Course"});
            this.com_coursetype.Location = new System.Drawing.Point(198, 613);
            this.com_coursetype.Margin = new System.Windows.Forms.Padding(2);
            this.com_coursetype.Name = "com_coursetype";
            this.com_coursetype.Size = new System.Drawing.Size(143, 25);
            this.com_coursetype.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(14, 616);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "CourseType :";
            // 
            // txt_marks
            // 
            this.txt_marks.Location = new System.Drawing.Point(508, 615);
            this.txt_marks.Margin = new System.Windows.Forms.Padding(2);
            this.txt_marks.Name = "txt_marks";
            this.txt_marks.Size = new System.Drawing.Size(143, 23);
            this.txt_marks.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(388, 616);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mark :";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.Orange;
            this.btn_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(703, 703);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(116, 34);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.Blue;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(846, 703);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(116, 34);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.panel1.Size = new System.Drawing.Size(995, 45);
            this.panel1.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(740, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Add Marks";
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
            // DataGridView_mangstudents
            // 
            this.DataGridView_mangstudents.AllowUserToAddRows = false;
            this.DataGridView_mangstudents.AllowUserToDeleteRows = false;
            this.DataGridView_mangstudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_mangstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_mangstudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_mangstudents.Location = new System.Drawing.Point(0, 44);
            this.DataGridView_mangstudents.Name = "DataGridView_mangstudents";
            this.DataGridView_mangstudents.RowHeadersWidth = 51;
            this.DataGridView_mangstudents.RowTemplate.Height = 29;
            this.DataGridView_mangstudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_mangstudents.Size = new System.Drawing.Size(995, 525);
            this.DataGridView_mangstudents.TabIndex = 56;
            this.DataGridView_mangstudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_mangstudents_CellClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 23);
            this.panel2.TabIndex = 57;
            // 
            // Add_marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_mangstudents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_level);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.com_coursetype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_marks);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_marks";
            this.Text = "Add_marks";
            this.Load += new System.EventHandler(this.Add_marks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_mangstudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_level;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox com_coursetype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_marks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private DataGridView DataGridView_mangstudents;
        private Panel panel2;
    }
}
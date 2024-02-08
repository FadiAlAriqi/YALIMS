namespace YALIMS
{
    partial class Manage_marks
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridView_mangmarks = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_mangmarks)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_level
            // 
            this.txt_level.Location = new System.Drawing.Point(780, 565);
            this.txt_level.Margin = new System.Windows.Forms.Padding(2);
            this.txt_level.Name = "txt_level";
            this.txt_level.Size = new System.Drawing.Size(143, 23);
            this.txt_level.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(672, 567);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Level :";
            // 
            // com_coursetype
            // 
            this.com_coursetype.FormattingEnabled = true;
            this.com_coursetype.Items.AddRange(new object[] {
            "Level Course",
            "Writing Course",
            "Listening Course"});
            this.com_coursetype.Location = new System.Drawing.Point(186, 564);
            this.com_coursetype.Margin = new System.Windows.Forms.Padding(2);
            this.com_coursetype.Name = "com_coursetype";
            this.com_coursetype.Size = new System.Drawing.Size(143, 25);
            this.com_coursetype.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(14, 567);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "CourseType :";
            // 
            // txt_marks
            // 
            this.txt_marks.Location = new System.Drawing.Point(472, 565);
            this.txt_marks.Margin = new System.Windows.Forms.Padding(2);
            this.txt_marks.Name = "txt_marks";
            this.txt_marks.Size = new System.Drawing.Size(165, 23);
            this.txt_marks.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(364, 566);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mark :";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BackColor = System.Drawing.Color.Green;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(853, 675);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(116, 34);
            this.btn_update.TabIndex = 48;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(717, 675);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 34);
            this.btn_delete.TabIndex = 47;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.panel1.Size = new System.Drawing.Size(977, 45);
            this.panel1.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(722, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Manage Marks";
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Location = new System.Drawing.Point(0, 513);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 19);
            this.panel2.TabIndex = 50;
            // 
            // DataGridView_mangmarks
            // 
            this.DataGridView_mangmarks.AllowUserToAddRows = false;
            this.DataGridView_mangmarks.AllowUserToDeleteRows = false;
            this.DataGridView_mangmarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_mangmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_mangmarks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView_mangmarks.Location = new System.Drawing.Point(0, 44);
            this.DataGridView_mangmarks.Name = "DataGridView_mangmarks";
            this.DataGridView_mangmarks.RowHeadersWidth = 51;
            this.DataGridView_mangmarks.RowTemplate.Height = 29;
            this.DataGridView_mangmarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_mangmarks.Size = new System.Drawing.Size(977, 469);
            this.DataGridView_mangmarks.TabIndex = 51;
            this.DataGridView_mangmarks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_mangmarks_CellClick);
            // 
            // Manage_marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 716);
            this.Controls.Add(this.DataGridView_mangmarks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_level);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.com_coursetype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_marks);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manage_marks";
            this.Text = "Manage_marks";
            this.Load += new System.EventHandler(this.Manage_marks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_mangmarks)).EndInit();
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
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private DataGridView DataGridView_mangmarks;
    }
}
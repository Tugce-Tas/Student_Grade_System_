namespace StudentGradeSystem
{
    partial class TeacherDetails
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblExam1 = new System.Windows.Forms.TextBox();
            this.LblExam3 = new System.Windows.Forms.TextBox();
            this.LblExam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblAverage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eXAM3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUATIONDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tBLCLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBStudentGradeSystemDataSet = new StudentGradeSystem.DBStudentGradeSystemDataSet();
            this.tBLCLASSTableAdapter = new StudentGradeSystem.DBStudentGradeSystemDataSetTableAdapters.TBLCLASSTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentGradeSystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MskNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a Student";
            // 
            // LblSurname
            // 
            this.LblSurname.Location = new System.Drawing.Point(200, 175);
            this.LblSurname.Name = "LblSurname";
            this.LblSurname.Size = new System.Drawing.Size(178, 26);
            this.LblSurname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(109, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(240, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblName
            // 
            this.LblName.Location = new System.Drawing.Point(200, 128);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(178, 26);
            this.LblName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(131, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // MskNumber
            // 
            this.MskNumber.Location = new System.Drawing.Point(200, 80);
            this.MskNumber.Mask = "0000";
            this.MskNumber.Name = "MskNumber";
            this.MskNumber.Size = new System.Drawing.Size(179, 26);
            this.MskNumber.TabIndex = 1;
            this.MskNumber.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(114, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblExam1);
            this.groupBox2.Controls.Add(this.LblExam3);
            this.groupBox2.Controls.Add(this.LblAverage);
            this.groupBox2.Controls.Add(this.LblExam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(516, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 315);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Grades";
            // 
            // LblExam1
            // 
            this.LblExam1.Location = new System.Drawing.Point(129, 75);
            this.LblExam1.Name = "LblExam1";
            this.LblExam1.Size = new System.Drawing.Size(178, 26);
            this.LblExam1.TabIndex = 9;
            // 
            // LblExam3
            // 
            this.LblExam3.Location = new System.Drawing.Point(130, 170);
            this.LblExam3.Name = "LblExam3";
            this.LblExam3.Size = new System.Drawing.Size(178, 26);
            this.LblExam3.TabIndex = 8;
            // 
            // LblExam2
            // 
            this.LblExam2.Location = new System.Drawing.Point(130, 123);
            this.LblExam2.Name = "LblExam2";
            this.LblExam2.Size = new System.Drawing.Size(178, 26);
            this.LblExam2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Exam 3 :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(169, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(52, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Exam 2 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exam 1 :";
            // 
            // LblAverage
            // 
            this.LblAverage.AutoSize = true;
            this.LblAverage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAverage.Location = new System.Drawing.Point(444, 126);
            this.LblAverage.Name = "LblAverage";
            this.LblAverage.Size = new System.Drawing.Size(28, 18);
            this.LblAverage.TabIndex = 6;
            this.LblAverage.Text = "00";
            this.LblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(362, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Average :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1020, 315);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Grades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.nUMBERDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.sURNAMEDataGridViewTextBoxColumn,
            this.eXAM1DataGridViewTextBoxColumn,
            this.eXAM2DataGridViewTextBoxColumn,
            this.eXAM3DataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.sITUATIONDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLCLASSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1014, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMBERDataGridViewTextBoxColumn
            // 
            this.nUMBERDataGridViewTextBoxColumn.DataPropertyName = "NUMBER";
            this.nUMBERDataGridViewTextBoxColumn.HeaderText = "NUMBER";
            this.nUMBERDataGridViewTextBoxColumn.Name = "nUMBERDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // sURNAMEDataGridViewTextBoxColumn
            // 
            this.sURNAMEDataGridViewTextBoxColumn.DataPropertyName = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.HeaderText = "SURNAME";
            this.sURNAMEDataGridViewTextBoxColumn.Name = "sURNAMEDataGridViewTextBoxColumn";
            // 
            // eXAM1DataGridViewTextBoxColumn
            // 
            this.eXAM1DataGridViewTextBoxColumn.DataPropertyName = "EXAM1";
            this.eXAM1DataGridViewTextBoxColumn.HeaderText = "EXAM1";
            this.eXAM1DataGridViewTextBoxColumn.Name = "eXAM1DataGridViewTextBoxColumn";
            // 
            // eXAM2DataGridViewTextBoxColumn
            // 
            this.eXAM2DataGridViewTextBoxColumn.DataPropertyName = "EXAM2";
            this.eXAM2DataGridViewTextBoxColumn.HeaderText = "EXAM2";
            this.eXAM2DataGridViewTextBoxColumn.Name = "eXAM2DataGridViewTextBoxColumn";
            // 
            // eXAM3DataGridViewTextBoxColumn
            // 
            this.eXAM3DataGridViewTextBoxColumn.DataPropertyName = "EXAM3";
            this.eXAM3DataGridViewTextBoxColumn.HeaderText = "EXAM3";
            this.eXAM3DataGridViewTextBoxColumn.Name = "eXAM3DataGridViewTextBoxColumn";
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            // 
            // sITUATIONDataGridViewCheckBoxColumn
            // 
            this.sITUATIONDataGridViewCheckBoxColumn.DataPropertyName = "SITUATION";
            this.sITUATIONDataGridViewCheckBoxColumn.HeaderText = "SITUATION";
            this.sITUATIONDataGridViewCheckBoxColumn.Name = "sITUATIONDataGridViewCheckBoxColumn";
            // 
            // tBLCLASSBindingSource
            // 
            this.tBLCLASSBindingSource.DataMember = "TBLCLASS";
            this.tBLCLASSBindingSource.DataSource = this.dBStudentGradeSystemDataSet;
            // 
            // dBStudentGradeSystemDataSet
            // 
            this.dBStudentGradeSystemDataSet.DataSetName = "DBStudentGradeSystemDataSet";
            this.dBStudentGradeSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLCLASSTableAdapter
            // 
            this.tBLCLASSTableAdapter.ClearBeforeFill = true;
            // 
            // TeacherDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1051, 692);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TeacherDetails";
            this.Text = "Teacher Details";
            this.Load += new System.EventHandler(this.TeacherDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBStudentGradeSystemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LblSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox LblName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblAverage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBStudentGradeSystemDataSet dBStudentGradeSystemDataSet;
        private System.Windows.Forms.BindingSource tBLCLASSBindingSource;
        private DBStudentGradeSystemDataSetTableAdapters.TBLCLASSTableAdapter tBLCLASSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eXAM3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sITUATIONDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox LblExam1;
        private System.Windows.Forms.TextBox LblExam3;
        private System.Windows.Forms.TextBox LblExam2;
    }
}
namespace StuRecSystem
{
    partial class FrmTeachersPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mskNum = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExam3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtExam2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExam1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUNUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUSnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUExam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUExam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUExam3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sTULESSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBNotKayitDataSet = new StuRecSystem.DBNotKayitDataSet();
            this.sTULESSONTableAdapter = new StuRecSystem.DBNotKayitDataSetTableAdapters.STULESSONTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTULESSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotKayitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.mskNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(147, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(162, 143);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(76, 22);
            this.txtSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 22);
            this.txtName.TabIndex = 2;
            // 
            // mskNum
            // 
            this.mskNum.Location = new System.Drawing.Point(162, 47);
            this.mskNum.Mask = "0000";
            this.mskNum.Name = "mskNum";
            this.mskNum.Size = new System.Drawing.Size(76, 22);
            this.mskNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtExam3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtExam2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtExam1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(292, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 242);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score Entry";
            // 
            // txtExam3
            // 
            this.txtExam3.Location = new System.Drawing.Point(140, 142);
            this.txtExam3.Name = "txtExam3";
            this.txtExam3.Size = new System.Drawing.Size(76, 22);
            this.txtExam3.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Exam 3:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtExam2
            // 
            this.txtExam2.Location = new System.Drawing.Point(140, 94);
            this.txtExam2.Name = "txtExam2";
            this.txtExam2.Size = new System.Drawing.Size(76, 22);
            this.txtExam2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Exam 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Exam 1:";
            // 
            // txtExam1
            // 
            this.txtExam1.Location = new System.Drawing.Point(140, 47);
            this.txtExam1.Name = "txtExam1";
            this.txtExam1.Size = new System.Drawing.Size(76, 22);
            this.txtExam1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblFail);
            this.groupBox3.Controls.Add(this.lblPass);
            this.groupBox3.Controls.Add(this.lblAvg);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(555, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 242);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exam\'s Grades";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Location = new System.Drawing.Point(142, 145);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(27, 16);
            this.lblFail.TabIndex = 10;
            this.lblFail.Text = "00";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(142, 97);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(27, 16);
            this.lblPass.TabIndex = 9;
            this.lblPass.Text = "00";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(142, 53);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(27, 16);
            this.lblAvg.TabIndex = 8;
            this.lblAvg.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kalan Sayısı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Geçen Sayısı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Average:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(7, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(796, 201);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUIDDataGridViewTextBoxColumn,
            this.sTUNUMDataGridViewTextBoxColumn,
            this.sTUNameDataGridViewTextBoxColumn,
            this.sTUSnameDataGridViewTextBoxColumn,
            this.sTUExam1DataGridViewTextBoxColumn,
            this.sTUExam2DataGridViewTextBoxColumn,
            this.sTUExam3DataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.situationDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.sTULESSONBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sTUIDDataGridViewTextBoxColumn
            // 
            this.sTUIDDataGridViewTextBoxColumn.DataPropertyName = "STU_ID";
            this.sTUIDDataGridViewTextBoxColumn.HeaderText = "STU_ID";
            this.sTUIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUIDDataGridViewTextBoxColumn.Name = "sTUIDDataGridViewTextBoxColumn";
            this.sTUIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTUNUMDataGridViewTextBoxColumn
            // 
            this.sTUNUMDataGridViewTextBoxColumn.DataPropertyName = "STU_NUM";
            this.sTUNUMDataGridViewTextBoxColumn.HeaderText = "STU_NUM";
            this.sTUNUMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUNUMDataGridViewTextBoxColumn.Name = "sTUNUMDataGridViewTextBoxColumn";
            // 
            // sTUNameDataGridViewTextBoxColumn
            // 
            this.sTUNameDataGridViewTextBoxColumn.DataPropertyName = "STU_Name";
            this.sTUNameDataGridViewTextBoxColumn.HeaderText = "STU_Name";
            this.sTUNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUNameDataGridViewTextBoxColumn.Name = "sTUNameDataGridViewTextBoxColumn";
            // 
            // sTUSnameDataGridViewTextBoxColumn
            // 
            this.sTUSnameDataGridViewTextBoxColumn.DataPropertyName = "STU_Sname";
            this.sTUSnameDataGridViewTextBoxColumn.HeaderText = "STU_Sname";
            this.sTUSnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUSnameDataGridViewTextBoxColumn.Name = "sTUSnameDataGridViewTextBoxColumn";
            // 
            // sTUExam1DataGridViewTextBoxColumn
            // 
            this.sTUExam1DataGridViewTextBoxColumn.DataPropertyName = "STU_Exam1";
            this.sTUExam1DataGridViewTextBoxColumn.HeaderText = "STU_Exam1";
            this.sTUExam1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUExam1DataGridViewTextBoxColumn.Name = "sTUExam1DataGridViewTextBoxColumn";
            // 
            // sTUExam2DataGridViewTextBoxColumn
            // 
            this.sTUExam2DataGridViewTextBoxColumn.DataPropertyName = "STU_Exam2";
            this.sTUExam2DataGridViewTextBoxColumn.HeaderText = "STU_Exam2";
            this.sTUExam2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUExam2DataGridViewTextBoxColumn.Name = "sTUExam2DataGridViewTextBoxColumn";
            // 
            // sTUExam3DataGridViewTextBoxColumn
            // 
            this.sTUExam3DataGridViewTextBoxColumn.DataPropertyName = "STU_Exam3";
            this.sTUExam3DataGridViewTextBoxColumn.HeaderText = "STU_Exam3";
            this.sTUExam3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTUExam3DataGridViewTextBoxColumn.Name = "sTUExam3DataGridViewTextBoxColumn";
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            // 
            // situationDataGridViewCheckBoxColumn
            // 
            this.situationDataGridViewCheckBoxColumn.DataPropertyName = "Situation";
            this.situationDataGridViewCheckBoxColumn.HeaderText = "Situation";
            this.situationDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.situationDataGridViewCheckBoxColumn.Name = "situationDataGridViewCheckBoxColumn";
            // 
            // sTULESSONBindingSource
            // 
            this.sTULESSONBindingSource.DataMember = "STULESSON";
            this.sTULESSONBindingSource.DataSource = this.dBNotKayitDataSet;
            // 
            // dBNotKayitDataSet
            // 
            this.dBNotKayitDataSet.DataSetName = "DBNotKayitDataSet";
            this.dBNotKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTULESSONTableAdapter
            // 
            this.sTULESSONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeachersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(815, 490);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTeachersPage";
            this.Text = "FrmTeachersPage";
            this.Load += new System.EventHandler(this.FrmTeachersPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTULESSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBNotKayitDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mskNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtExam2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExam1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtExam3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBNotKayitDataSet dBNotKayitDataSet;
        private System.Windows.Forms.BindingSource sTULESSONBindingSource;
        private DBNotKayitDataSetTableAdapters.STULESSONTableAdapter sTULESSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUNUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUSnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUExam1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUExam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUExam3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn situationDataGridViewCheckBoxColumn;
    }
}
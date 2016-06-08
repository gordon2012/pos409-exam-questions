namespace pos409_exam_questions
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChapterDesc = new System.Windows.Forms.TextBox();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAssignment = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChapterAdd = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lstChaptersD = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtChapterQuestions = new System.Windows.Forms.TextBox();
            this.lstChaptersQ = new System.Windows.Forms.ListBox();
            this.btnRemoveChapter = new System.Windows.Forms.Button();
            this.pnlStudents.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chapters";
            // 
            // txtChapterDesc
            // 
            this.txtChapterDesc.Location = new System.Drawing.Point(63, 5);
            this.txtChapterDesc.Name = "txtChapterDesc";
            this.txtChapterDesc.Size = new System.Drawing.Size(149, 20);
            this.txtChapterDesc.TabIndex = 3;
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.btnRemoveStudent);
            this.pnlStudents.Controls.Add(this.txtStudent);
            this.pnlStudents.Controls.Add(this.lstStudents);
            this.pnlStudents.Controls.Add(this.btnAddStudent);
            this.pnlStudents.Controls.Add(this.label1);
            this.pnlStudents.Location = new System.Drawing.Point(12, 12);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(335, 253);
            this.pnlStudents.TabIndex = 6;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(6, 176);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(90, 24);
            this.btnRemoveStudent.TabIndex = 13;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(53, 9);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(180, 20);
            this.txtStudent.TabIndex = 11;
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.Location = new System.Drawing.Point(6, 36);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(323, 134);
            this.lstStudents.TabIndex = 12;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(239, 6);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(90, 24);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAssignment
            // 
            this.txtAssignment.Location = new System.Drawing.Point(814, 208);
            this.txtAssignment.Multiline = true;
            this.txtAssignment.Name = "txtAssignment";
            this.txtAssignment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAssignment.Size = new System.Drawing.Size(400, 372);
            this.txtAssignment.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(711, 87);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(133, 39);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveChapter);
            this.panel1.Controls.Add(this.lstChaptersQ);
            this.panel1.Controls.Add(this.txtChapterQuestions);
            this.panel1.Controls.Add(this.btnChapterAdd);
            this.panel1.Controls.Add(this.lstChaptersD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtChapterDesc);
            this.panel1.Location = new System.Drawing.Point(424, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 291);
            this.panel1.TabIndex = 11;
            // 
            // btnChapterAdd
            // 
            this.btnChapterAdd.Location = new System.Drawing.Point(273, 2);
            this.btnChapterAdd.Name = "btnChapterAdd";
            this.btnChapterAdd.Size = new System.Drawing.Size(53, 24);
            this.btnChapterAdd.TabIndex = 12;
            this.btnChapterAdd.Text = "Add";
            this.btnChapterAdd.UseVisualStyleBackColor = true;
            this.btnChapterAdd.Click += new System.EventHandler(this.btnChapterAdd_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(544, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(42, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // lstChaptersD
            // 
            this.lstChaptersD.FormattingEnabled = true;
            this.lstChaptersD.Location = new System.Drawing.Point(11, 32);
            this.lstChaptersD.Name = "lstChaptersD";
            this.lstChaptersD.Size = new System.Drawing.Size(201, 160);
            this.lstChaptersD.TabIndex = 14;
            this.lstChaptersD.SelectedIndexChanged += new System.EventHandler(this.lstChaptersD_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(496, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // txtChapterQuestions
            // 
            this.txtChapterQuestions.Location = new System.Drawing.Point(218, 5);
            this.txtChapterQuestions.Name = "txtChapterQuestions";
            this.txtChapterQuestions.Size = new System.Drawing.Size(49, 20);
            this.txtChapterQuestions.TabIndex = 15;
            // 
            // lstChaptersQ
            // 
            this.lstChaptersQ.FormattingEnabled = true;
            this.lstChaptersQ.Location = new System.Drawing.Point(218, 32);
            this.lstChaptersQ.Name = "lstChaptersQ";
            this.lstChaptersQ.Size = new System.Drawing.Size(108, 160);
            this.lstChaptersQ.TabIndex = 16;
            this.lstChaptersQ.SelectedIndexChanged += new System.EventHandler(this.lstChaptersQ_SelectedIndexChanged);
            // 
            // btnRemoveChapter
            // 
            this.btnRemoveChapter.Location = new System.Drawing.Point(11, 198);
            this.btnRemoveChapter.Name = "btnRemoveChapter";
            this.btnRemoveChapter.Size = new System.Drawing.Size(90, 24);
            this.btnRemoveChapter.TabIndex = 14;
            this.btnRemoveChapter.Text = "Remove";
            this.btnRemoveChapter.UseVisualStyleBackColor = true;
            this.btnRemoveChapter.Click += new System.EventHandler(this.btnRemoveChapter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtAssignment);
            this.Controls.Add(this.pnlStudents);
            this.Name = "MainForm";
            this.Text = "Exam Question Assigner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChapterDesc;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.TextBox txtAssignment;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChapterAdd;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListBox lstChaptersD;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtChapterQuestions;
        private System.Windows.Forms.ListBox lstChaptersQ;
        private System.Windows.Forms.Button btnRemoveChapter;
    }
}


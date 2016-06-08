﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos409_exam_questions
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] chapterNames = { "W2Ch3", "W2Ch4", "W2Ch5", "W2Ch8", "W3Ch6", "W3Ch7", "W4Ch9", "W4Ch10", "W5Ch11", "W5Ch12"};
            int[] chapterCounts = {15,13,14,20,21, 10,20,13,14,10};

            int student = 0;

            txtAssignment.Text = "";
            for (int i = 0; i < chapterNames.Length; i++)
            {
                for (int j = 0; j < chapterCounts[i]; j++)
                {
                    txtAssignment.Text += "Student " + (student+1).ToString() + ": " + chapterNames[i] + " Question " + (j+1).ToString() + Environment.NewLine;
                    student++;
                    //student = student % tbrStudents.Value;
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudent.Text != "")
            {
                lstStudents.Items.Add(txtStudent.Text);
                txtStudent.Text = "";
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex != -1)
            {
                lstStudents.Items.RemoveAt(lstStudents.SelectedIndex);
            }
            
        }

        private void btnChapterAdd_Click(object sender, EventArgs e)
        {
            //lstChapters.Items.Add
        }

    }
}

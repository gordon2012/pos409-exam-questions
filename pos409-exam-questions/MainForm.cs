using System;
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

        //int students = 0;


        public MainForm()
        {
            InitializeComponent();
        }


        private void ResizeStudents()
        {
            //pnlStudents.

            //for (int i = 0; i < tbrStudents.Value; i++)
            //{
            //    TextBox newTxt = new TextBox();

            //    newTxt.Parent = pnlStudents;
            //    newTxt.Left = 10;
            //    newTxt.Top = 10 + 25 * i;
            //}
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //int test = 1;

            //Console.WriteLine(test);

            //TextBox newTxt = new TextBox();
            //newTxt.Location.X = 0;

            //newTxt.Left = 0;
            //newTxt.Top = 20 * students;

            //newTxt.Parent = gbxStudents;

            //students++;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblStudents.Text = tbrStudents.Value.ToString();
            ResizeStudents();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblStudents.Text = tbrStudents.Value.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string[] chapterNames = { "W2Ch3", "W2Ch4", "W2Ch5", "W2Ch8", "W3Ch6", "W3Ch7", "W4Ch9", "W4Ch10", "W5Ch11", "W5Ch12"};
            int[] chapterCounts = {15,13,14,20,21, 10,20,13,14,10};




        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form03_20_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";

            openFile.InitialDirectory = @"C:\Users\ICI\Desktop";
            openFile.RestoreDirectory = true;
            openFile.ShowDialog();

            //openFile(openFileDialog1.FileName);

            if (openFile.FileName.Length > 0)
            {
                string fileContent = File.ReadAllText(openFile.FileName);

                // textBox1.Text에 파일 내용 할당하기
                textBox1.Text = fileContent;

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string fileName;
            saveFileDialog1.Title = "저장경로를 지정하세요";
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                SaveFile(fileName);
            }
        }

        private void SaveFile(string filename)
        {
            File.WriteAllText(filename, textBox1.Text);
        }
        int i = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = i++;

            if(progressBar1.Value >= 100)
            {
                i = 0;
            }

            //Console.WriteLine("i = " + i++);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

            if (e.Equals("Equals"))
            {

            }
        }

        private void RedBar_Scroll(object sender, EventArgs e)
        {
            DrawColor.BackColor = Color.FromArgb(RedBar.Value, 0, 0);
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            DrawColor.BackColor = Color.FromArgb(0, GreenBar.Value, 0);
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            DrawColor.BackColor = Color.FromArgb(0, 0, BlueBar.Value);
        }
    }
}

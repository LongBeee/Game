using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace YutGame
{
    public partial class Form1 : Form
    {
        Image[] img = new Image[2];
        SolidBrush brush;
        
        public Form1()
        {
            InitializeComponent();
            img[0] = new Bitmap("..\\..\\Resources\\Yut1.png"); // 1점
            img[1] = new Bitmap("..\\..\\Resources\\Yut2.png"); // 0점
            brush = new SolidBrush(Color.FromArgb(0,255,0));
        }

        Random rd = new Random();
        int x = 10, y = 10;

        private void btnYut_Click(object sender, EventArgs e)
        {
            string result = "";

            int n1, n2, n3, n4, Score;
            n1 = rd.Next(100) / 57;
            n2 = rd.Next(100) / 57;
            n3 = rd.Next(100) / 57;
            n4 = rd.Next(100) / 57;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = img[n1];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = img[n2];
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = img[n3];
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = img[n4];

            label1.Text = "{n1} {n2} {n3} {n4} :";
            Score = n1 + n2 + n3 + n4;

            switch (Score)
            {
                case 0:
                    result = "모"; break;
                case 1:
                    result = "도"; break;
                case 2:
                    result = "개"; break;
                case 3:
                    result = "걸"; break;
                case 4:
                    result = "윷"; break;
            }

            label1.Text = result;
            label1.Size = new Size(200, 100);
        }

        private void Panel_Draw(object sender, PaintEventArgs e)
        {
            //MessageBox.Show("Panel" + Math.Sin(30*Math.PI / 180));
            MessageBox.Show("Panel" + Math.Sin(30 * Math.PI / 180));
            Graphics g = e.Graphics;
            //g.FillPie(brush,e.ClipRectangle, 0, 270);

            g.FillPie(brush, new Rectangle(x, y, 20, 20), 0, 360);
            x = rd.Next(MyCanvas.Width);
            y = rd.Next(MyCanvas.Height);
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(MultiCircle);
            th.Start();
        }

        private void MultiCircle()
        {
            //MessageBox.Show("Thread");
            for(int i = 0; i < 10; i++)
            {
                x = rd.Next(MyCanvas.Width);
                y = rd.Next(MyCanvas.Width);
                MyCanvas.Invalidate();
                Thread.Sleep(500);
            }
        }
    }
}

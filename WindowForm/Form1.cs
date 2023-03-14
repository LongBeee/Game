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

namespace Form03_14_3
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
            drawPanel1.BackColor = Color.Orange;
            drawPanel2.BackColor = Color.Orange;
            drawPanel3.BackColor = Color.Orange;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(DoWork));
            thread1.IsBackground = true;
            thread1.Start();

            // 스레드가 종료될 때까지 대기
            while (thread1.IsAlive)
            {
                Application.DoEvents(); // 이벤트 처리를 위한 대기
            }
        }

        private void DoWork()
        {
            while (true)
            {
                int randomNumber1 = random.Next(0, 2); 
                UpdatePanel(drawPanel1, randomNumber1.ToString());

                int randomNumber2 = random.Next(0, 2);
                UpdatePanel(drawPanel2, randomNumber2.ToString());

                int randomNumber3 = random.Next(0, 2);
                UpdatePanel(drawPanel3, randomNumber3.ToString());

                if ((randomNumber1 == randomNumber2) && (randomNumber2 == randomNumber3) && (randomNumber1 == randomNumber3))
                {
                    label1.Text = "축하드립니다!!";
                    break;
                }

                Thread.Sleep(1000);
            }
        }

        private void UpdatePanel(Panel panel, string text)
        {
            if (panel.InvokeRequired)
            {
                panel.Invoke(new MethodInvoker(() => UpdatePanel(panel, text)));
            }
            else
            {
                panel.Controls.Clear();

                panel.Invalidate();

                panel.Paint += (sender, e) =>
                {
                    e.Graphics.Clear(panel.BackColor);

                    using (var brush = new SolidBrush(panel.ForeColor))
                    {
                        var font = new Font(panel.Font.FontFamily, 20, panel.Font.Style);

                        var textSize = e.Graphics.MeasureString(text, font);
                        var x = (panel.ClientSize.Width - textSize.Width) / 2;
                        var y = (panel.ClientSize.Height - textSize.Height) / 2;
                        e.Graphics.DrawString(text, font, brush, x, y);

                        font.Dispose();
                    }
                };
            }
        }
    }
}

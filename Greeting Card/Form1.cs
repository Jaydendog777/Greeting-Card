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
using System.Xml;
using System.Media;

namespace Greeting_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 3);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush colors = new SolidBrush(Color.Black);
            Font drawFont = new Font("ariel", 16);

            SoundPlayer birthday = new SoundPlayer(Properties.Resources.Singing_Happy_Birthday_SoundBible_com_1765167834__2_);

            birthday.Play();
            int y = 400;

            while(y >= 310) // Brings balloons into view
            {
                g.Clear(Color.Orange);
                g.FillEllipse(blueBrush, 200, y, 50, 64);
                g.FillEllipse(greenBrush, 230, y+7, 50, 64);
                g.FillEllipse(redBrush, 160, y+5, 50, 64);
                y = y - 5;
                Thread.Sleep(20);
            }

            while(y >= -250) // Adds strings to balloons when in view
            {
                g.Clear(Color.Orange);
                g.DrawLine(blackPen, 225, y + 40, 225, y + 130);
                g.DrawLine(blackPen, 187, y + 47, 187, y + 137);
                g.DrawLine(blackPen, 255, y + 45, 255, y + 135);

                g.FillEllipse(blueBrush, 200, y, 50, 64);
                g.FillEllipse(greenBrush, 230, y + 7, 50, 64);
                g.FillEllipse(redBrush, 160, y + 5, 50, 64);

                y = y - 5;
                Thread.Sleep(20);
            }

            y = 400;

            while(y >= 225) //Brings happy birthday text into view
            {
                g.Clear(Color.Orange);
                g.DrawString("HAPPY BIRTHDAY", drawFont, blueBrush, 150, y);

                y = y - 5;
                Thread.Sleep(20);
            }
            int x = y;
            y = 1;
            int re = 1;
            int gr = 100;
            int bl = 200;

            g.Clear(Color.Orange); //Changes birthday texts color
            while (y <= 500)
            {
                colors = new SolidBrush(Color.FromArgb(re, gr, bl));
                g.DrawString("HAPPY BIRTHDAY", drawFont, colors, 150, x);
                if (re == 255)
                {
                    re = 1;
                }
                if (gr == 255)
                {
                    gr = 1;
                }
                if (bl == 255)
                {
                    bl = 1;
                }
                Thread.Sleep(1);
                y++;
                re++;
                gr++;
                bl++;
            }
            g.DrawString("HAPPY BIRTHDAY", drawFont, blueBrush, 150, x);
            birthday.Stop();
        }

        //Shows what program opens with
        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Font drawFont = new Font("ariel", 16);

            g.DrawString("Happy birthday Garrett!", drawFont, blueBrush, 140, 150);
        }
    }
}

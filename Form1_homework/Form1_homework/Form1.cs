using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Form1_homework
{
    //Диян Калайджиев F108356

    public partial class Form1 : Form
    {
        Graphics gr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr = CreateGraphics();
            gr.SmoothingMode = SmoothingMode.HighQuality;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("animatedCircle.gif");

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

            gr.Clear(this.BackColor);
        }

        private void btnFigure_Click(object sender, EventArgs e)
        {
            Pen redPen = new Pen(Color.Red, 10);
            Pen bluePen = new Pen(Color.Blue, 10);

            int centerX = 200;
            int baseY = 100;
            int arcWidthStep = 35;
            int arcHeight = 200;
            int numArcs = 5;

            for (int i = 0; i < numArcs; i++)
            {
                int currentWidth = arcWidthStep * (i + 1);

                int currentY = baseY - (i * 10);

                Rectangle rect = new Rectangle(
                    centerX - currentWidth / 2,
                    currentY,
                    currentWidth, arcHeight
                );

                if (i % 2 == 0)
                {
                    gr.DrawArc(bluePen, rect, 180, 180);
                }
                else
                {
                    gr.DrawArc(redPen, rect, 180, 180);
                }
            }
        }
    }
}

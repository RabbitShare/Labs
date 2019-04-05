using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        private Pyramid pyramid;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            var b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pyramid = new Pyramid(g, new Point(300, 300));
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            pyramid.Modifier = (int)modBox.Value;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BorderCrossed(pyramid);
            pyramid.Move();
            pictureBox1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BorderCrossed(pyramid);
            pyramid.Move();
            pictureBox1.Invalidate();
        }
        private void BorderCrossed(Pyramid p)
        {
            if (p.FlowRight && p.A.X >= pictureBox1.Width
                ||!p.FlowRight && p.B.X <= 0)
                p.MoveX *= -1;
            if (p.FlowDown && p.C.Y >= pictureBox1.Height
                ||!p.FlowDown && p.H.Y <= 0)
                p.MoveY *= -1;
        }

        private void двигатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            двигатьToolStripMenuItem.Enabled = false;
            неДвигатьToolStripMenuItem.Enabled = true;
            modBox.Enabled = false;
        }

        private void неДвигатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            двигатьToolStripMenuItem.Enabled = true;
            неДвигатьToolStripMenuItem.Enabled = false;
            modBox.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8._4
{
    public partial class Pictures : Form
    {
        Random rnd = new Random();
        Graphics g;
        List<Picture> pictures = new List<Picture>();
        public Pictures()
        {
            InitializeComponent();
            var b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
            timer1.Start();
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            pictures.Add(new Picture(g, rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20)));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < pictures.Count; i++)
            {
                var p = pictures[i];
                BorderCrossed(p);
                for (int j = i + 1; j < pictures.Count; j++)
                {
                    var p2 = pictures[j];
                    var isCross = PictureCrossed(p, p2);
                    OnCross(p, p2, isCross);
                }
                p.Move(p.MoveX, p.MoveY);
            }
            pictureBox1.Invalidate();
        }

        private void BorderCrossed(Picture p)
        {
            if (p.FlowRight && p.Location.X + p.Width >= pictureBox1.Width
                || !p.FlowRight && p.Location.X <= 0)
                p.MoveX *= -1;
            if (p.FlowDown && p.Location.Y + p.Height >= pictureBox1.Height 
                || !p.FlowDown && p.Location.Y <= 0)
                p.MoveY *= -1;
        }

        private static bool PictureCrossed(Picture p, Picture p2) =>
            (p.Location.X + p.Width >= p2.Location.X && p.Location.X + p.Width <= p2.Location.X + p2.Width
                || p2.Location.X + p2.Width >= p.Location.X && p2.Location.X + p2.Width <= p.Location.X + p.Width)
                && (p.Location.Y + p.Height >= p2.Location.Y && p.Location.Y + p.Height <= p2.Location.Y + p2.Height
                || p2.Location.Y + p2.Height >= p.Location.Y && p2.Location.Y + p2.Height <= p.Location.Y + p.Height);

        private void OnCross(Picture p, Picture p2, bool isCross)
        {
            if (isCross)
            {
                //var hDamage = rnd.Next(1, Math.Abs(p2.Height) / 4 + 1);
                //var wDamage = rnd.Next(1, Math.Abs(p2.Width) / 4 + 1);
                //p.Height += hDamage;
                //p.Width += wDamage;
                p.MoveX += rnd.Next(Math.Abs(p2.MoveX) + 1);
                p.MoveY += rnd.Next(Math.Abs(p2.MoveY) + 1);
                p2.MoveX = -1;
                p2.MoveY = -1;
                //p2.Height -= hDamage;
                //p2.Width -= wDamage;
                //if (p2.Width * p2.Height <= 1)
                //    pictures.Remove(p2);
                //else
                p2.Location = new Point(rnd.Next(0, ClientSize.Width - 20), rnd.Next(0, ClientSize.Height - 20));
            }
        }

        private void Pictures_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

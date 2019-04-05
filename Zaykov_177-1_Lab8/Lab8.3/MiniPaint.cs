using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8._3
{
    public partial class MiniPaint : Form
    {
        private Graphics g;
        private Pen pen = new Pen(Color.Black, 2);
        private bool isPresed = false;
        private Point oldPoint;

        public MiniPaint()
        {
            InitializeComponent();
            toolStripComboBox1.Items.Add(Color.Black);
            toolStripComboBox1.Items.Add(Color.Red);
            toolStripComboBox1.Items.Add(Color.Silver);
            toolStripComboBox1.Items.Add(Color.Yellow);
            toolStripComboBox1.SelectedIndex = 0;
            KeyPreview = true;
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == openImgDialog.ShowDialog())
                {
                    pictureBox1.Load(openImgDialog.FileName);
                    g = Graphics.FromImage(pictureBox1.Image);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Невозмжно загрузить картнику");
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.OK == saveImgDialog.ShowDialog())
                    pictureBox1.Image.Save(saveImgDialog.FileName, ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                MessageBox.Show("Невозмжно сохранить картнику");
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isPresed = true;
            oldPoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) =>
            isPresed = false;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPresed && g != null)
            {
                var newPoint = GetNewPoint();
                g.DrawLine(pen,oldPoint, newPoint);
                oldPoint = newPoint;
                pictureBox1.Invalidate();
            }
            Point GetNewPoint() =>
                new Point(
                    MousePosition.X - Location.X - (Width - ClientSize.Width) + 5,
                    MousePosition.Y - Location.Y - (Height - ClientSize.Height) - menuStrip1.Height + 5
                    );
        }
        private void MiniPaint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Control && Clipboard.ContainsImage())
            {
                pictureBox1.Image = Clipboard.GetImage();
                g = Graphics.FromImage(pictureBox1.Image);
            }
            else if (e.KeyCode == Keys.V && e.Control && !Clipboard.ContainsImage())
                MessageBox.Show("Нет картинки");
            if (e.KeyCode == Keys.C && e.Control && g != null)
                Clipboard.SetImage(pictureBox1.Image);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e) =>
            pen.Color = (Color)toolStripComboBox1.SelectedItem;

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                pictureBox1.Image = Clipboard.GetImage();
                g = Graphics.FromImage(pictureBox1.Image);
            }
            else
                MessageBox.Show("Нет картинки");
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (g != null)
                Clipboard.SetImage(pictureBox1.Image);
        }
    }
}

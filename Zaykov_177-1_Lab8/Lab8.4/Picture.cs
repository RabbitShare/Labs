using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8._4
{
    enum Move
    {
        Right = 1,
        Left = 2,
        Up = 4,
        Down = 8,
    }
    class Picture
    {
        public bool FlowRight { get; set; }
        public bool FlowDown { get; set; }
        public int MoveX
        {
            get => _moveX;
            set
            {
                _moveX = value;
                FlowRight = MoveX > 0;
            }
        }
        public int MoveY
        {
            get => _moveY;
            set
            {
                _moveY = value;
                FlowDown = MoveY > 0;
            }
        }
        Graphics g;
        private static Random rnd = new Random();
        private int _moveX = 1;
        private int _moveY = 1;
        SolidBrush b;
        public Picture(Graphics g, int x, int y)
        {
            FlowRight = MoveX > 0;
            FlowDown = MoveY > 0;
            Height = 20;
            Width = 20;
            this.g = g;
            Location = new Point(x, y);
            var c = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            b = new SolidBrush(c);
            g.FillRectangle(b, Location.X, Location.Y, Height, Width);
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public Point Location { get; set; }

        public void Move(int x, int y)
        {
            Location = new Point(Location.X + x, Location.Y + y);
            g.FillRectangle(b, Location.X, Location.Y, Height, Width);

        }
        public void Draw()
        {
            g.FillRectangle(Brushes.Red, Location.X, Location.Y, Height, Width);

        }

    }
}

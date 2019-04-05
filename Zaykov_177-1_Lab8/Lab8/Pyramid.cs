using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab8
{
    class Pyramid
    {
        private Graphics g;
        private readonly Pen pyramydPen = new Pen(Color.Black, 1);
        private readonly Pen sectionPen = new Pen(Color.DarkRed, 2);
        private Point[] points;
        private int height;
        private int ribs;
        private double angle;
        private int _modifier = 1;

        public Point A = new Point();
        public Point B = new Point();
        public Point C = new Point();
        public Point H = new Point();
        private Point M = new Point();
        public int Modifier
        {
            get => _modifier;
            set
            {
                _modifier = value;
                Solve();
                Draw();
            }
        }
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
        private int _moveX = 1;
        private int _moveY = 1;
        public bool FlowRight { get; set; } = true;
        public bool FlowDown { get; set; } = true;

        private void Draw()
        {
            g.Clear(Color.Aqua);
            g.DrawLines(pyramydPen, new Point[] { A, B, C, A, H, B, H, C });
            g.DrawLines(sectionPen, new Point[] { H, M, B, H });
        }
        private void Solve()
        {
            double pow2(double x) => Pow(x, 2);

            var ribs = this.ribs * Modifier;
            var height = this.height * Modifier;
            B = new Point(A.X - ribs, A.Y);
            var t = (angle / 180) * PI;
            C = new Point((int)(A.X - ribs * (Cos(t))), (int)(A.Y + ribs * Sin(t)));
            H = new Point(C.X, A.Y - (int)(height * (1 - Sin(20.0 / 180 * PI))));
            var l = Sqrt(pow2(C.X - A.X) + pow2(C.Y - A.Y)) / 2;
            var k = l / 2;
            M = new Point(C.X + (int)k, C.Y - (int)Sqrt(pow2(l) - pow2(k)));
        }
        public Pyramid(Graphics g, Point startPoint)
        {
            FlowRight = MoveX > 0;
            FlowDown = MoveY > 0;
            ribs = 10;
            angle = 60;
            height = 20;
            this.g = g;
            A = startPoint;
            Solve();
            points = new Point[] { A, B, C, H, M };
            Draw();
        }
        public void Move()
        {
            A.X += MoveX;
            A.Y += MoveY;
            B.X += MoveX;
            B.Y += MoveY;
            C.X += MoveX;
            C.Y += MoveY;
            H.X += MoveX;
            H.Y += MoveY;
            M.X += MoveX;
            M.Y += MoveY;

            Draw();
        }
    }
}

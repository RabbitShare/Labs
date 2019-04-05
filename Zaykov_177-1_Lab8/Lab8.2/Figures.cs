using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FigureAction = System.Action<System.Drawing.Brush>;
using BrushFunc = System.Func<System.Drawing.Color, System.Drawing.Brush>;
using System.Collections.Generic;

namespace Lab8._2
{
    public partial class Figures : Form
    {
        private Graphics g;
        private Color color = Color.Black;
        private Brush brush = new SolidBrush(Color.Black);
        public Figures()
        {
            InitializeComponent();

            var b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            pictureBox1.Image = b;
            AddColorsToComboBox();
            AddBrushesToComboBox();
            AddFiguresToComboBox();
            comboPen.SelectedIndex = 0;
            comboFigure.SelectedIndex = 0;
            comboColor.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboPen.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboFigure.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            comboColor.SelectedIndex = 1;

        }
        private void AddFiguresToComboBox()
        {
            void circle(Brush brush) => g.FillEllipse(brush, 150, 150, 100, 100);
            void ellipse(Brush brush) => g.FillEllipse(brush, 130, 150, 150, 100);
            void sector(Brush brush) => g.FillPie(brush, 130, 150, 150, 150, 90, 190);
            void triangle(Brush brush) => g.FillPolygon(brush,
                new Point[] { new Point(150, 200), new Point(250, 200), new Point(250, 100) });
            void rectangle(Brush brush) => g.FillRectangle(brush, new Rectangle(150, 200, 150, 100));
            void polygon(Brush brush) => g.FillPolygon(brush,
                new Point[] { new Point(150, 200), new Point(100, 100), new Point(350, 200), new Point(200, 450), new Point(250, 300) });

            var figures = new Dictionary<string, FigureAction>
            {
                { "Круг",  circle},
                { "Элипс", ellipse },
                { "Сертор", sector },
                { "Треугольник", triangle },
                { "Прямоугольник", rectangle },
                { "Многоугольник", polygon }
            };
            comboFigure.DisplayMember = "Key";
            comboFigure.ValueMember = "Value";
            comboFigure.DataSource = new BindingSource(figures, null);
        }

        private void AddBrushesToComboBox()
        {
            Brush sb(Color color) => new SolidBrush(color);
            Brush hhb(Color color) => new HatchBrush(HatchStyle.Horizontal, Color.White, color);
            Brush drhb(Color color) => new HatchBrush(HatchStyle.Divot, Color.White, color);
            Brush lgb(Color color) => 
                new LinearGradientBrush(new Point(-200, -200), new Point(100, 10), color, Color.FromArgb(150, 0, 1, 145));
            Brush tb(Color color) => new TextureBrush(Image.FromFile(@"cor.png"));
            var brushes = new Dictionary<string, BrushFunc>
            {
                { "Обычная",  sb},
                { "Горизонтальная",  hhb },
                { "Дерновая", drhb },
                { "Градиентная", lgb },
                { "Текстурная", tb }
            };
            comboPen.DisplayMember = "Key";
            comboPen.ValueMember = "Value";
            comboPen.DataSource = new BindingSource(brushes, null);
        }

        private void AddColorsToComboBox()
        {
            var colors = new Dictionary<string, Color>
            {
                { "Синий", Color.Blue },
                { "Чёрный", Color.Black },
                { "Красный", Color.Red },
                { "Зелёный", Color.Green }
            };
            comboColor.DisplayMember = "Key";
            comboColor.ValueMember = "Value";
            comboColor.DataSource = new BindingSource(colors, null);
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            var c = (KeyValuePair<string, Color>)comboColor.SelectedItem;
            color = c.Value;

            var f = (KeyValuePair<string, BrushFunc>)comboPen.SelectedItem;
            var func = f.Value;
            brush = func(color);

            var a = (KeyValuePair<string, FigureAction>)comboFigure.SelectedItem;
            var action = a.Value;
            action(brush);

            pictureBox1.Invalidate();
        }
    }
}

using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Lab6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var ss = new ScreenSaver();
            ss.Show();
            Thread.Sleep(5000);
            ss.Close();
            Visible = true;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e) =>
            (new ElementForm("Новое окно " + (MdiChildren.Count() + 1))
            {
                MdiParent = this
            }).Show();

        private void CascadeClick(object sender, EventArgs e) =>
            LayoutMdi(MdiLayout.Cascade);

        private void VerticalClick(object sender, EventArgs e) =>
            LayoutMdi(MdiLayout.TileVertical);

        private void HorizontalClick(object sender, EventArgs e) =>
            LayoutMdi(MdiLayout.TileHorizontal);

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is ElementForm form)
                form.Save();
            else
                MessageBox.Show("Нельзя сохранить");
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openAquaDialog.ShowDialog())
            {
                try
                {
                    var f = Serializer.LoadElementForm(openAquaDialog.FileName);
                    f.MdiParent = this;
                    f.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно загрузить файл");
                }
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            var activate = ActiveMdiChild != null;
            сохранитьToolStripMenuItem.Enabled = activate;
            вВордToolStripMenuItem.Enabled = activate;
            вЭксельToolStripMenuItem.Enabled = activate;
            заданиеToolStripMenuItem.Enabled = activate;
            button2.Enabled = activate;
            button4.Enabled = activate;
            button5.Enabled = activate;
            button9.Enabled = activate;
            button10.Enabled = activate;
            button11.Enabled = activate;
            button12.Enabled = activate;
            button13.Enabled = activate;
        }

        private void вЭксельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild as ElementForm;
            var se = new SerializableElement(form);
            if (DialogResult.OK == saveExcelDialog.ShowDialog())
                try
                {
                    Serializer.SaveToExcel(se, saveExcelDialog.FileName);
                    MessageBox.Show("Готово!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось сохранить");
                }
        }

        private void вВордToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = ActiveMdiChild as ElementForm;
            var se = new SerializableElement(form);
            if (DialogResult.OK == saveWordDialog.ShowDialog())
                try
                {
                    Serializer.SaveToWord(se, saveWordDialog.FileName);
                    MessageBox.Show("Готово!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Не удалось сохранить");
                }
        }

        private void button9_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ElementForm)
                .очиститьToolStripMenuItem.PerformClick();

        private void button10_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ElementForm)
                .распознатьToolStripMenuItem.PerformClick();

        private void button11_Click(object sender, EventArgs e) =>
            (ActiveMdiChild as ElementForm)
                .построитьДиаграммуToolStripMenuItem.PerformClick();

        private void суммаВыделеныхЯчеекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = (ActiveMdiChild as ElementForm).table;
            var sel = table.SelectedCells.OfType<DataGridViewCell>()
                .Where(x => x.Value != null)
                .Where(x => double.TryParse(x.Value.ToString(), NumberStyles.Any,
                    CultureInfo.InvariantCulture, out var r))
                .Select(x => double.Parse(x.Value.ToString(), NumberStyles.Any,
                    CultureInfo.InvariantCulture));
            if (!sel.Any())
                MessageBox.Show("Не содержит цифр");
            else
                MessageBox.Show("Сумма цифр в выделеных ячейках: " + sel.Sum());
        }

        private void словаНаБуквуАToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var table = (ActiveMdiChild as ElementForm).table;
            var sel = table.SelectedCells.OfType<DataGridViewCell>()
                .Where(x => x.Value != null)
                .Select(x => x.Value as string);
            var s = sel.SelectMany(x => Regex.Split(x, @"\W"))
                .Where(x => Regex.IsMatch(x, @"^[aAаА](\W?)"));
            var cc = new ChooseCell(table.ColumnCount, table.RowCount);
            if (!s.Any())
                MessageBox.Show("Не содержит слов на букву 'A'");
            else if (DialogResult.OK == cc.ShowDialog())
                table.Rows[cc.rowValue].Cells[cc.cellValue].Value = string.Join(" ", s);
        }
    }
}

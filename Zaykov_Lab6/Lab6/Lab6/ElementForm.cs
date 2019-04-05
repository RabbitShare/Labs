using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab6
{
    public partial class ElementForm : Form
    {
        private Regex digitRegex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");

        public string Path { get; set; }

        public bool IsEdit { get; set; } = false;

        public ElementForm(string name)
        {
            InitializeComponent();
            Text = name;
            table.ColumnCount = 20;
            table.RowCount = 25;
            WindowState = FormWindowState.Maximized;
        }

        public DialogResult Save()
        {
            if (Path == null)
                if (DialogResult.OK == saveAquaDialog.ShowDialog())
                {
                    Path = saveAquaDialog.FileName;
                    Text = Path.Split('\\').Last();
                }
                else
                    return DialogResult.Cancel;
            try
            {
                Serializer.SaveElementForm(this);
                IsEdit = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно сохранить файл");
            }
            return DialogResult.OK;
        }

        public ElementForm(SerializableElement se)
        {
            InitializeComponent();
            Text = se.Text;
            Path = se.Path;
            table.ColumnCount = se.Matrix.Max(x => x.i) > 20 ? se.Matrix.Max(x => x.i) : 20;
            table.RowCount = se.Matrix.Max(x => x.j) > 25 ? se.Matrix.Max(x => x.j) : 25;
            foreach (var (j, i, value) in se.Matrix)
                table[j, i].Value = value;
            WindowState = FormWindowState.Maximized;
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell item in table.SelectedCells)
                item.Value = null;
        }

        private void распознатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = table.SelectedCells.OfType<DataGridViewCell>()
                .Where(c => c.Value != null)
                .Select(c => c.Value.ToString());
            if (sel.Count() == 0)
            {
                MessageBox.Show("Пусто");
                return;
            }
            var anyString = sel.Any(s => !digitRegex.IsMatch(s));
            var anyDigit = sel.Any(s => digitRegex.IsMatch(s));
            MessageBox.Show($"{(anyString ? "Содержит строки" : "")}\n{(anyDigit ? "Содержит цифры" : "")}");
        }

        private void построитьДиаграммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = table.SelectedCells.OfType<DataGridViewCell>()
                .Where(c => c.Value != null)
                .Select(c => c.Value.ToString());
            if (sel.Count() == 0)
            {
                MessageBox.Show("Пусто");
                return;
            }
            if (!sel.All(s => digitRegex.IsMatch(s)))
            {
                MessageBox.Show("Диаграмма строится только по цифрам");
                return;
            }
            var diag = new Diagramm(table);
            diag.Show(MdiParent);
        }

        private void ElementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsEdit)
            {
                var exit = MessageBox.Show($"Сохранить таблицу '{Text}' перед закрытием?",
                "Подтверждение на сохранение", MessageBoxButtons.YesNoCancel);
                if (DialogResult.Yes == exit)
                {
                    if (DialogResult.Cancel == Save())
                        e.Cancel = true;
                }
                else if (DialogResult.Cancel == exit)
                    e.Cancel = true;
            }
        }

        private void table_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e) =>
            IsEdit = true;
    }
}
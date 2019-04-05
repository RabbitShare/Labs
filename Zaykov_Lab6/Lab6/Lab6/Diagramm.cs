using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Diagramm : Form
    {
        public Diagramm()
        {
            InitializeComponent();
        }
        DataGridViewSelectedCellCollection items;
        private Regex digitRegex = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public Diagramm(DataGridView dataGrid)
        {
            InitializeComponent();
            this.items = dataGrid.SelectedCells;
            dataGrid.CellValueChanged += Edit;
            var items = ChangeValue();
            foreach (var cell in items)
                chart1.Series["Циферки"].Points.AddXY(cell, cell);
        }
        private IEnumerable<string> ChangeValue()
        {
            return items
                .OfType<DataGridViewCell>()
                .Select(x=> x.EditedFormattedValue.ToString())
                .Where(x => digitRegex.IsMatch(x))
                .Reverse();
        }
        public void Edit(object sender, DataGridViewCellEventArgs e)
        {
            chart1.Series["Циферки"].Points.Clear();

            var items = ChangeValue();
            foreach (var cell in items)
                chart1.Series["Циферки"].Points.AddXY(cell, cell);
        }
    }
}

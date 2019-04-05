using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class ChooseCell : Form
    {
        public int rowValue;
        public int cellValue;
        public ChooseCell(int rowCount, int columnCount)
        {
            InitializeComponent();
            row.Maximum = rowCount - 1;
            cell.Maximum = columnCount - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void column_ValueChanged(object sender, EventArgs e)
        {
            rowValue = (int)row.Value;
            cellValue = (int)cell.Value;
        }
    }
}

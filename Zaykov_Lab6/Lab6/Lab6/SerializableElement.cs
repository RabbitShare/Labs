using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using El = System.Collections.Generic.List<(int j, int i, string value)>;

namespace Lab6
{
    [Serializable]
    public class SerializableElement
    {
        public El Matrix { get; } = new El();
        public string Text { get; }
        public string Path { get; }

        public SerializableElement()
        {
        }
        public SerializableElement(ElementForm ef)
        {
            Text = ef.Text;
            Path = ef.Path;
            for (int i = 0; i < ef.table.RowCount; i++)
                for (int j = 0; j < ef.table.ColumnCount; j++)
                    if (ef.table[j, i].EditedFormattedValue == null)
                        continue;
                    else
                        Matrix.Add((j, i, ef.table[j, i].EditedFormattedValue.ToString()));
        }
    }
}

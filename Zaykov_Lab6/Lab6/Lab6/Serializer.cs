using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Lab6
{
    static class Serializer
    {
        public static void SaveElementForm(ElementForm form)
        {
            var se = new SerializableElement(form);
            var bf = new BinaryFormatter();
            using (var sw = new FileStream(form.Path, FileMode.OpenOrCreate))
                bf.Serialize(sw, se);
        }

        public static ElementForm LoadElementForm(string path)
        {
            var bf = new BinaryFormatter();
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                return new ElementForm(bf.Deserialize(fs) as SerializableElement);
        }

        public static void SaveToExcel(SerializableElement se, string path)
        {
            var excelApp = new Excel.Application();
            var workbook = excelApp.Workbooks.Add();
            var worksheet = (Excel.Worksheet)workbook.Worksheets.Item[1];
            worksheet.Name = se.Text.Split('.').First();

            foreach (var (j, i, value) in se.Matrix)
                worksheet.Cells[j + 1, i + 1] = value;

            workbook.SaveAs(path);
            workbook.Close();

            excelApp.Quit();
        }

        public static void SaveToWord(SerializableElement se, string path)
        {
            var wordApp = new Word.Application();

            var documentWord = wordApp.Documents.Add();
            var wordRange = documentWord.Range();
            var wordTable = documentWord.Tables.Add(
                wordRange, 
                se.Matrix.Max(x => x.j), 
                se.Matrix.Max(x => x.i));

            wordTable.set_Style("Сетка таблицы");

            foreach (var (j, i, value) in se.Matrix)
                wordTable.Cell(j + 1, i + 1).Range.Text = value;

            documentWord.SaveAs2(path);
            documentWord.Close();

            wordApp.Quit();
        }
    }
}

using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace homework_1_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int columns = 4;
            int rows = dataGridView2.RowCount;

            Word.Application application = new Word.Application();
            Object missing = Type.Missing;
            application.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            Word.Document document = application.ActiveDocument;
            Word.Range range = application.Selection.Range;
            Object behiavor = Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object autoFitBehiavor = Word.WdAutoFitBehavior.wdAutoFitFixed;
            document.Tables.Add(range, rows, columns, ref behiavor, ref autoFitBehiavor);
            //Заголовок
            document.Tables[1].Cell(1, 1).Range.Text = "Название";
            document.Tables[1].Cell(1, 2).Range.Text = "количество";
            document.Tables[1].Cell(1, 3).Range.Text = "цена";
            document.Tables[1].Cell(1, 4).Range.Text = "сумма";
            //ориентация страницы
            document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

            for (int j = 0; j < rows - 1; j++)
            {
                for (int i = 1; i < columns; i++)
                {
                    document.Tables[1].Cell(j + 2, i + 1).Range.Text = dataGridView2[i, j].Value.ToString();
                }
            }
            application.Visible = true;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView2.Rows.Add("sxfdf", "5", "500", "2500");
            this.dataGridView2.Rows.Add("доски", "2", "100", "200");
        }
    }

}

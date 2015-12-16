using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PROYECTO_UB
{
    class global
    {
        static public void GridAExcel(DataGridView ElGrid)
        {

            Microsoft.Office.Interop.Excel.Application exApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook exLibro = default(Microsoft.Office.Interop.Excel.Workbook);
            Microsoft.Office.Interop.Excel.Worksheet exHoja = default(Microsoft.Office.Interop.Excel.Worksheet);

            //Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add();
            exHoja = exLibro.Worksheets.Add();

            // ¿Cuantas columnas y cuantas filas?
            int NCol = ElGrid.ColumnCount;
            int NRow = ElGrid.RowCount;

            //Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            for (int i = 1; i <= NCol; i++)
            {

                exHoja.Cells[1, i] = ElGrid.Columns[i - 1].Name.ToString();
                //exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            }

            for (int Fila = 0; Fila <= NRow - 1; Fila++)
            {
                for (int Col = 0; Col <= NCol - 1; Col++)
                {
                    exHoja.Cells.Item[Fila + 2, Col + 1] = ElGrid.Rows[Fila].Cells[Col].Value;
                }
            }
            //Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
            exHoja.Rows.Item[1].Font.Bold = 1;
            exHoja.Rows.Item[1].HorizontalAlignment = 3;
            exHoja.Columns.AutoFit();


            //Aplicación visible
            exApp.Application.Visible = true;

            exHoja = null;
            exLibro = null;
            exApp = null;
        }

    }
}

using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UB
{
    public partial class Codigo_Barra : Form
    {
        ClasePlanificacion objPlan = new ClasePlanificacion();
        public Codigo_Barra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "*" + this.textBox1.Text + "*";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PaperSize Tamaño = default(System.Drawing.Printing.PaperSize);
            Tamaño = new System.Drawing.Printing.PaperSize("tamaño", 850, 1100);//tamaño de hoja carta
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            PrintPreviewDialog verPapel = new PrintPreviewDialog();//creando objeto de vista previa
            printDoc.DefaultPageSettings.PaperSize = Tamaño;
            printDoc.DefaultPageSettings.Landscape = false;//que la hoja sea de tamaño vertical si le pongo verdadero cambia a horizaontal
            verPapel.Document = printDoc;
            ((Form)verPapel).WindowState = FormWindowState.Maximized;//cuando se despliegue la vista previa que sea maximizada
            verPapel.PrintPreviewControl.Zoom = 1.3;//que el zoom sea de 1.3
            verPapel.ShowDialog();
        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, 20, 30);
            Pen blackPen = new Pen(Color.Black, 1);//

            e.Graphics.DrawRectangle(blackPen, 10, 95, 700, 20);
            e.Graphics.DrawLine(blackPen, 80, 80, 80, 80);




            Point point1 = new Point(100, 100);
            Point point2 = new Point(500, 100);


            e.Graphics.DrawLine(blackPen, point1, point2);



            Rectangle destRect1 = new Rectangle(70, 1, 200, 200);


            int x = 0;
            int y = 0;
            int width = 200;
            int height = 200;
            GraphicsUnit units = GraphicsUnit.Pixel;




        }

        private void Codigo_Barra_Load(object sender, EventArgs e)
        {
            ListarPlanificaciones();
        }
        private void ListarPlanificaciones()
        {
            dataGridView1.DataSource = objPlan.Listado();
        }
    }
}

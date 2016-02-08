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
        string nombre_C = "";
        string cod_R= "";
        string nombre_R = "";
        string rut_p = "";
        public Codigo_Barra()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
           if (this.textBox1.Text =="")
                {
                MessageBox.Show("Seleccione Planificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
                return;
                }
            if (this.label1.Text == "")
                {
                    MessageBox.Show("convierta el codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.label1.Focus();
                    return;
                }
            if (this.txt_cantidad.Text == "SELECCIONAR")
                    {
                        MessageBox.Show("ingrese cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_cantidad.Focus();
                        return;
                    }
            
           
       
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
          
            for (int i = 5; i < 6; i++)
            {
              

                for ( int a = 1; a < System.Int32.Parse(txt_cantidad.Text)+1; a++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black,i*10, a*80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 45, 20);
   
                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
             
                }
                for (int s =1; s < System.Int32.Parse(txt_cantidad.Text) + 1; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 40, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 200, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
                for (int s = 1; s < System.Int32.Parse(txt_cantidad.Text) + 1; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 70, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 355, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
                for (int s = 1; s < System.Int32.Parse(txt_cantidad.Text) + 1; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 100, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 510, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
                for (int s = 1; s < System.Int32.Parse(txt_cantidad.Text) + 1; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 130, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 655, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
                //**************************************************************************************************************************************
                for (int a = 5; a < System.Int32.Parse(txt_cantidad.Text) + 5; a++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 10, a * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 45, 360);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;

                }
                for (int s = 5; s < System.Int32.Parse(txt_cantidad.Text) + 5; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 40, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 200, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
                for (int s = 5; s < System.Int32.Parse(txt_cantidad.Text) + 5; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 70, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 355, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
                for (int s = 5; s < System.Int32.Parse(txt_cantidad.Text) + 5; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 100, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 510, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
                for (int s = 5; s < System.Int32.Parse(txt_cantidad.Text) + 5; s++)
                {

                    e.Graphics.DrawString(this.label1.Text, new Font("Bar-Code 39 lesbar", 26, FontStyle.Regular), Brushes.Black, i * 130, s * 80);
                    e.Graphics.DrawString(nombre_C, new Font("arial", 11, FontStyle.Regular), Brushes.Black, 655, 20);

                    Pen blackPen = new Pen(Color.Black, 1);//


                    Point point1 = new Point(50, 50);
                    Point point2 = new Point(150, 50);
                    e.Graphics.DrawLine(blackPen, point1, point2);

                    int x = 0;
                    int y = 0;
                    int width = 200;
                    int height = 200;
                    GraphicsUnit units = GraphicsUnit.Pixel;
                }
            }

        }

        private void Codigo_Barra_Load(object sender, EventArgs e)
        {
            ListarPlanificaciones();
            llenarCombobox();
        }
        private void llenarCombobox()
        {

            this.txt_cantidad.Items.Add("SELECCIONAR");
            txt_cantidad.Items.Add("1");
            txt_cantidad.Items.Add("2");
            txt_cantidad.Items.Add("3");
            //txt_cantidad.Items.Add("4");
            //txt_cantidad.Items.Add("5");
            //txt_cantidad.Items.Add("6");
            //txt_cantidad.Items.Add("7");
            //txt_cantidad.Items.Add("8");
            //txt_cantidad.Items.Add("9");
            //txt_cantidad.Items.Add("10");
            //txt_cantidad.Items.Add("11");
            //txt_cantidad.Items.Add("12");
            //txt_cantidad.Items.Add("13");

            txt_cantidad.SelectedIndex = 0;

        
        }

        private void ListarPlanificaciones()
        {
            dataGridView1.DataSource = objPlan.Listado();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int i = 0;
         /*  if (this.textBox1.Text == "")
            {
              MessageBox.Show("Seleccione Planificacion para convertit ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else {label1.Text = "*" + this.textBox1.Text + "*"; }
           /**********************/
            
            
            DataTable dt=new DataTable();
            
            for (i = 0; i < dt.Rows.Count; i++)
            {
                dt = objPlan.Listado();
                label1.Text = "*" + dt.Rows[i].ItemArray[0].ToString() + "*";
              
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nombre_C = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            cod_R = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            nombre_R = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            rut_p= dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            global.GridAExcel(dataGridView1);
        }

        private void txt_cantidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

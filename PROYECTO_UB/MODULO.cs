
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UB
{
    public partial class MODULO : Form
    {
        ClaseModulo objmo = new ClaseModulo();

        public MODULO()
        {
            InitializeComponent();
        }

        private void MODULO_Load(object sender, EventArgs e)
        {
            ListarModulo();
            llenarCombobox();
            this.TXT_COD.Text = objmo.MAYOR().ToString();
        }
        private void ListarModulo()
        {
            dataGridView1.DataSource = objmo.Listado();
        }
        private void llenarCombobox()
        {


            CB_INICIO.Items.Add("08:00");
            CB_INICIO.Items.Add("08:45");
            CB_INICIO.Items.Add("00:40");
            CB_INICIO.Items.Add("10:25");
            CB_INICIO.Items.Add("11:20");
            CB_INICIO.Items.Add("12:05");
            CB_INICIO.Items.Add("12:50");
            CB_INICIO.Items.Add("14:00");
            CB_INICIO.Items.Add("14:45");
            CB_INICIO.Items.Add("15:40");
            CB_INICIO.Items.Add("16:25");
            CB_INICIO.Items.Add("17:20");
            CB_INICIO.Items.Add("18:05");
            CB_INICIO.Items.Add("19:00");
            CB_INICIO.Items.Add("19:45");
            CB_INICIO.Items.Add("20:40");
            CB_INICIO.Items.Add("21:25");



            CB_FIN.Items.Add("08:45");
            CB_FIN.Items.Add("09:30");
            CB_FIN.Items.Add("10:25");
            CB_FIN.Items.Add("11:10");
            CB_FIN.Items.Add("12:05");
            CB_FIN.Items.Add("12:50");
            CB_FIN.Items.Add("14:00");
            CB_FIN.Items.Add("14:45");
            CB_FIN.Items.Add("15:30");
            CB_FIN.Items.Add("16:25");
            CB_FIN.Items.Add("17:10");
            CB_FIN.Items.Add("18:05");
            CB_FIN.Items.Add("18:50");
            CB_FIN.Items.Add("19:45");
            CB_FIN.Items.Add("20:30");
            CB_FIN.Items.Add("21:25");
            CB_FIN.Items.Add("22:10");




            CB_DIA.Items.Add("LUNES");
            CB_DIA.Items.Add("MARTES");
            CB_DIA.Items.Add("MIERCOLES");
            CB_DIA.Items.Add("JUEVES");
            CB_DIA.Items.Add("VIERNES");
            CB_DIA.Items.Add("SABADO");
        }

     

        private void btn_excel_Click(object sender, EventArgs e)
        {
            global.GridAExcel(dataGridView1);
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {


            if (this.CB_INICIO.Text == "")
            {
                MessageBox.Show("Ingrese el inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CB_INICIO.Focus();
                return;
            }
            if (this.CB_FIN.Text == "")
            {
                MessageBox.Show("Ingrese el fin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CB_FIN.Focus();
                return;
            }
            if (this.CB_DIA.Text == "")
            {
                MessageBox.Show("Ingrese el DIA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CB_DIA.Focus();
                return;
            }

            objmo.codigo = int.Parse(this.TXT_COD.Text);
            objmo.inicio = CB_INICIO.Text;
            objmo.fin = CB_FIN.Text;
            objmo.dia = CB_DIA.Text;

            MessageBox.Show(objmo.RegistrarModulo(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarModulo();
            //Limpiar();
        }

    }
}

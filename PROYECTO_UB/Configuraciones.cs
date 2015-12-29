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
    public partial class Configuraciones : Form
    {
       
        ClaseConfiguracion claseConf = new ClaseConfiguracion();
        
        public Configuraciones()
        {
            InitializeComponent();
        }
       
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (txt_anio.Text == "")
            {
                MessageBox.Show("Ingrese el Año", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_anio.Focus();
                return;
            }

           // claseConf.anio = txt_anio.Text;
            //claseConf.periodo = txt_periodo.Text;
            claseConf.ActualizarConfiguracion(int.Parse(txt_anio.Text), int.Parse(cBox_periodo.Text));
            MessageBox.Show(claseConf.ActualizarConfiguracion(int.Parse(txt_anio.Text), int.Parse(cBox_periodo.Text)), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Configuracion.datos();
           // Limpiar();
        }

        private void Configuraciones_Load(object sender, EventArgs e)
        {
            llenarComboPeriodo();
            Configuracion.datos();
            txt_anio.Text = Configuracion.anio.ToString();
            cBox_periodo.Text = Configuracion.periodo.ToString();
        }
        private void llenarComboPeriodo() {
           
            cBox_periodo.Items.Add("1");
            cBox_periodo.Items.Add("2");
        }
    }
}

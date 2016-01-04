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
    public partial class HORARIO : Form
    {
        public HORARIO()
        {
            InitializeComponent();
        }

        private void btn_ag_pla_Click(object sender, EventArgs e)
        {
            BuscarPlanificaciones obj = new BuscarPlanificaciones();
            obj.ShowDialog();
        }

        private void btn_ag_carre_Click(object sender, EventArgs e)
        {
            Buscar_Modulo obj = new Buscar_Modulo();
            obj.ShowDialog();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_rut.Text == "" || txt_dv.Text == "")
            {
                MessageBox.Show("Ingrese el rut", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_rut.Focus();
                return;
            }

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombre.Focus();
                return;
            }
            if (this.txt_app.Text == "")
            {
                MessageBox.Show("Ingrese Apellido paterno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_app.Focus();
                return;
            }

            if (txt_apm.Text == "")
            {
                MessageBox.Show("Ingrese Apellido materno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_apm.Focus();
                return;
            }


            objPlan.rut = txt_rut.Text;
            objPlan.codigoC = txt_m.Text;
            objPlan.codigoR = txt_cod_asig.Text;
            objPlan.seccion = int.Parse(txt_seccion.Text);
            objPlan.anio = int.Parse(label_anio.Text);
            objPlan.periodo = int.Parse(labelperiodo.Text);
            MessageBox.Show(objPlan.RegistrarPlanificacion(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarPlanificaciones();
            Limpiar();
        }
    }
}

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
    public partial class Planificaciones : Form
    {
       private ClaseProfesores p = new ClaseProfesores();
       private ClaseRamos r = new ClaseRamos();
       private ClaseCarreras c = new ClaseCarreras();
        public Planificaciones()
        {
            InitializeComponent();
        }

        private void btn_ag_banco_Click(object sender, EventArgs e)
        {
            Buscar_Per obj = new Buscar_Per();
            obj.ShowDialog();
            paso();
            txt_rut.Focus();
          
        }
       private  void paso() {
         
           txt_rut.Text = Buscar_Per.rut;
        
        }
        private void Planificaciones_Load(object sender, EventArgs e)
        {
            llenar();
        }
        private void llenar()
        {
            c_box_ramo.DataSource = r.Listado();
            c_box_ramo.ValueMember = "CODIGO";
            c_box_ramo.DisplayMember = "RAMO";

            c_box_carrera.DataSource = c.Listado();
            c_box_carrera.ValueMember = "CODIGO";
            c_box_carrera.DisplayMember = "CARRERA";
                       
         }
        private void txt_rut_KeyPress(object sender, KeyPressEventArgs e)
        {
            
         

        }
    }
}

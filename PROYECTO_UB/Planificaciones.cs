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

        }
    }
}

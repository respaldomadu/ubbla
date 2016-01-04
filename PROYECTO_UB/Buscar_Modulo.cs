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
    public partial class Buscar_Modulo : Form
    {
        ClaseModulo objmo = new ClaseModulo();
        public Buscar_Modulo()
        {
            InitializeComponent();
        }

        private void Buscar_Modulo_Load(object sender, EventArgs e)
        {
            ListarModulo();
        
        }
        private void ListarModulo()
        {
            dataGridView1.DataSource = objmo.Listado();
        }
    }
}

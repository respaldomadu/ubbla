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
    public partial class Buscar_Profesor : Form
    {
        private ClaseProfesores objProfesor = new ClaseProfesores();
       private Planificaciones form = new Planificaciones();
       public static string rut = "";
       
        public Buscar_Profesor()
        {
            InitializeComponent();
        }
        private void ListarProfesores()
        {
            dataGridView1.DataSource = objProfesor.Listado();
        }
        private void Buscar_Profesor_Load(object sender, EventArgs e)
        {
            ListarProfesores();
            rut = "";
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rut = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }
    }
}

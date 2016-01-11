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
    public partial class HORARIO : Form
    {
        ClaseHorario objh = new ClaseHorario();
     
        private ClasePlanificacion objPlan = new ClasePlanificacion();
        private ClaseModulo objM = new ClaseModulo();
        public HORARIO()
        {
            InitializeComponent();
        }

        private void btn_ag_pla_Click(object sender, EventArgs e)
        {
            BuscarPlanificaciones obj = new BuscarPlanificaciones();
            obj.ShowDialog();

          
            this.txt_cod_pla.Text = BuscarPlanificaciones.codp;
            DataTable dt = new DataTable();
            dt = objPlan.Cargar(txt_cod_pla.Text);

            if (dt.Rows.Count == 1)
            {
             //  this.txt_cod_pla.Text = dt.Rows[0].ItemArray[0].ToString();
                this.txt_ru.Text = dt.Rows[0].ItemArray[6].ToString();
                this.txt_c.Text = dt.Rows[0].ItemArray[1].ToString();
                this.txt_a.Text = dt.Rows[0].ItemArray[3].ToString();
                this.txt_se.Text = dt.Rows[0].ItemArray[13].ToString();
            }

        }

        private void btn_ag_carre_Click(object sender, EventArgs e)
        {
            Buscar_Modulo objm = new Buscar_Modulo();
            objm.ShowDialog();

            this.txt_m.Text = Buscar_Modulo.codigo;
            DataTable dt = new DataTable();
           

        }
        private void ListarHorario()
        {
            dataGridView1.DataSource = objh.Listado();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (this.txt_cod_pla.Text=="")
            {
                MessageBox.Show("seleccione la planificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cod_pla.Focus();
                return;
            }

            if (this.txt_m.Text == "")
            {
                MessageBox.Show("seleccione el modulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_m.Focus();
                return;
            }
            if (this.fecha.Text == "")
            {
                MessageBox.Show("Ingrese Fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fecha.Focus();
                return;
            }
            
            
                objh.codigo_h = int.Parse(label6.Text);
            objh.codigo_pla = int.Parse(txt_cod_pla.Text);
            objh.codigo_mo=int.Parse(txt_m.Text);
            objh.fecha = this.fecha.Text;
  
            objh.estado = "ACTIVO";

            MessageBox.Show(objh.RegistrarHorario(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarHorario();
            //Limpiar();
        
        }

        private void HORARIO_Load(object sender, EventArgs e)
        {
            this.label6.Text = objh.MAYOR().ToString();
            ListarHorario();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txt_cod_pla.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.txt_m.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.txt_ru.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.txt_a.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            this.txt_c.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            this.txt_se.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            this.fecha.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
           
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_agregar.Enabled = false;
            btn_limpiar.Enabled = true;
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

            if (this.txt_cod_pla.Text == "")
            {
                MessageBox.Show("seleccione la planificacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_cod_pla.Focus();
                return;
            }

            if (this.txt_m.Text == "")
            {
                MessageBox.Show("seleccione el modulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_m.Focus();
                return;
            }
            if (this.fecha.Text == "")
            {
                MessageBox.Show("Ingrese Fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fecha.Focus();
                return;
            }
            objh.codigo_h = int.Parse(label6.Text);
            objh.codigo_pla = int.Parse(txt_cod_pla.Text);
            objh.codigo_mo = int.Parse(txt_m.Text);
            objh.fecha = this.fecha.Text;

            objh.estado = "ACTIVO";

            MessageBox.Show(objh.ActualizarHorario(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ListarHorario();
            //Limpiar();
        }

        
    }
}

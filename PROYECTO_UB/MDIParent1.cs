﻿using System;
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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mantenedorRamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ramos obj = new Ramos();
            obj.ShowDialog();
           
        }

        private void mantenedorCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carreras obj = new Carreras();
            obj.ShowDialog();
        }

        private void mantenedorProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores obj = new Profesores();
            obj.ShowDialog();
        }

        private void mantenedorBancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bancos obj = new Bancos();
            obj.ShowDialog();
        }

        private void mantenedorComunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Comunas obj = new Comunas();
          obj.ShowDialog();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mantenedorTipoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TIPO_CUENTAS obj = new TIPO_CUENTAS();
            obj.ShowDialog();
        }

        private void mantenedorNacionalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nacionalidad obj = new Nacionalidad();
            obj.ShowDialog();
        }

        

        private void mantenedorPlanificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planificaciones obj = new Planificaciones();
            obj.ShowDialog();
        }

        private void mantenedorConfiguracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuraciones obj = new Configuraciones();
            obj.ShowDialog();
        }

        private void mantenedorModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MODULO obj = new MODULO();
            obj.ShowDialog();
        }

        private void mantenedorHorarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HORARIO obj = new HORARIO();
            obj.ShowDialog();
        }

        private void mantenedorAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asistencia obj = new Asistencia();
            obj.ShowDialog();
        }

        private void generadorCodigosDeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Codigo_Barra obj = new Codigo_Barra();
            obj.ShowDialog();
        }

        private void buscarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarAsistencia obj = new BuscarAsistencia();
            obj.ShowDialog();
        }
    }
}

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
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void btn_ag_comuna_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_ag_banco_Click(object sender, EventArgs e)
        {
            Bancos obj = new Bancos();
            obj.ShowDialog();
            CargarBanco();
          
        }
        private void CargarBanco()
        { 
        
        
        
        
        }
        private void Profesores_Load(object sender, EventArgs e)
        {

        }
    }
}

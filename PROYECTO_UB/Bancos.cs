using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace PROYECTO_UB
{
    public partial class Bancos : Form
    {
        private ClaseBanco objbanco = new ClaseBanco();
        public Bancos()
        {
            InitializeComponent();
        }

        private void Bancos_Load(object sender, EventArgs e)
        {

        }
    }
}

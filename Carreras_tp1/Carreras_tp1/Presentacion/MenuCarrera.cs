using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Carreras_tp1.Presentacion;

namespace Carreras_tp1
{
    public partial class MenuCarrera : Form
    {
        public MenuCarrera()
        {
            InitializeComponent();
        }

        private void nuevaCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new NuevaCarrera();
            frm.ShowDialog();
        }

        private void consultarCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new ConsultarCarreras();
            frm1.ShowDialog();
        }

        private void cargarAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm2 = new AgregarAsignaturas();
            frm2.ShowDialog();
        }

        private void asignaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm3 = new Asignaturas();
            frm3.ShowDialog();
        }
    }
}

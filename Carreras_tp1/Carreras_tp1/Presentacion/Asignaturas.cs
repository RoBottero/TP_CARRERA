using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras_tp1.Presentacion
{
    public partial class Asignaturas : Form
    {
        public Asignaturas()
        {
            InitializeComponent();
        }

        private void Asignaturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetAsignaturas.Asignaturas' Puede moverla o quitarla según sea necesario.
            this.asignaturasTableAdapter.Fill(this.dataSetAsignaturas.Asignaturas);

            this.reportViewer1.RefreshReport();
        }
    }
}

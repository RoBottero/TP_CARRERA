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
    public partial class ConsultarCarreras : Form
    {
        AccesoDatos oBD = new AccesoDatos();
        public ConsultarCarreras()
        {
            InitializeComponent();
        }

        

        private void ConsultarCarreras_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }

        private void cargarCombo()
        {
            DataTable t = new DataTable();
            t = oBD.Consultar_SP("sp_consultar_carreras");
            cboSeleccioneCarr.DataSource = t;
            cboSeleccioneCarr.ValueMember = t.Columns[0].ColumnName;
            cboSeleccioneCarr.DisplayMember = "nombre";
            cboSeleccioneCarr.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboSeleccioneCarr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

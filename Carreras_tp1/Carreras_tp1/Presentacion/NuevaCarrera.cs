using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras_tp1
{
    public partial class NuevaCarrera : Form
    {
        Carrera nueva = new Carrera();
        AccesoDatos oBD = new AccesoDatos();
        public NuevaCarrera()
        {
            InitializeComponent();
        }

        private void NuevaCarrera_Load(object sender, EventArgs e)
        {
            cargarCombo();
            //proximaCarrera();
        }
        private void proximaCarrera()
        {
            int next = oBD.proximoId();
            if (next > 0)
                lblNuevaCarrera.Text = "Nueva Carrera Nº: " + next.ToString();
            else
                MessageBox.Show("No se puede crear un nuevo N° de carrera!", "Error");
        }
        private void cargarCombo()
        {
            DataTable t = new DataTable();
            t = oBD.Consultar_SP("sp_consultar_asignaturas");
            cboMaterias.DataSource = t;
            cboMaterias.ValueMember = t.Columns[0].ColumnName;
            cboMaterias.DisplayMember = "nombre";
            cboMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool validarDatos()
        {
            if (txtCarrera.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un nombre para la carrera");
                txtCarrera.Focus();
                return false;
            }
            if (cboMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una materia para la carrera");
                cboMaterias.Focus();
                return false;
            }
            if (txtAño.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un año de cursado");
                txtAño.Focus();
                return false;
            }
            if (!rbtPrimerCuatri.Checked && !rbtSegundoCuatri.Checked)
            {
                MessageBox.Show("Seleccione un cuatrimestre");
                rbtPrimerCuatri.Focus();
                return false;
            }
            return true;
        }
        private void txtNombreCarrera_TextChanged(object sender, EventArgs e)
        {
            nueva.Nombre_Titulo = txtCarrera.Text;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text == "")
            {
                MessageBox.Show("Ingrese el nombre de la carrera",
                "Atención", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            oBD.AltaCarrera(nueva);

            MessageBox.Show("La carrera ha sido agregada", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtgCarreras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCarreras.CurrentCell.ColumnIndex == 5)
            {
                nueva.EliminarDetalle(dtgCarreras.CurrentCell.RowIndex);
                dtgCarreras.Rows.Remove(dtgCarreras.CurrentRow);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                foreach (DetalleCarrera dc in nueva.DetallesCarrera)
                {
                    if (dc.Materia.Nombre == cboMaterias.Text)
                    {
                        MessageBox.Show("Solo puede agregar una vez cada materia", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                Asignatura asignatura = new Asignatura();
                asignatura.Codigo = Convert.ToInt32(cboMaterias.SelectedValue);
                asignatura.Nombre = cboMaterias.Text;
                int anioCursado = int.Parse(txtAño.Text);
                int cuatrimestre = 0;
                if (rbtPrimerCuatri.Checked) cuatrimestre = 1;
                if (rbtSegundoCuatri.Checked) cuatrimestre = 2;

                DetalleCarrera detCarrera = new DetalleCarrera(anioCursado, cuatrimestre, asignatura);
                nueva.AgregarDetalle(detCarrera);
                dtgCarreras.Rows.Add(new Object[] { asignatura.Codigo, asignatura.Nombre, anioCursado, cuatrimestre });
            }
        }
    }
}

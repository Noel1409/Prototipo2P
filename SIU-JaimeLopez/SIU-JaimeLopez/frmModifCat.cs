using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
namespace CapaVista
{
    public partial class frmModifCat : Form
    {
        Controlador contr = new Controlador();
        public frmModifCat()
        {
            InitializeComponent();
            actuGrid();
        }

        private void actuGrid()
        {
            DataTable dt = contr.llenarDGV("maestros");
            dgvAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumno.DataSource = dt;
        }

        private void dgvAlumno_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvAlumno.DataSource != null)
            {
                if (dgvAlumno.CurrentRow == null)
                {
                    return;
                }
                txtCarnet.Text = dgvAlumno.CurrentRow.Cells[0].Value.ToString();
                txtNom.Text = dgvAlumno.CurrentRow.Cells[1].Value.ToString();
                txtDir.Text = dgvAlumno.CurrentRow.Cells[2].Value.ToString();
                txtTel.Text = dgvAlumno.CurrentRow.Cells[3].Value.ToString();
                txtMail.Text = dgvAlumno.CurrentRow.Cells[4].Value.ToString();
                txtEstado.Text = dgvAlumno.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void limpiar()
        {
            txtCarnet.Text = "";
            txtNom.Text = "";
            txtDir.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            txtEstado.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDir.Text = null;
            txtMail.Text = null;
            txtNom.Text = null;
            txtTel.Text = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string[] campos = { "codigo_maestro", "nombre_maestro", "direccion_maestro"
                    , "telefono_maetro","email_maestro","estatus_maestro" };
            string[] datos = { txtCarnet.Text, txtNom.Text, txtDir.Text,
            txtTel.Text, txtMail.Text, txtEstado.Text };
            string tabla = "maestros";

            bool modRes = contr.modificar(campos, datos, tabla);
            if (modRes)
            {
                MessageBox.Show("Se modifico el maestro con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar al maestro");
            }

            limpiar();
            actuGrid();
        }

        private void btnActuDGV_Click(object sender, EventArgs e)
        {
            actuGrid();
        }
    }
}

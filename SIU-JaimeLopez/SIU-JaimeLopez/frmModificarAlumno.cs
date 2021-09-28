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
    public partial class frmModificarAlumno : Form
    {
        Controlador contr = new Controlador();
        public frmModificarAlumno()
        {
            InitializeComponent();
            actuGrid();
        }

        private void btnActuDGV_Click(object sender, EventArgs e)
        {
            actuGrid();
        }

        private void actuGrid()
        {
            DataTable dt = contr.llenarDGV("alumnos");
            dgvAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumno.DataSource = dt;
        }

        private void dgvAlumno_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvAlumno.DataSource != null)
            {
                if(dgvAlumno.CurrentRow == null)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string[] campos = { "carnet_alumno", "nombre_alumno", "direccion_alumno"
                    , "telefono_alumno","email_alumno","estatus_alumno" };
            string[] datos = { txtCarnet.Text, txtNom.Text, txtDir.Text,
            txtTel.Text, txtMail.Text, txtEstado.Text };
            string tabla = "alumnos";

            bool modRes = contr.modificar(campos,datos,tabla);
            if (modRes)
            {
                MessageBox.Show("Se modifico el alumno con éxito");
            }
            else
            {
                MessageBox.Show("Error al modificar el alumno");
            }

            limpiar();
            actuGrid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDir.Text = null;
            txtMail.Text = null;
            txtNom.Text = null;
            txtTel.Text = null;
        }
    }
}

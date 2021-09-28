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
    public partial class frmElimCat : Form
    {
        Controlador contr = new Controlador();
        public frmElimCat()
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
            limpiar();
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            string campos = "estatus_maestro";
            string datos = "0";
            string tabla = "maestros";
            string campoID = "codigo_maestro";
            string ID = txtCarnet.Text;

            bool elRes = contr.eliminar(campos, datos, tabla, campoID, ID);
            if (elRes)
            {
                MessageBox.Show("Se dio de baja al maestro con éxito");
            }
            else
            {
                MessageBox.Show("Error al dar de baja al maestro");
            }

            limpiar();
            actuGrid();
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

        private void btnActuDGV_Click(object sender, EventArgs e)
        {
            actuGrid();
        }
    }
}

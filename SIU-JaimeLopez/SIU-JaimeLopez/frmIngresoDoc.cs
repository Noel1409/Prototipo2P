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
    public partial class frmIngresoDoc : Form
    {
        Controlador contr = new Controlador();
        public frmIngresoDoc()
        {
            InitializeComponent();
            txtEstado.Text = "1";
        }

        private void btnGCarnet_Click(object sender, EventArgs e)
        {
            string nom = "";
            string dir = "";
            string tel = "";
            nom = txtNom.Text;
            dir = txtDir.Text;
            tel = txtTel.Text;
            if (nom.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (dir.Length == 0)
            {
                MessageBox.Show("Debe ingresar una dirección");
                return;
            }
            if (tel.Length == 0)
            {
                MessageBox.Show("Debe ingresar un teléfono");
                return;
            }

            string carnet = contr.generarCarDocente();
            txtCarnet.Text = carnet;
        }

        private void limpiar()
        {
            txtCarnet.Text = "";
            txtDir.Text = "";
            txtMail.Text = "";
            txtNom.Text = "";
            txtTel.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string carnet = "";
            carnet = txtCarnet.Text;
            if (carnet.Length == 0)
            {
                MessageBox.Show("Debe generar un carnet antes de ingresar");
                return;
            }
            string[] campos = { "codigo_maestro", "nombre_maestro", "direccion_maestro"
                    , "telefono_maetro","email_maestro","estatus_maestro" };
            string[] datos = { txtCarnet.Text, txtNom.Text, txtDir.Text,
            txtTel.Text, txtMail.Text, txtEstado.Text };
            string tabla = "maestros";
            bool ingRes = contr.insertar(campos, datos, tabla);
            if (ingRes)
            {
                MessageBox.Show("Se ingreso el docente con éxito");
            }
            else
            {
                MessageBox.Show("Error al docente el alumno");
            }

            limpiar();
        }
    }
}

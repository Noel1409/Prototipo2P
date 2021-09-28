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
namespace SIU_JaimeLopez
{
    public partial class frmIngresoAlumno : Form
    {
        Controlador contr = new Controlador();
        public frmIngresoAlumno()
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

            string carnet = contr.generarCarnet(nom, tel, dir);
            txtCarnet.Text = carnet;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtCarnet.Text = "";
            txtDir.Text = "";
            txtMail.Text = "";
            txtNom.Text = "";
            txtTel.Text = "";
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
            string[] campos= { "carnet_alumno", "nombre_alumno", "direccion_alumno"
                    , "telefono_alumno","email_alumno","estatus_alumno" };
            string[] datos = { txtCarnet.Text, txtNom.Text, txtDir.Text,
            txtTel.Text, txtMail.Text, txtEstado.Text };
            string tabla = "alumnos";
            bool ingRes = contr.insertar(campos, datos, tabla);
            if (ingRes)
            {
                MessageBox.Show("Se ingreso el alumno con éxito");
            }
            else
            {
                MessageBox.Show("Error al ingresar el alumno");
            }

            limpiar();
        }
    }
}

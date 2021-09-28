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
    public partial class frmConsultaAlumno : Form
    {
        Controlador contr = new Controlador();
        public frmConsultaAlumno()
        {
            InitializeComponent();
            actuGrid();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            actuGrid();
        }
        private void actuGrid()
        {
            DataTable dt = contr.llenarDGV("alumnos");
            dvgAlumno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgAlumno.DataSource = dt;
        }
    }
}

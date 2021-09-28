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
    public partial class frmConsultaMaestro : Form
    {
        Controlador contr = new Controlador();
        public frmConsultaMaestro()
        {
            InitializeComponent();
            actuGrid();
        }

        private void actuGrid()
        {
            DataTable dt = contr.llenarDGV("maestros");
            dvgMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgMaster.DataSource = dt;
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            actuGrid();
        }
    }
}

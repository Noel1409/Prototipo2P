using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVista;
namespace SIU_JaimeLopez
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*string rutaAyudaCHM = "ayudas/ayuda.chm";
            string rutaAyudaHTML = "ayudas/ayuda.html";
            Help.ShowHelp(this, rutaAyudaCHM, rutaAyudaHTML);*/
        }

        private void registroDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoAlumno frm = new frmIngresoAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificaciónDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarAlumno frmModif = new frmModificarAlumno();
            frmModif.MdiParent = this;
            frmModif.Show();
        }

        private void darDeBajaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarAlumno frm = new frmEliminarAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAlumno frm = new frmConsultaAlumno();
            frm.MdiParent = this;
            frm.Show();
        }

        private void consultarMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMaestro frm = new frmConsultaMaestro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ingresarMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoDoc frm = new frmIngresoDoc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modificarMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifCat frm = new frmModifCat();
            frm.MdiParent = this;
            frm.Show();
        }

        private void darDeBajaMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmElimCat frm = new frmElimCat();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

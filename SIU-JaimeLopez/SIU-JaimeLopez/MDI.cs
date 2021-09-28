using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string rutaAyudaCHM = "ayudas/Alumno.chm";
            string rutaAyudaHTML = "ayudas/Alumno.html";
            Help.ShowHelp(this, rutaAyudaCHM, rutaAyudaHTML);
        }

        private void registroDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresoAlumno frm = new frmIngresoAlumno();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

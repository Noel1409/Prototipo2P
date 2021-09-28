
namespace CapaVista
{
    partial class frmConsultaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgAlumno = new System.Windows.Forms.DataGridView();
            this.btnActu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgAlumno
            // 
            this.dvgAlumno.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dvgAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAlumno.Location = new System.Drawing.Point(1, 0);
            this.dvgAlumno.Name = "dvgAlumno";
            this.dvgAlumno.ReadOnly = true;
            this.dvgAlumno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAlumno.Size = new System.Drawing.Size(797, 392);
            this.dvgAlumno.TabIndex = 0;
            // 
            // btnActu
            // 
            this.btnActu.BackColor = System.Drawing.Color.YellowGreen;
            this.btnActu.Location = new System.Drawing.Point(12, 398);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(776, 40);
            this.btnActu.TabIndex = 1;
            this.btnActu.Text = "Actualizar Tabla";
            this.btnActu.UseVisualStyleBackColor = false;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // frmConsultaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.dvgAlumno);
            this.Name = "frmConsultaAlumno";
            this.Text = "Consulta Alumno";
            ((System.ComponentModel.ISupportInitialize)(this.dvgAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgAlumno;
        private System.Windows.Forms.Button btnActu;
    }
}

namespace CapaVista
{
    partial class frmConsultaMaestro
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
            this.btnActu = new System.Windows.Forms.Button();
            this.dvgMaster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActu
            // 
            this.btnActu.BackColor = System.Drawing.Color.Silver;
            this.btnActu.Location = new System.Drawing.Point(13, 404);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(776, 40);
            this.btnActu.TabIndex = 3;
            this.btnActu.Text = "Actualizar Tabla";
            this.btnActu.UseVisualStyleBackColor = false;
            this.btnActu.Click += new System.EventHandler(this.btnActu_Click);
            // 
            // dvgMaster
            // 
            this.dvgMaster.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dvgMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMaster.Location = new System.Drawing.Point(2, 6);
            this.dvgMaster.Name = "dvgMaster";
            this.dvgMaster.ReadOnly = true;
            this.dvgMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMaster.Size = new System.Drawing.Size(797, 392);
            this.dvgMaster.TabIndex = 2;
            // 
            // frmConsultaMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.dvgMaster);
            this.Name = "frmConsultaMaestro";
            this.Text = "Consulta Maestro";
            ((System.ComponentModel.ISupportInitialize)(this.dvgMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.DataGridView dvgMaster;
    }
}
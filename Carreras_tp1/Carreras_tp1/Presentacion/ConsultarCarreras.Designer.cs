namespace Carreras_tp1.Presentacion
{
    partial class ConsultarCarreras
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
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            this.lstDetallesCarrera = new System.Windows.Forms.ListBox();
            this.lblDetCarrera = new System.Windows.Forms.Label();
            this.cboSeleccioneCarr = new System.Windows.Forms.ComboBox();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(-33, -25);
            this.lblNuevaCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(170, 20);
            this.lblNuevaCarrera.TabIndex = 27;
            this.lblNuevaCarrera.Text = "Consultar Carreras";
            // 
            // lstDetallesCarrera
            // 
            this.lstDetallesCarrera.FormattingEnabled = true;
            this.lstDetallesCarrera.ItemHeight = 16;
            this.lstDetallesCarrera.Location = new System.Drawing.Point(24, 170);
            this.lstDetallesCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.lstDetallesCarrera.Name = "lstDetallesCarrera";
            this.lstDetallesCarrera.Size = new System.Drawing.Size(678, 164);
            this.lstDetallesCarrera.TabIndex = 1;
            // 
            // lblDetCarrera
            // 
            this.lblDetCarrera.AutoSize = true;
            this.lblDetCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetCarrera.Location = new System.Drawing.Point(20, 134);
            this.lblDetCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetCarrera.Name = "lblDetCarrera";
            this.lblDetCarrera.Size = new System.Drawing.Size(174, 20);
            this.lblDetCarrera.TabIndex = 25;
            this.lblDetCarrera.Text = "Detalles de la Carrera";
            // 
            // cboSeleccioneCarr
            // 
            this.cboSeleccioneCarr.FormattingEnabled = true;
            this.cboSeleccioneCarr.Location = new System.Drawing.Point(253, 45);
            this.cboSeleccioneCarr.Margin = new System.Windows.Forms.Padding(4);
            this.cboSeleccioneCarr.Name = "cboSeleccioneCarr";
            this.cboSeleccioneCarr.Size = new System.Drawing.Size(449, 24);
            this.cboSeleccioneCarr.TabIndex = 0;
            this.cboSeleccioneCarr.SelectedIndexChanged += new System.EventHandler(this.cboSeleccioneCarr_SelectedIndexChanged);
            // 
            // lblCarreras
            // 
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(20, 45);
            this.lblCarreras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(171, 20);
            this.lblCarreras.TabIndex = 23;
            this.lblCarreras.Text = "Seleccione la Carrera";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(567, 358);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ConsultarCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 419);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Controls.Add(this.lstDetallesCarrera);
            this.Controls.Add(this.lblDetCarrera);
            this.Controls.Add(this.cboSeleccioneCarr);
            this.Controls.Add(this.lblCarreras);
            this.Controls.Add(this.btnSalir);
            this.Name = "ConsultarCarreras";
            this.Text = "ConsultarCarreras";
            this.Load += new System.EventHandler(this.ConsultarCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCarrera;
        private System.Windows.Forms.ListBox lstDetallesCarrera;
        private System.Windows.Forms.Label lblDetCarrera;
        private System.Windows.Forms.ComboBox cboSeleccioneCarr;
        private System.Windows.Forms.Label lblCarreras;
        private System.Windows.Forms.Button btnSalir;
    }
}
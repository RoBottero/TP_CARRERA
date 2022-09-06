namespace Carreras_tp1
{
    partial class NuevaCarrera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtSegundoCuatri = new System.Windows.Forms.RadioButton();
            this.rbtPrimerCuatri = new System.Windows.Forms.RadioButton();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgCarreras = new System.Windows.Forms.DataGridView();
            this.columnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCuatri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNuevaCarrera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarreras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(675, 173);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 34);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbtSegundoCuatri
            // 
            this.rbtSegundoCuatri.AutoSize = true;
            this.rbtSegundoCuatri.Location = new System.Drawing.Point(624, 147);
            this.rbtSegundoCuatri.Name = "rbtSegundoCuatri";
            this.rbtSegundoCuatri.Size = new System.Drawing.Size(161, 20);
            this.rbtSegundoCuatri.TabIndex = 5;
            this.rbtSegundoCuatri.TabStop = true;
            this.rbtSegundoCuatri.Text = "Segundo Cuatrimestre";
            this.rbtSegundoCuatri.UseVisualStyleBackColor = true;
            // 
            // rbtPrimerCuatri
            // 
            this.rbtPrimerCuatri.AutoSize = true;
            this.rbtPrimerCuatri.Location = new System.Drawing.Point(624, 121);
            this.rbtPrimerCuatri.Name = "rbtPrimerCuatri";
            this.rbtPrimerCuatri.Size = new System.Drawing.Size(145, 20);
            this.rbtPrimerCuatri.TabIndex = 4;
            this.rbtPrimerCuatri.TabStop = true;
            this.rbtPrimerCuatri.Text = "Primer Cuatrimestre";
            this.rbtPrimerCuatri.UseVisualStyleBackColor = true;
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(75, 122);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(199, 24);
            this.cboMaterias.TabIndex = 2;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(315, 47);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(343, 22);
            this.txtCarrera.TabIndex = 1;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(349, 124);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(116, 22);
            this.txtAño.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Materia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Cuatrimestre";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(203, 53);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(52, 16);
            this.lblCarrera.TabIndex = 38;
            this.lblCarrera.Text = "Carrera";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(30, 411);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "Aceptar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(684, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgCarreras
            // 
            this.dtgCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCarreras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnid,
            this.ColumnCarrera,
            this.ColumnMateria,
            this.ColumnAño,
            this.ColumnCuatri,
            this.columnAcciones});
            this.dtgCarreras.Location = new System.Drawing.Point(30, 214);
            this.dtgCarreras.Name = "dtgCarreras";
            this.dtgCarreras.RowHeadersWidth = 51;
            this.dtgCarreras.RowTemplate.Height = 24;
            this.dtgCarreras.Size = new System.Drawing.Size(739, 183);
            this.dtgCarreras.TabIndex = 7;
            this.dtgCarreras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCarreras_CellContentClick);
            // 
            // columnid
            // 
            this.columnid.HeaderText = "id";
            this.columnid.MinimumWidth = 6;
            this.columnid.Name = "columnid";
            this.columnid.Visible = false;
            this.columnid.Width = 125;
            // 
            // ColumnCarrera
            // 
            this.ColumnCarrera.HeaderText = "Carrera";
            this.ColumnCarrera.MinimumWidth = 6;
            this.ColumnCarrera.Name = "ColumnCarrera";
            this.ColumnCarrera.Width = 130;
            // 
            // ColumnMateria
            // 
            this.ColumnMateria.HeaderText = "Materia";
            this.ColumnMateria.MinimumWidth = 6;
            this.ColumnMateria.Name = "ColumnMateria";
            this.ColumnMateria.Width = 130;
            // 
            // ColumnAño
            // 
            this.ColumnAño.HeaderText = "Año de cursado";
            this.ColumnAño.MinimumWidth = 6;
            this.ColumnAño.Name = "ColumnAño";
            this.ColumnAño.Width = 125;
            // 
            // ColumnCuatri
            // 
            this.ColumnCuatri.HeaderText = "Cuatrimestre";
            this.ColumnCuatri.MinimumWidth = 6;
            this.ColumnCuatri.Name = "ColumnCuatri";
            this.ColumnCuatri.Width = 125;
            // 
            // columnAcciones
            // 
            this.columnAcciones.HeaderText = "Acciones";
            this.columnAcciones.MinimumWidth = 6;
            this.columnAcciones.Name = "columnAcciones";
            this.columnAcciones.Text = "Quitar";
            this.columnAcciones.UseColumnTextForButtonValue = true;
            this.columnAcciones.Width = 125;
            // 
            // lblNuevaCarrera
            // 
            this.lblNuevaCarrera.AutoSize = true;
            this.lblNuevaCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCarrera.Location = new System.Drawing.Point(16, 16);
            this.lblNuevaCarrera.Name = "lblNuevaCarrera";
            this.lblNuevaCarrera.Size = new System.Drawing.Size(169, 22);
            this.lblNuevaCarrera.TabIndex = 0;
            this.lblNuevaCarrera.Text = "Nueva Carrera N°";
            // 
            // NuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtSegundoCuatri);
            this.Controls.Add(this.rbtPrimerCuatri);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtgCarreras);
            this.Controls.Add(this.lblNuevaCarrera);
            this.Name = "NuevaCarrera";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.NuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCarreras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbtSegundoCuatri;
        private System.Windows.Forms.RadioButton rbtPrimerCuatri;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dtgCarreras;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCuatri;
        private System.Windows.Forms.DataGridViewButtonColumn columnAcciones;
        private System.Windows.Forms.Label lblNuevaCarrera;
    }
}


namespace Carreras_tp1.Presentacion
{
    partial class Asignaturas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetAsignaturas = new Carreras_tp1.Reportes.DataSetAsignaturas();
            this.dataSetAsignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asignaturasTableAdapter = new Carreras_tp1.Reportes.DataSetAsignaturasTableAdapters.AsignaturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsignaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsignaturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.asignaturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Carreras_tp1.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetAsignaturas
            // 
            this.dataSetAsignaturas.DataSetName = "DataSetAsignaturas";
            this.dataSetAsignaturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetAsignaturasBindingSource
            // 
            this.dataSetAsignaturasBindingSource.DataSource = this.dataSetAsignaturas;
            this.dataSetAsignaturasBindingSource.Position = 0;
            // 
            // asignaturasBindingSource
            // 
            this.asignaturasBindingSource.DataMember = "Asignaturas";
            this.asignaturasBindingSource.DataSource = this.dataSetAsignaturas;
            // 
            // asignaturasTableAdapter
            // 
            this.asignaturasTableAdapter.ClearBeforeFill = true;
            // 
            // Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Asignaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Asignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsignaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAsignaturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asignaturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Reportes.DataSetAsignaturas dataSetAsignaturas;
        private System.Windows.Forms.BindingSource dataSetAsignaturasBindingSource;
        private System.Windows.Forms.BindingSource asignaturasBindingSource;
        private Reportes.DataSetAsignaturasTableAdapters.AsignaturasTableAdapter asignaturasTableAdapter;
    }
}
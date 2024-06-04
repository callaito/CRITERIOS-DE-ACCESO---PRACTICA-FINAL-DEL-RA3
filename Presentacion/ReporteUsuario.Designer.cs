namespace Presentacion.REPORTES
{
    partial class ReporteUsuario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inicio_de_SesionDataSet = new Presentacion.Inicio_de_SesionDataSet();
            this.spListarUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ListarUsuariosTableAdapter = new Presentacion.Inicio_de_SesionDataSetTableAdapters.sp_ListarUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inicio_de_SesionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListarUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.REPORTES.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // inicio_de_SesionDataSet
            // 
            this.inicio_de_SesionDataSet.DataSetName = "Inicio_de_SesionDataSet";
            this.inicio_de_SesionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListarUsuariosBindingSource
            // 
            this.spListarUsuariosBindingSource.DataMember = "sp_ListarUsuarios";
            this.spListarUsuariosBindingSource.DataSource = this.inicio_de_SesionDataSet;
            // 
            // sp_ListarUsuariosTableAdapter
            // 
            this.sp_ListarUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteUsuario";
            this.Text = "ReporteUsuario";
            this.Load += new System.EventHandler(this.ReporteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inicio_de_SesionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListarUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Inicio_de_SesionDataSet inicio_de_SesionDataSet;
        private System.Windows.Forms.BindingSource spListarUsuariosBindingSource;
        private Inicio_de_SesionDataSetTableAdapters.sp_ListarUsuariosTableAdapter sp_ListarUsuariosTableAdapter;
    }
}
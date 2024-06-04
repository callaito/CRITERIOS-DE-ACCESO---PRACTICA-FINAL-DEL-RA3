using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.REPORTES
{
    public partial class ReporteUsuario : Form
    {
        public ReporteUsuario()
        {
            InitializeComponent();
        }

        private void ReporteUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inicio_de_SesionDataSet.sp_ListarUsuarios' Puede moverla o quitarla según sea necesario.
            this.sp_ListarUsuariosTableAdapter.Fill(this.inicio_de_SesionDataSet.sp_ListarUsuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}

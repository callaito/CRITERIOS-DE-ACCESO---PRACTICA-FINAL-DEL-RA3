using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class Login : Form
    {

        Entidades.E_Usuario obje = new Entidades.E_Usuario();
        Negocio.N_Usuario objn = new Negocio.N_Usuario();

        public Login()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            obje.usuario = txt_usuario.Text;
            obje.Contraseña = txt_contraseña.Text;
            dt = objn.N_usuarios(obje);

            if (dt.Rows.Count > 0)
            {
                obje.usuario = dt.Rows[0][0].ToString();
                obje.Contraseña = dt.Rows[0][1].ToString();
                MessageBox.Show("Bienvenido al sistema");

                this.Hide();

                Cliente pri = new Cliente();
                pri.Show();
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }
    }
}

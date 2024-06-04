using Datos;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Cliente : Form
    {
        private N_Cliente NegocioCliente = new N_Cliente();
        private int estadoGuardado;



        public Cliente()
        {
            InitializeComponent();
            MostrarDatos();
        }



        private void MostrarDatos()
        {
            try
            {
                // Obtener los datos de usuarios desde la capa de negocio
                DataTable dataTable = NegocioCliente.ObtenerCliente();

                // Asignar el DataTable al DataSource del DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir
                MessageBox.Show("Error al obtener los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            // Validar que todos los datos requeridos están ingresados
            if (string.IsNullOrWhiteSpace(txtnombrecompleto.Text) ||
                string.IsNullOrWhiteSpace(txtcorreo.Text) ||
                string.IsNullOrWhiteSpace(txttelefono.Text) ||
                string.IsNullOrWhiteSpace(txtdireccion.Text))
            {
                MessageBox.Show("Falta ingresar datos requeridos",
                    "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Salir del método si falta algún dato
            }

            // Crear una instancia de E_Usuario y asignar valores
            E_Cliente oCliente = new E_Cliente
            {
                NombreCompleto = txtnombrecompleto.Text,
                Correo = txtcorreo.Text,
                Telefono = txttelefono.Text,
                Direcccion = txtdireccion.Text,
             
            };

            // Crear una instancia de D_Usuario y guardar los datos
            D_Cliente d_Usuario = new D_Cliente();
            string respuesta = d_Usuario.Guardar_Cliente(this.estadoGuardado, oCliente);

            if (respuesta == "OK")
            {
                MessageBox.Show("Los datos han sido guardados correctamente",
                                "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Realiza cualquier acción adicional si es necesario
            }
            else
            {
                MessageBox.Show("Error al guardar los datos: " + respuesta,
                                "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar al método de la capa de negocio para obtener los clientes
                DataTable clientes = NegocioCliente.ObtenerCliente();

                // Mostrar los clientes en el DataGridView
                dataGridView1.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}

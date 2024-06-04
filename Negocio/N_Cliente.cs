using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Cliente
    {

        private D_Cliente DATOSCLIENTES = new D_Cliente();
        public DataTable ObtenerCliente()
        {
            try
            {
                // Llama al método correspondiente en la capa de datos para obtener los usuarios
                return DATOSCLIENTES.ListarCliente();
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir al obtener los usuarios
                throw new Exception("Error al obtener los usuarios desde la capa de datos: " + ex.Message);
            }
        }


    }
}

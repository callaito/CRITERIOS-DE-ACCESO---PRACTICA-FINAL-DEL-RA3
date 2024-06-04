using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Configuration;


namespace Datos
{
    public class D_Usuario
    {
       SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_usuario(E_Usuario obje)
        {
            SqlCommand cmd = new SqlCommand("sp_login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@Contraseña", obje.Contraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}

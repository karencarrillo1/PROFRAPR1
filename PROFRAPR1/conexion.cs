using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PROFRAPR1
{
    class conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();
        
        public conexion()

        {
            string CadenaConexion = @"Data Source=(LocalDB)MSSQLLocalDB;AttachDbFilename=|DataDirectory|Registros.mdf;Integrated Security=True";
            miConexion.ConnectionString = CadenaConexion;
            miConexion.Open();
        }

    }
}

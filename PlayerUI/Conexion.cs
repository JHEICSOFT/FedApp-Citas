using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using PlayerUI.Properties;
using System.Configuration;

namespace PlayerUI
{
    public class Conexion
    {

        public static string ObtenerString()
        {
            return Settings.Default.DataHISConnectionString;
        }

        public static SqlConnection ObternerConexion()
        {
            //almacena la conexion de app.config
            SqlConnection cnn = new SqlConnection(ObtenerString());
            cnn.Open();
            return cnn;
        }


    }
}

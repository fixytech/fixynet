using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet
{
    class ConexionDb
    {

        // Cadena de conexion.
        //  public static ConnectionStringSettings stringConexion = ConfigurationManager.ConnectionStrings["connectionString"].ToString();

        // Testear conexion de windows.
        static public void testConexionWindows(String serverInstancia, String nombreDb)
        {
            SqlConnection conexion = new SqlConnection();

            // Cadena de conexion
            conexion.ConnectionString = "server =" + serverInstancia + "; Database=" + nombreDb + "; integrated security = true";


            try
            {

                conexion.Open();
                MessageBox.Show("Conexion Exitosa");
                conexion.Close();
                guardarString("server =" + serverInstancia + "; Database=" + nombreDb + "; integrated security = true");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion Fallida: " + ex);
            }

        }

        // Testear conexion Basica
        static public void testConexionBasic(String serverInstancia, String nombreDb, String usuario, String pass)
        {
            SqlConnection conexion = new SqlConnection();

            // Cadena de conexion
            conexion.ConnectionString = "server=" + serverInstancia + "; Database=" + nombreDb + "; User ID=" + usuario + ";Password=" + pass + ";";


            try
            {

                conexion.Open();
                MessageBox.Show("Conexion Exitosa");
                conexion.Close();
                guardarString("server=" + serverInstancia + "; Database=" + nombreDb + "; User ID=" + usuario + ";Password=" + pass + ";");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion Fallida: " + ex);
            }

        }

        // Guardar String en app.config
        static public void guardarString(string cadenaString)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["FixyNet.Properties.Settings.fixynetConnectionString"].ConnectionString = cadenaString;

            config.Save(ConfigurationSaveMode.Modified);

        }


        // Establecer conexion
        public static string cadenaConexion()
        {
            Configuration appconfig =
             ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connStringSettings = appconfig.ConnectionStrings.ConnectionStrings["FixyNet.Properties.Settings.fixynetConnectionString"].ConnectionString;
            return connStringSettings;
        }
    }
}

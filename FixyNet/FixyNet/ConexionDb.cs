﻿using System;
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
        static string stringConexion = ConfigurationManager.AppSettings["stringConexion"];

        // Testear conexion de windows.
        static public void testConexionWindows(String serverInstancia)
        {
            SqlConnection conexion = new SqlConnection();

                // Cadena de conexion
                conexion.ConnectionString = "server ="+serverInstancia+"; integrated security = true";
       

            try
            {

                conexion.Open();
                MessageBox.Show("Conexion Exitosa");
                conexion.Close();
                guardarString("server =" + serverInstancia + "; integrated security = true");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexion Fallida: " + ex);
            }

        }

        // Testear conexion Basica
        static public void testConexionBasic(String serverInstancia, String usuario, String pass)
        {
            SqlConnection conexion = new SqlConnection();

            // Cadena de conexion
            conexion.ConnectionString = "server="+ serverInstancia +"; User ID="+ usuario +";Password="+ pass +";";


            try
            {

                conexion.Open();
                MessageBox.Show("Conexion Exitosa");
                conexion.Close();
                guardarString("server=" + serverInstancia + "; User ID=" + usuario + ";Password=" + pass + ";");

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
            config.AppSettings.Settings["stringConexion"].Value = cadenaString;
            config.Save(ConfigurationSaveMode.Modified);
          
        }
    }
}

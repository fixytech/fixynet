using FixyNet.Clases.Listas;
using FixyNet.fixynetDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet.Clases
{
    class DispositivosClass
    {
        public IPAddress ip;
        public IPAddress ipFin;
        public List<ListaDispositivos> listaDispositivos = new List<ListaDispositivos>();
        public List<ListaIpMonAct> listaReturn = new List<ListaIpMonAct>();


        public async Task<string> AgregarDispositivos()
        {
            string[] inicio = Discovery.dividirIp(ip.ToString());
            string[] fin = Discovery.dividirIp(ipFin.ToString());

            string tresOctetosInicio = inicio[0] + "." + inicio[1] + "." + inicio[2];
            string tresOctetosFin = fin[0] + "." + fin[1] + "." + fin[2];

            if (tresOctetosInicio != tresOctetosFin)
            {
                return "Los tres primeros octetos deben ser iguales.";
            }

            if (Int32.Parse(inicio[3]) > Int32.Parse(fin[3]))
            {
                return "La IP de inicio debe ser menor que la de fin.";
            }

            try
            {
                SqlConnection cn = new SqlConnection(ConexionDb.cadenaConexion());
                cn.Open();


                for (int i = Int32.Parse(inicio[3]); i <= Int32.Parse(fin[3]); i++)
                {
                    Task agregar = Task.Run(() =>
                    {
                        String miGuid = Guid.NewGuid().ToString();
                        string insertIP = tresOctetosInicio + "." + i.ToString();


                        String queryInsert = "INSERT INTO dispositivos " +
                            "([uuid_dispositivo],[ip]) VALUES ('" + miGuid + "', '" + insertIP + "')";


                        SqlCommand comando = new SqlCommand(queryInsert, cn);

                        comando.ExecuteNonQuery();

                    });
                    await agregar;
                }


                cn.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


            return "Dispositivos agreados con exito.";

        }
        public async Task AgregarDispositivo()
        {


            try
            {
                SqlConnection cn = new SqlConnection(ConexionDb.cadenaConexion());
                cn.Open();


                Task agregar = Task.Run(() =>
                {


                    foreach (ListaDispositivos lista in listaDispositivos)
                    {
                        String miGuid = Guid.NewGuid().ToString();

                        String queryInsert = "INSERT INTO dispositivos " +
                                             "([uuid_dispositivo],[ip],[subnet],[mac],[marca],[modelo],[descripcion],[monitor],[hostname]) VALUES ('" + miGuid + "'" +
                                             ", '" + lista.ip + "'" +
                                             ", '" + lista.subnet + "'" +
                                             ", '" + lista.mac + "'" +
                                             ", '" + lista.marca + "'" +
                                             ", '" + lista.modelo + "'" +
                                             ", '" + lista.descripcion + "'" +
                                             ", '" + lista.monitor + "'" +
                                             ", '" + lista.hostname + "'" +
                                             ")";

                        try
                        {
                            SqlCommand comando = new SqlCommand(queryInsert, cn);

                            comando.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

                });
                await agregar;



                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        public async Task listaMonActivo()
        {


            try
            {


                SqlConnection cn = new SqlConnection(ConexionDb.cadenaConexion());
                cn.Open();


                Task consultar = Task.Run(() =>
                {
                    String queryInsert = "SELECT uuid_dispositivo, ip, monitor FROM dispositivos WHERE monitor = 1";

                    try
                    {
                        SqlCommand comando = new SqlCommand(queryInsert, cn);

                        SqlDataReader reader = comando.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listaReturn.Add(new ListaIpMonAct { uuid_dispositivo = reader.GetString(0), ip = reader.GetString(1) });

                            }
                        }
                        else
                        {
                            MessageBox.Show("Sin dispositivos para monitorear");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                });
                await consultar;

                cn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet.Clases
{
    class EventosClass
    {

        public string uuid_dispositivo;
        public async Task addEvento(string estado, long tiempoRespuesta)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConexionDb.cadenaConexion());
                cn.Open();

                Task agregoEvento = Task.Run(() =>
                       {
                           String miGuid = Guid.NewGuid().ToString();

                           String queryInsert = "INSERT INTO eventos ([uuid_evento],[uuid_dispositivo],[fecha],[hora],[estado],[tiempo_respuesta]) VALUES ('" + miGuid + "', '" + uuid_dispositivo + "', '" + DateTime.Now.ToString("dd-MM-yyyy") + "' , '" + DateTime.Now.ToString("hh:mm:ss") + "', '" + estado + "', '" + tiempoRespuesta + "')";

                           try
                           {
                               SqlCommand comando = new SqlCommand(queryInsert, cn);

                               comando.ExecuteNonQuery();
                           }
                           catch (Exception ex)
                           {
                               MessageBox.Show(ex.Message);
                           }
                       });

                await agregoEvento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

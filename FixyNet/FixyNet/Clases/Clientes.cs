using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet
{
    class Clientes
    {
        
       
        static public void agregarCliente(String nombre, String direccion, String contacto, String email) {

            if (nombre.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre de cliente", "CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String miGuid = Guid.NewGuid().ToString();

            String queryInsert = "INSERT INTO clientes " +
                            "([uuid_cliente],[nombre],[direccion],[persona_contacto],[email]) VALUES"+
           "('"+ miGuid +"'"+
           ", '"+ nombre +"'"+
           ", '"+ direccion +"'"+
           ", '"+ contacto +"'"+
           ", '"+ email +"')";

            try
            {
                SqlCommand comando = new SqlCommand(queryInsert, ConexionDb.Conectar() );
                comando.ExecuteNonQuery();

                MessageBox.Show("Cliente agregado!", "CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show("Error al agregar registro. " + ex, "CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}

}

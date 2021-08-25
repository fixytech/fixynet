using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FixyNet.Clases;

namespace FixyNet.Clases
{
    class Discovery : Pinguear
    {

        // declaro LISTA
        public List<ListaIPRespuesta> respuesta = new List<ListaIPRespuesta>();
        private List<ListaIPRespuesta> listaConHost = new List<ListaIPRespuesta>();
        private Loading loading = new Loading();
        private int l = 0;

        public async Task Regular()
        {

            loading.Show();
            loading.setTitle("Buscando datos del dispositivo....");

            DescubrirHostyMac host;
            var tasks = new List<Task>();
            host = new DescubrirHostyMac();

            foreach (ListaIPRespuesta lista in respuesta)
            {

                Task task = host.ResolveAsync(lista.ip);

                tasks.Add(task);

            }
            int max = tasks.Count;

            loading.setProgress(max, 0);

            while (true)
            {
                foreach (Task item in tasks)
                {

                    if (item.Status == TaskStatus.RanToCompletion)
                    {
                        l += 1;
                    }

                    if (l == max)
                    {
                        break;
                    }
                }
                loading.statusProgress(l);
                if (l == max)
                {
                    break;
                }
                await Task.Delay(10);

            }

            await Task.WhenAll(tasks).ContinueWith(t =>
            {

                respuesta = host.listaConHost;

            });

            loading.Close();

        }
        static public string[] dividirIp(string ip)
        {
            string[] respuesta = null;

            respuesta = ip.Split('.');

            return respuesta;
        }
        public async Task BuscarDispositivos(String ip) // Formato admitido Ej: 192.168.0.1-254, 10.10.0.15-52
        {

            // INSTANCIO CLASE PINGUEAR
            Pinguear pingAsync = new Pinguear();

            string tresOctetos;

            string[] red;



            // separador de redes
            char delimitador = ',';

            // Redes detectadas
            string[] redes = ip.Split(delimitador);


            string[] ipDividida;
            // Si hay solo una
            if (redes.Length == 1)
            {
                // defino redes[0] con la ip ingresada
                redes[0] = ip;

                // busco el inicio y fin a buscar ejemplo 10.10.0.1-254
                delimitador = '-';

                // defino red 
                red = redes[0].Split(delimitador);

                if (red.Length == 1)
                {

                    // DIVIDO OCTETOS DE LA IP
                    ipDividida = dividirIp(red[0]);
                    // ARMO LOS TRES PRIMEROS OCTETOS DE LA RED
                    tresOctetos = ipDividida[0] + "." + ipDividida[1] + "." + ipDividida[2] + ".";

                    // LE ASIGNO A LA CLASE LA PROPIEDAD
                    pingAsync.BaseIP = tresOctetos;
                    pingAsync.StartIP = Int32.Parse(ipDividida[3]);
                    pingAsync.StopIP = Int32.Parse(ipDividida[3]);

                    await pingAsync.RunPingSweep_Async();


                    respuesta = pingAsync.resultado;


                }
                else
                {
                    ipDividida = dividirIp(red[0]);


                    tresOctetos = ipDividida[0] + "." + ipDividida[1] + "." + ipDividida[2] + ".";

                    // LE ASIGNO A LA CLASE LA PROPIEDAD
                    pingAsync.BaseIP = tresOctetos;
                    pingAsync.StartIP = Int32.Parse(ipDividida[3]);
                    pingAsync.StopIP = Int32.Parse(red[1]);
                    await pingAsync.RunPingSweep_Async();


                    respuesta = pingAsync.resultado;


                }
                respuesta = pingAsync.resultado;
            }
            else // si hay mas de una red
            {

                for (int i = 0; i <= redes.Length; i++)
                {

                    // busco el inicio y fin a buscar ejemplo 10.10.0.1-254
                    delimitador = '-';

                    //192.168.0.1-254,192.168.1.1-254
                    // defino red 
                    red = redes[i].Split(delimitador);

                    try
                    {
                        if (red.Length == 1)
                        {
                            // DIVIDO OCTETOS DE LA IP
                            ipDividida = dividirIp(red[0]);
                            // ARMO LOS TRES PRIMEROS OCTETOS DE LA RED
                            tresOctetos = ipDividida[0] + "." + ipDividida[1] + "." + ipDividida[2] + ".";

                            // LE ASIGNO A LA CLASE LA PROPIEDAD
                            pingAsync.BaseIP = tresOctetos;
                            pingAsync.StartIP = Int32.Parse(ipDividida[3]);
                            pingAsync.StopIP = Int32.Parse(ipDividida[3]);
                            await pingAsync.RunPingSweep_Async();

                            if (i == redes.Length - 1)
                            {
                                respuesta = pingAsync.resultado;
                                break;
                            }

                        }
                        else
                        {
                            ipDividida = dividirIp(red[0]);

                            tresOctetos = ipDividida[0] + "." + ipDividida[1] + "." + ipDividida[2] + ".";

                            // LE ASIGNO A LA CLASE LA PROPIEDAD
                            pingAsync.BaseIP = tresOctetos;
                            pingAsync.StartIP = Int32.Parse(ipDividida[3]);
                            pingAsync.StopIP = Int32.Parse(red[1]);
                            await pingAsync.RunPingSweep_Async();

                            if (i == redes.Length - 1)
                            {
                                respuesta = pingAsync.resultado;
                                break;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }

            }

        }

    }
}

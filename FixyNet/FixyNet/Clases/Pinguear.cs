using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet.Clases
{
    class Pinguear
    {
        public string BaseIP;
        public int StartIP;
        public int StopIP;
        public string ip;
        public int progreso = 0;
        public long tiempoResp;

        public int timeout = 1000;
        public int nFound = 0;

        static object lockObj = new object();
        Stopwatch stopWatch = new Stopwatch();
        TimeSpan ts;

        public List<ListaIPRespuesta> resultado = new List<ListaIPRespuesta>();

        public async Task RunPingSweep_Async()
        {
            Loading loading = new Loading();
            loading.Show();
            loading.setProgress(StopIP, StartIP);
            loading.setTitle("Buscando Dispositivos....");

            nFound = 0;

            var tasks = new List<Task>();

            stopWatch.Start();

            for (int i = StartIP; i <= StopIP; i++)
            {

                loading.statusProgress(i);

                ip = BaseIP + i.ToString();
                progreso = i;
                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();

                var task = PingAndUpdateAsync(p, ip);

                tasks.Add(task);

            }

            await Task.WhenAll(tasks).ContinueWith(t =>
                    {
                        stopWatch.Stop();
                        ts = stopWatch.Elapsed;

                    });
            loading.Close();

        }

        private async Task PingAndUpdateAsync(System.Net.NetworkInformation.Ping ping, string ip)
        {

            var reply = await ping.SendPingAsync(ip, timeout);


            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {

                resultado.Add(new ListaIPRespuesta { ip = ip, estado = "Success" });

                lock (lockObj)
                {
                    nFound++;
                }
            }


        }

        public async Task<Boolean> PingAsync(System.Net.NetworkInformation.Ping ping)
        {


            var reply = await ping.SendPingAsync(ip, timeout);

            tiempoResp = reply.RoundtripTime;


            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }






        }

    }
}

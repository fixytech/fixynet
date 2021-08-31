using FixyNet.Clases;
using FixyNet.Clases.Listas;
using FixyNet.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FixyNet.Clases
{
    class MonitorClass
    {
        private Discovery toolPing = new Discovery();
        private Grafico grafico = new Grafico();
        public event EventHandler CerrarClass;
        public List<ListaGrafico> listaGraficos = new List<ListaGrafico>();
        public int tiempoPooleo = 500;
        public Timer Reloj = new Timer();
        private bool detengoMonitor = false;

        public void ShowMonitor()
        {

            grafico.formGrafico.Show();
            grafico.CerrarClass += (s, e) =>
            {

                InvocarDetener();
            };
        }
        public void InvocarDetener()
        {
            detengoMonitor = true;
            this.CerrarClass?.Invoke(this, EventArgs.Empty);
        }
        public async Task Monitoreo()
        {
            if (detengoMonitor == false)
            {
                ShowMonitor();
                List<ListaIpMonAct> listaIpMonitor = new List<ListaIpMonAct>();
                DispositivosClass dispositivos = new DispositivosClass();

                await dispositivos.listaMonActivo();

                listaIpMonitor = dispositivos.listaReturn;

                var tasks = new List<Task>();

                foreach (ListaIpMonAct lista in listaIpMonitor)
                {
                    var task = Monitorear(lista.ip, lista.uuid_dispositivo);
                    tasks.Add(task);
                }

                await Task.WhenAny(tasks).ContinueWith(t =>
                {
                // MessageBox.Show("Dsp: " + listaIpMonitor.Count());
                for (int i = 0; i < listaIpMonitor.Count(); i++)
                    {
                        if (tasks[i].Status != TaskStatus.RanToCompletion)
                        {
                            i = 1;
                        }

                    }

                    var taUno = Task.Run(() => grafico.cantidadDispositivos = listaIpMonitor.Count());
                    taUno.Wait();

                    var taDos = Task.Run(() => grafico.listaGraficos = listaGraficos);
                    taDos.Wait();

                    var taTres = Task.Run(() => grafico.Iniciar());
                    taTres.Wait();


                });



                listaGraficos.Clear();
                //   MessageBox.Show(grafico.listaGraficos.Count.ToString());
                Reloj.Start();
                Reloj.Interval = tiempoPooleo;
                var taEspera = Task.Run(() => RelojTick());
                taEspera.Wait();
            }


            if (detengoMonitor == false)
            {
                await Monitoreo();
            }

        }
        private bool RelojTick()
        {
            while (Reloj.Equals(tiempoPooleo))
            {

            }
            Reloj.Stop();
            return true;
        }
        private async Task Monitorear(string ipp, string uuid_dispositivo)
        {
            System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
            toolPing.ip = ipp;
            EventosClass evento = new EventosClass
            {
                uuid_dispositivo = uuid_dispositivo
            };


            if (await toolPing.PingAsync(p) == false)
            {
                var t = Task.Run(() => listaGraficos.Add(new ListaGrafico { ip = ipp, uuid_dispositivo = uuid_dispositivo, estado = "Error" }));
                t.Wait();
                await evento.addEvento("Error", toolPing.tiempoResp);

            }
            else
            {
                var t = Task.Run(() => listaGraficos.Add(new ListaGrafico { ip = ipp, uuid_dispositivo = uuid_dispositivo, estado = "Success" }));
                t.Wait();
                await evento.addEvento("Success", toolPing.tiempoResp);

            }

        }

    }
}

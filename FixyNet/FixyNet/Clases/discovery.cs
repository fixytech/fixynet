using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FixyNet.Clases;

namespace FixyNet.Clases
{
    class Discovery 
    {

        public event EventHandler<ProgressBarEvent> ProgressEvent;


        public virtual void OnRaiseProgressEvent(ProgressBarEvent e)
        {
            // C# 6 and above:
            // Raise event if event handler is set (i.e. not null)
            ProgressEvent?.Invoke(this, e);
            // end C# >=6 code

            // C# 5 and earlier:
            EventHandler<ProgressBarEvent> handler = ProgressEvent;

            if (handler != null)
            {
                //this is what actually raises the event.
                handler(this, e);
            }
            // end C# <=5 code
        }
         public List<ListaIPRespuesta> buscarDispositivos(String ip) // Formato admitido Ej: 192.168.0.1-254, 10.10.0.15-52
        {

            List<ListaIPRespuesta> resultado;
            resultado = new List<ListaIPRespuesta>();

            string[] red;

            string[] ipDividida = null;

            int id =0;

            // separador de redes
            char delimitador = ','; 

            // Redes detectadas
            string[] redes = ip.Split(delimitador);

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
                    // realizo ping a la ip
                    OnRaiseProgressEvent(new ProgressBarEvent(0, 1, "Buscando... " + red[0]));

                    resultado.Add(new ListaIPRespuesta { ip = red[0], estado = HerramientasRed.pinguear(red[0]).Status.ToString() });

                    OnRaiseProgressEvent(new ProgressBarEvent(1,1,"Terminado "+red[0]));
                }
                else
                {
                    ipDividida = HerramientasRed.dividirIp(red[0]);

                    

                    for (int i = Int32.Parse(ipDividida[3]); i <= Int32.Parse(red[1]); i++)
                    {
                        string ipPing = ipDividida[0] + "." + ipDividida[1] + "." + ipDividida[2] + "." + i;

                        resultado.Add(new ListaIPRespuesta { ip = ipPing, estado = HerramientasRed.pinguear(ipPing).Status.ToString() });

                        OnRaiseProgressEvent(new ProgressBarEvent(i, Int32.Parse(red[1]), "Buscando... "+ ipPing));

                        id++;
                    }
                    OnRaiseProgressEvent(new ProgressBarEvent(Int32.Parse(red[1]), Int32.Parse(red[1]), "Terminado"));
                }
            }
            else // si hay mas de una red
            {
                OnRaiseProgressEvent(new ProgressBarEvent(0, redes.Length, "Buscando"));

                for (int i=0; i < redes.Length; i++)
                {

                    // busco el inicio y fin a buscar ejemplo 10.10.0.1-254
                    delimitador = '-';

                    // defino red 
                    red = redes[i].Split(delimitador);

                    if (red.Length == 1)
                    {

                        OnRaiseProgressEvent(new ProgressBarEvent(i, redes.Length, "Buscando... " + redes[i]));
                        // realizo ping a la ip
                        resultado.Add(new ListaIPRespuesta { ip = redes[i], estado = HerramientasRed.pinguear(redes[i]).Status.ToString() });
                        
                    }
                    else
                    {
                        ipDividida = HerramientasRed.dividirIp(red[0]);



                        for (int ix = Int32.Parse(ipDividida[3]); ix <= Int32.Parse(red[1]); ix++)
                        {

                            string ipPing = ipDividida[0] + "." + ipDividida[1] + "." + ipDividida[2] + "." + ix;

                            OnRaiseProgressEvent(new ProgressBarEvent(ix, Int32.Parse(red[1]), "Buscando... " + ipPing));

                            resultado.Add(new ListaIPRespuesta { ip = ipPing, estado = HerramientasRed.pinguear(ipPing).Status.ToString() });

                            id++;
                        }
                    }

                }
            }
            return resultado;
        }
    }
}

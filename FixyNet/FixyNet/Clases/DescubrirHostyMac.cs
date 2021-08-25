using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace FixyNet.Clases
{
    class DescubrirHostyMac
    {
        public List<ListaIPRespuesta> listaConHost = new List<ListaIPRespuesta>();


        public async Task ResolveAsync(string ip)
        {

            var t = Task.Run(() => ShowThreadInfo(ip));
            await t;

        }


        private void ShowThreadInfo(String ip)
        {
            string host;
            string mac;

            try
            {
                host = Dns.GetHostEntry(ip).HostName;
            }
            catch
            {
                host = "Desconocido";
            }

            try
            {

                mac = IpMac.FormatMac(IpMac.GetRemoteMAC(ip), '-');

            }
            catch (Exception ex)
            {
                mac = ex.ToString();
            }

            listaConHost.Add(new ListaIPRespuesta { ip = ip, host = host, mac = mac });

        }


    }
}

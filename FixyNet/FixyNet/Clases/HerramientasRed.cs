using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;
using FixyNet.Clases;

namespace FixyNet
{
    class HerramientasRed : Discovery
    {

        // PING
        static public PingReply pinguear(String ipAd) // 66.249.87.104, cantidad de paquetes
        {
            IPAddress ip = IPAddress.Parse(ipAd);

            Ping ping = new Ping();

                PingReply pr = ping.Send(ip, 10);
                 return pr;
        }

        // DIVIDIR IP
        static public string[] dividirIp(string ip)
        {
            string[] respuesta = null;

            respuesta = ip.Split('.');

            return respuesta;
        }
    }
}

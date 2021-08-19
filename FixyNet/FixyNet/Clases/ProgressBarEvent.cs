using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixyNet.Clases
{
    class ProgressBarEvent : EventArgs
    {
        public int Progress { get; set; }

        public int Total { get; set; }

        public string Mensaje { get; set; }

        public ProgressBarEvent(int progress, int total, string mensaje)
        {
            Progress = progress;

            Total = total;

            Mensaje = mensaje;
        }

    }
}

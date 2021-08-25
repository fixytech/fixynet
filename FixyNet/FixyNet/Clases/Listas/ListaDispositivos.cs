using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixyNet.Clases.Listas
{
    class ListaDispositivos
    {
        public string ip { get; set; }
        public string mac { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string hostname { get; set; }
        public string descripcion { get; set; }
        public string subnet { get; set; }
        public Boolean monitor { get; set; }
    }
}

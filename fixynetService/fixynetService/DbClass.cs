using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixynetService
{
    class DbClass
    {
        public static string cadenaConexion()
        {

            Configuration appconfig =
             ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string connStringSettings = appconfig.ConnectionStrings.ConnectionStrings["FixyNet.Properties.Settings.fixynetConnectionString"].ConnectionString;
            return connStringSettings;
        }
    }
}

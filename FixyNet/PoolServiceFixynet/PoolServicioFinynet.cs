using FixyNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using FixyNet.Clases;

namespace PoolServiceFixynet
{
    public partial class ServicePool : ServiceBase
    {
        public ServicePool()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

            MonitorClass monitor = new MonitorClass();
            monitor.Monitorear();
        }

        protected override void OnStop()
        {
        }
    }
}

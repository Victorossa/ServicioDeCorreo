using ClasesDeServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDeEnvio
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main()
        {
            try
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new ServicioDeEnvioACola()
                };
                ServiceBase.Run(ServicesToRun);
            }
            catch (Exception ex)
            {
                ELog.save(ex);
            }
        }
    }
}

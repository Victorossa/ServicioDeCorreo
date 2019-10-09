using ClasesDeServicio;
using OperacionesDeServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasServ
{
    public class PruebaServiciosEnvio
    {
        public void PruebaDeServicio()
        {
            try
            {
                PruebaEnvioCarpetaLocal ejecutaPrueba = new PruebaEnvioCarpetaLocal();
                ejecutaPrueba.EnvioCarpetaLocal();
            }
            catch (Exception ex)
            {
                ELog.save(ex);
            }

        }

        public void PruebaLog()
        {
            try
            {
                int v1 = 5;
                int v2 = 0;
                int v3 = v1 / v2;

            }
            catch (Exception ex)
            {
                ELog.save(ex);
            }
        }
    }
}

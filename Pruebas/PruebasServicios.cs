using OperacionesDeServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClasesDeServicio
{
    public class PruebasServicios
    {    
        public static void PruebaDeServicio()
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

        public static void Prueba()
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

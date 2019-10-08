using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ClasesDeServicio;
using Newtonsoft.Json;
using OperacionesDeServicio;

namespace ServicioDeEnvio
{
    partial class ServicioDeEnvioMensajes : ServiceBase
    {
        public ServicioDeEnvioMensajes()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: agregar código aquí para iniciar el servicio.
            LapsoServicioEnvio.Start();
        }

        protected override void OnStop()
        {
            // TODO: agregar código aquí para realizar cualquier anulación necesaria para detener el servicio.
            LapsoServicioEnvio.Stop();
        }

        private void LapsoServicioEnvio_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Pruebas a Carpeta Local
            //PruebaDeServicio();

            //Envio a Servicio de Mensajeria    
            //EnvioAColaDeCorreos();
            prueba();
        }

        private static void EnvioAColaDeCorreos()
        {
            try
            {
                EnvioMensajeCola envioMensaje = new EnvioMensajeCola();
                CargarInformacionExcel obj = new CargarInformacionExcel();
                Object myObjeto = obj.CargarObjeto();
                string JSONresult = JsonConvert.SerializeObject(myObjeto);
                envioMensaje.MensajeEnCola(JSONresult);
            }
            catch (Exception ex)
            {      
                ELog.save(ex);
            }             
        }

        private static void PruebaDeServicio()
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

        private static void prueba() 
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

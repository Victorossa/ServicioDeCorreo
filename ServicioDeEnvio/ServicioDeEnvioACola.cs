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
using PruebasServ;


namespace ServicioDeEnvio
{
    partial class ServicioDeEnvioACola : ServiceBase
    {
        public ServicioDeEnvioACola()
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
            PruebaServiciosEnvio pruebas = new PruebaServiciosEnvio();
            //Prueba Funcionamiento de Servicio
            //pruebas.PruebaDeServicio();
            //Pruebas de Servicio de Registro Log
            //pruebas.PruebaLog();

            //Envio a Servicio de Mensajeria    
            EnvioAColaDeCorreos();

        }

        private static void EnvioAColaDeCorreos()
        {
            try
            {
                EnvioMensajeCola envioMensaje = new EnvioMensajeCola();
                CargarInformacionExcel obj = new CargarInformacionExcel();
                Object myObjeto = obj.CargarObjeto();
                string JSONresult = JsonConvert.SerializeObject(myObjeto, Formatting.Indented);
                envioMensaje.MensajeEnCola(JSONresult);
            }
            catch (Exception ex)
            {
                ELog.save(ex);
            }
        }




    }
}

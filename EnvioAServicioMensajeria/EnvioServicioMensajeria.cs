using ClasesDeServicio;
using OperacionesDeServicio;
using PruebasServ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Messaging;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace EnvioAServicioMensajeria
{
    partial class EnvioServicioMensajeria : ServiceBase
    {
        public EnvioServicioMensajeria()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // TODO: agregar código aquí para iniciar el servicio.
            LapsoEnvioServicioMensajeria.Start();
        }

        protected override void OnStop()
        {
            // TODO: agregar código aquí para realizar cualquier anulación necesaria para detener el servicio.
            LapsoEnvioServicioMensajeria.Stop();
        }

        private void LapsoEnvioServicioMensajeria_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //Pruebas a Carpeta Local
            PruebaServiciosEnvio pruebas = new PruebaServiciosEnvio();
            //Prueba Funcionamiento de Servicio
            //pruebas.PruebaDeServicio();
            //Pruebas de Servicio de Registro Log
            //pruebas.PruebaLog();
            EnviarMensajeServicioMensajeria();

        }

        public void EnviarMensajeServicioMensajeria()
        {
            
            MessageQueue myQueue = new MessageQueue(@".\Private$\email");
            myQueue.Formatter = new XmlMessageFormatter(new Type[]
                {typeof(string)});

            try
            {
                var msg = myQueue.Receive();
                string json = msg.Body.ToString();
                EnvioMensajeServicioDeCorreo obj = new EnvioMensajeServicioDeCorreo();
                obj.PostEnvioMensajeJSONAsync(json);
            }

            catch (MessageQueueException)
            {
                // Handle Message Queuing exceptions.
            }

            // Handle invalid serialization format.
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            // Catch other exceptions as necessary.

            return;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDeServicio
{
    public class EnvioMensajeCola
    {
        public void MensajeEnCola(string mensajeJson) 
        {
            MessageQueue messageQueue = null;
            if (MessageQueue.Exists(@".\Private$\email"))
            {
                messageQueue = new MessageQueue(@".\Private$\email");
                messageQueue.Label = "Testing Queue";
            }
            else
            {
                // Create the Queue
                MessageQueue.Create(@".\Private$\email");
                messageQueue = new MessageQueue(@".\Private$\email");
                messageQueue.Label = "Newly Created Queue";
            }
            messageQueue.Send(mensajeJson, "Correo JSON");
        }
                   
    }
}

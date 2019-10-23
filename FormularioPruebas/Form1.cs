using ClasesDeServicio;
using Newtonsoft.Json;
using OperacionesDeServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCorreoCola_Click(object sender, EventArgs e)
        {
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

        private void BtnEnvioServicioCorreo_Click(object sender, EventArgs e)
        {
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
                if (json != null)
                {
                    EnvioMensajeServicioDeCorreo obj = new EnvioMensajeServicioDeCorreo();
                    obj.PostEnvioMensajeJSONAsync(json);
                }
               
            }

            catch (MessageQueueException)
            {
                
            }
            

            return;
        }

        
        private void Btn_Seleccionar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            txtRuta.Text = open.FileName;
            if (txtRuta.Text != "")
            {
                string ruta = txtRuta.Text;
                byte[] archivoBytes = System.IO.File.ReadAllBytes(ruta);
                string archivoBase64 = Convert.ToBase64String(archivoBytes);
                txtResultado.Text = archivoBase64;
            }
        }
    }
}

using ClasesDeServicio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OperacionesDeServicio
{
    public class EnvioMensajeServicioDeCorreo
    {
        private string pathAPI, Estado;
        private static HttpClient clientAPIServcio;

        public EnvioMensajeServicioDeCorreo()
        {
            //***********************//
            pathAPI = RecursosDelSistema.path;
            //***********************//
            clientAPIServcio = new HttpClient();
            //Trae la base de URL
            clientAPIServcio.BaseAddress = new Uri(pathAPI);
            //Limpia las cabeceras
            clientAPIServcio.DefaultRequestHeaders.Accept.Clear();
        }

        public async Task PostEnvioMensajeJSONAsync(string mensajeJSON)
        {
            try
            {
                string respuesta = string.Empty;
                //***********************//
                string accessToken = RecursosDelSistema.accessToken;
                //***********************//
                HttpClient client = new HttpClient();
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(RecursosDelSistema.type, accessToken);
                HttpResponseMessage response = await client.PostAsync(pathAPI, new StringContent(mensajeJSON, Encoding.UTF8, "application/json"));
                CorreoDeserializadoLog deserializedMensaje = JsonConvert.DeserializeObject<CorreoDeserializadoLog>(mensajeJSON);


                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    Estado = "Ok";
                    ProcesarRespuesta(respuesta, deserializedMensaje,Estado);
                }
                else
                {
                    Estado = "Fallido";
                    string razon = response.ReasonPhrase;
                    ProcesarRespuesta(respuesta, deserializedMensaje, Estado);
                }

            }
            catch (Exception ex)
            {
                ELog.save(ex);
            }


        }

        private static void ProcesarRespuesta(string respuesta, CorreoDeserializadoLog deserializedMensaje,string Estado)
        {
            RootObject desSerializaRespuesta = JsonConvert.DeserializeObject<RootObject>(respuesta);

            string De = deserializedMensaje.From;
            string Destinatarios = "";
            var Para = deserializedMensaje.Recipients;
            foreach (var item in Para)
            {
                var valor = item.To;
                if (Destinatarios == "")
                {
                    Destinatarios = valor;
                }
                else
                {
                    Destinatarios = Destinatarios + " - " + valor;
                }
            }
            string fecha = System.DateTime.Now.ToString("yyyy-MM-dd");
            string hora = System.DateTime.Now.ToString("HH:mm:ss");
            string Asunto = deserializedMensaje.Subject;
            string DeliveryID = desSerializaRespuesta.data.deliveryId;
            string pathCarpeta = @"c:\logService";
            string path = @"c:\logService\logCorreos.txt";

            if (!Directory.Exists(pathCarpeta))
            {
                Directory.CreateDirectory(pathCarpeta);
            }
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            StreamWriter sw = new StreamWriter(path, true);
            StackTrace stacktrace = new StackTrace();
            sw.WriteLine(fecha + " " + hora);
            sw.WriteLine("Estado:" + Estado);
            sw.WriteLine("De: " + De);
            sw.WriteLine("Para: " + Destinatarios);
            sw.WriteLine("Asunto: " + Asunto);
            sw.WriteLine("Id Envio: " + DeliveryID);
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
        }
    }
}

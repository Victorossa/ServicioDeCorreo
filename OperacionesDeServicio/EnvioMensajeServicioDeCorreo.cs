using ClasesDeServicio;
using System;
using System.Collections.Generic;
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
        private string pathAPI;
        private static HttpClient clientAPIServcio;

        public EnvioMensajeServicioDeCorreo()
        {
            //***********************//
            pathAPI = "https://api.masiv.masivian.com/email/v1/delivery";
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
                string accessToken = "QXBpX0ZWMVhJOkMzMDBVS1UtWlQ=";
                //***********************//
                HttpClient client = new HttpClient();
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", accessToken);
                HttpResponseMessage response = await client.PostAsync(pathAPI, new StringContent(mensajeJSON, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    respuesta = response.ToString();
                    //Guardar Respuesta
                }
                else
                {
                    respuesta = response.ToString();
                    //Registrar que no se envio
                }

            }
            catch (Exception ex)
            {
                ELog.save(ex);
            }


        }
    }
}

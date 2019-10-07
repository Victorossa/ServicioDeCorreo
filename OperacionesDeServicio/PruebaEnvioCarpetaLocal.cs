using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesDeServicio
{
    public class PruebaEnvioCarpetaLocal
    {
        public void EnvioCarpetaLocal()
        {
            //Invoca al metodo que transforma el contenido de excel en un json.
            CargarInformacionExcel obj = new CargarInformacionExcel();
            Object myObjeto = obj.CargarObjeto();
            //Serializa el objeto creado a un json.
            string JSONresult = JsonConvert.SerializeObject(myObjeto);
            var fecha = DateTime.Now.ToString("hhmmss");
            string path = @"C:\Users\programador1\source\repos\CorreosMasivos\JSON Creados\correos" + fecha + ".json";
            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
        }
    }
}

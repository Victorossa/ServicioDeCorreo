using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Diagnostics;

namespace ClasesDeServicio
{
    public class ELog
    {
        public static void save(Exception ex)
        {
            string fecha = System.DateTime.Now.ToString("yyyy-MM-dd");
            string hora = System.DateTime.Now.ToString("HH:mm:ss");
            string path = HttpContext.Current.Server.MapPath(@"..\log\log.txt");

            //@"C:\Users\programador1\Desktop\Proyecto Comedal\EnvioDeCorreosMasivos\log\log.txt";

            StreamWriter sw = new StreamWriter(path, true);

            StackTrace stacktrace = new StackTrace();
            sw.WriteLine(fecha + hora);
            sw.WriteLine(stacktrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
            sw.WriteLine("");

            sw.Flush();
            sw.Close();
        }
    }
}

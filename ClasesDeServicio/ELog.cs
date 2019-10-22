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
            try
            {
                string fecha = System.DateTime.Now.ToString("yyyy-MM-dd");
                string hora = System.DateTime.Now.ToString("HH:mm:ss");
                string pathCarpeta = @"c:\logService";
                string path = @"c:\logService\log.txt";

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
                sw.WriteLine(fecha + ' ' + hora);
                sw.WriteLine(stacktrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
                sw.WriteLine("");
                sw.Flush();
                sw.Close();
            }
            catch (Exception)
            {  
                throw;
            }
            
        }
    }
}

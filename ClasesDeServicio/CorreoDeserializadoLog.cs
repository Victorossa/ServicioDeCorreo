using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeServicio
{
    public class CorreoDeserializadoLog
    {
        public string Subject { get; set; }
        public string From { get; set; }
        public List<Recipients> Recipients { get; set; }
    }
}

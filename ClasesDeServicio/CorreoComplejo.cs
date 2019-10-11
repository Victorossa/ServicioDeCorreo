using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeServicio
{
    public class CorreoComplejo
    {
        public string Subject { get; set; }
        public string From { get; set; }
        public Template Template { get; set; }
        public string ReplyTo { get; set; }
        public List<Recipients> Recipients { get; set; }
        public List<Attachment> Attachments { get; set; }
        
    }
}

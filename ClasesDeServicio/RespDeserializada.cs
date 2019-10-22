using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesDeServicio
{
    public class Data
    {
        public string deliveryId { get; set; }
    }

    public class RootObject
    {
        public string status { get; set; }
        public string description { get; set; }
        public Data data { get; set; }
    }

}

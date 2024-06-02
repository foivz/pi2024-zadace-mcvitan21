using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBus.Models
{
    internal class VozneLinije
    {
        public int ID_linije { get; set; }
        public string Popis_stanica { get; set; }
        public string Raspored_dolazaka { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Retur_Kørselslog
{
    internal class Kørselslog
    {
        public int LogId { get; set; }
        public DateTime LogDato { get; set; }
        public string LogOpgave { get; set; }
        public int BrugerLogId { get; set; }
    }
}

using System;

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

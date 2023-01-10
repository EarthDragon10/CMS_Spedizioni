using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS_Spedizioni.Models
{
    public class StatoSpedizione
    {
        public int IdStatpSpedizione { get; set; }
        public string Stato { get; set; }
        public Spedizione spedizione { get; set; }
        public DettaglioSpedizione dettaglioSpedizione { get; set; }

        static List<StatoSpedizione> ListaStatoSpedizione = new List<StatoSpedizione>();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS_Spedizioni.Models
{
    public class DettaglioSpedizione
    {
        public int IdDettaglioSpedizione { get; set; }
        public string Luogo { get; set; }
        public string Descrizione { get; set; }
        public DateTime OraAggiornamento { get; set; }
        public Cliente cliente { get; set; }
        public Spedizione spedizione { get; set; }
        static List<DettaglioSpedizione> ListaDettaglioSpedizione = new List<DettaglioSpedizione>();
    }
}
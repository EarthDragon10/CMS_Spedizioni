using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace CMS_Spedizioni.Models
{
    public class Spedizione
    {
        public int IdSpedizione { get; set; }
        public DateTime DataSpedizione { get; set; }
        public decimal Peso { get; set; }
        public string Citta { get; set; }
        public string Indirizzo { get; set; }
        public string NomeDestinatario { get; set; }
        public decimal Costo { get; set; }
        public DateTime DataConsegnaPrevista { get; set; }
        public Cliente cliente { get; set; }

        static List<Spedizione> ListaSpedizione = new List<Spedizione>();
    }
}
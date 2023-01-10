using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS_Spedizioni.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public bool IsPrivate { get; set; }
        public string CodiceFiscale { get; set; }
        public string PIva { get; set; }
        public string Nome { get; set; }
        public string Ruolo { get; set; }

        static List<Cliente> ListaCilenti = new List<Cliente>();
    }
}
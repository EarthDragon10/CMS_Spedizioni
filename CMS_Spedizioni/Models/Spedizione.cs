using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace CMS_Spedizioni.Models
{
    public class Spedizione
    {
        [Display(Name="Cerca Ordine Spedizione")]
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
        public static Spedizione GetOrdineSpedizione(int IdSpedizione, string CodiceFIscale)
        {
            //List<Cliente> ListaCilenti = new List<Cliente>();

            SqlConnection connection = Shared.GetConnectionDb();
            connection.Open();
            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@CodiceFiscale", CodiceFIscale);
            command.Parameters.AddWithValue("@IdSpedizione", IdSpedizione);
       
            SqlDataReader reader = Shared.GetReaderAfterSQL("Select * from Cliente inner join Spedizione on Cliente.IdCliente = Spedizione.IdCliente" + 
                                                            "where CodiceFiscale='@CodiceFiscale' and IdSpedizione=@IdSpedizione", connection);

            Spedizione spedizione = new Spedizione();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    spedizione.IdSpedizione = Convert.ToInt32(reader["IdSpedizione"]);
                    spedizione.DataSpedizione = Convert.ToDateTime(reader["DataSpedizione"]);
                    spedizione.Peso = Convert.ToDecimal(reader["Peso"]);
                    spedizione.Costo = Convert.ToDecimal(reader["Costo"]);
                    spedizione.cliente.Nome = reader["Nome"].ToString();
                }
            }
            connection.Close();
            return spedizione;
        }
    }
}
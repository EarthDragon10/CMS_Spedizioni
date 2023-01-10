using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CMS_Spedizioni.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public bool IsPrivate { get; set; }
        public string CodiceFiscale { get; set; }
        public string PIva { get; set; }
        public string Nome { get; set; }
        public string Ruolo { get; set; }

        static List<Cliente> ListaCilenti = new List<Cliente>();

        public static List<Cliente> GetListaClienti()
        {
            List<Cliente> ListaCilenti = new List<Cliente>();

            SqlConnection connection = Shared.GetConnectionDb();
            connection.Open();
            SqlDataReader reader = Shared.GetReaderAfterSQL("Select * From Cliente", connection);

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.IdCliente = Convert.ToInt32(reader["IdCliente"]);
                    cliente.IsPrivate = Convert.ToBoolean(reader["IsPrivate"]);
                    cliente.CodiceFiscale = reader["CodiceFiscale"].ToString();
                    cliente.PIva = reader["PIva"].ToString();
                    cliente.Nome = reader["Nome"].ToString();
                    ListaCilenti.Add(cliente);
                }
            }
            connection.Close();
            return ListaCilenti;
        }
    }
}
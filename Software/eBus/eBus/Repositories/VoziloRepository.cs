using DBLayer;
using eBus.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace eBus.Repositories
{
    internal class VoziloRepository
    {
        public static Vozilo GetVozilo(int id)
        {
            Vozilo vozilo = null;

            string sql = $"SELECT * FROM Vozilo WHERE ID_vozila = {id}";
            Database.OpenConnection();
            var reader = Database.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                vozilo = CreateVoziloObject(reader);
                reader.Close();
            }

            Database.CloseConnection();
            return vozilo;
        }

        public static List<Vozilo> GetVozila()
        {
            var vozila = new List<Vozilo>();

            string sql = "SELECT * FROM Vozilo";
            Database.OpenConnection();
            var reader = Database.GetDataReader(sql);
            while (reader.Read())
            {
                Vozilo vozilo = CreateVoziloObject(reader);
                vozila.Add(vozilo);
            }

            reader.Close();
            Database.CloseConnection();

            return vozila;
        }

        private static Vozilo CreateVoziloObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["ID_vozila"].ToString());
            string model = reader["Model"].ToString();
            string opis = reader["Opis"].ToString();

            var vozilo = new Vozilo
            {
                ID_vozila = id,
                Model = model,
                Opis = opis
            };

            return vozilo;
        }
    }
}

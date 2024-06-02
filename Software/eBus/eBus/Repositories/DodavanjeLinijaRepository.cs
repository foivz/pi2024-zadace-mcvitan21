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
    internal class DodavanjeLinijaRepository
    {
        public static class VozneLinijeRepository
        {
            public static VozneLinije GetVoznaLinija(int id)
            {
                VozneLinije voznaLinija = null;

                string sql = $"SELECT * FROM VozneLinije WHERE ID_linije = {id}";
                Database.OpenConnection();
                var reader = Database.GetDataReader(sql);
                if (reader.HasRows)
                {
                    reader.Read();
                    voznaLinija = CreateVozneLinijeObject(reader);
                    reader.Close();
                }

                Database.CloseConnection();
                return voznaLinija;
            }

            public static List<VozneLinije> GetVozneLinije()
            {
                var vozneLinije = new List<VozneLinije>();

                string sql = "SELECT * FROM VozneLinije";
                Database.OpenConnection();
                var reader = Database.GetDataReader(sql);
                while (reader.Read())
                {
                    VozneLinije voznaLinija = CreateVozneLinijeObject(reader);
                    vozneLinije.Add(voznaLinija);
                }

                reader.Close();
                Database.CloseConnection();

                return vozneLinije;
            }

            private static VozneLinije CreateVozneLinijeObject(SqlDataReader reader)
            {
                int id = int.Parse(reader["ID_linije"].ToString());
                string popisStanica = reader["Popis_stanica"].ToString();
                string rasporedDolazaka = reader["Raspored_dolazaka"].ToString();

                var voznaLinija = new VozneLinije
                {
                    ID_linije = id,
                    Popis_stanica = popisStanica,
                    Raspored_dolazaka = rasporedDolazaka
                };

                return voznaLinija;
            }
        }
    }
}

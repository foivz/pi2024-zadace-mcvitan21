using DBLayer;
using eBus.Models;
using eBus.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static eBus.Repositories.DodavanjeLinijaRepository;

namespace eBus
{
    public partial class DodavanjeVozneLinije : Form
    {
        private VozneLinije selectedVoznaLinija;

        public DodavanjeVozneLinije()
        {
            InitializeComponent();
        }

        public DodavanjeVozneLinije(Vozilo selectedVoznaLinija)
        {
            InitializeComponent();
            // Initialization or assignment logic if needed
        }

        public DodavanjeVozneLinije(VozneLinije selectedVoznaLinija)
        {
            InitializeComponent();
            this.selectedVoznaLinija = selectedVoznaLinija;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertData(brojLinije.Text, opisLinije.Text);
        }

        public void insertData(string naziv, string opis)
        {
            string sql = "INSERT INTO vozilo (Model, Opis) VALUES (@naziv, @opis)";
            Database.OpenConnection();
            try
            {
                using (SqlCommand command = new SqlCommand(sql, Database.Connection))
                {
                    command.Parameters.AddWithValue("@naziv", naziv);
                    command.Parameters.AddWithValue("@opis", opis);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                Database.CloseConnection();
            }
        }
        public void updateData(string id, string model)
        {
            string sql = "UPDATE vozilo SET Model = @model WHERE ID_vozila = @id";
            Database.OpenConnection();
            try
            {
                using (SqlCommand command = new SqlCommand(sql, Database.Connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@model", model);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                Database.CloseConnection();
            }
        }

        private void DodavanjeVozneLinije_Load(object sender, EventArgs e)
        {
            SetFormText();
            var vozila = VoziloRepository.GetVozila();
        }

        private void SetFormText()
        {
            if (selectedVoznaLinija != null)
            {
                Text = selectedVoznaLinija.Popis_stanica;
            }
        }

        private void DodavanjeVozneLinije_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateData(idAzuriraj.Text, metodaAzuriraj.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

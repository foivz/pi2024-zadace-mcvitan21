using eBus.Models;
using eBus.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        public DodavanjeVozneLinije(Vozilo selectedVoznaLinija)
        {
            InitializeComponent();
        }

        public DodavanjeVozneLinije(VozneLinije selectedVoznaLinija)
        {
            this.selectedVoznaLinija = selectedVoznaLinija;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            var selectedLinija = comboBox1.SelectedItem as VozneLinije;
            if (selectedLinija != null)
            {
                richTextBox1.Text = selectedLinija.Popis_stanica;
            }
            else
            {
                richTextBox1.Text = "Nema odabrane linije.";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void DodavanjeVozneLinije_Load(object sender, EventArgs e)
        {
            SetFormText();
            var vozila = VoziloRepository.GetVozila();
            comboBox1.DataSource = vozila;
        }

        private void SetFormText()
        {
            Text = selectedVoznaLinija.Popis_stanica;
        }

    }
}

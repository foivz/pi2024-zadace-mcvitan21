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

namespace eBus
{
    public partial class Form2 : Form
    {
        private Vozilo selectedVoznaLinija;

        public Form2()
        {
            InitializeComponent();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ShowVozila();
        }

        private void ShowVozila()
        {
            List<Vozilo> vozila = VoziloRepository.GetVozila();
            dgvVozila.DataSource = vozila;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vozilo selectedVozilo = dgvVozila.CurrentRow.DataBoundItem as Vozilo;
            if (selectedVozilo != null)
            {
                DodavanjeVozneLinije frmDodavanjeVozneLinije = new DodavanjeVozneLinije(selectedVozilo);
                frmDodavanjeVozneLinije.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvVozila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

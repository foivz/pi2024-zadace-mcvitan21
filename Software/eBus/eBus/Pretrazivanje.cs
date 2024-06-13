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
    public partial class Pretrazivanje : Form
    {
        public Pretrazivanje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowVozila();
        }

        private void ShowVozila()
        {
            int id;
            if (int.TryParse(textBox1.Text, out id))
            {
                Vozilo vozilo = VoziloRepository.GetVozilo(id);
                if (vozilo != null)
                {
                    List<Vozilo> vozila = new List<Vozilo> { vozilo };
                    voziloPretrazi.DataSource = vozila;
                }
                else
                {
                    // Handle the case where the vehicle is not found
                    MessageBox.Show("Vozilo not found.");
                    voziloPretrazi.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }
    }
}

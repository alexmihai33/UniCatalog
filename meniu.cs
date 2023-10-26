using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOProiect
{
    public partial class meniu : Form
    {


        public meniu()
        {
            InitializeComponent();
        }

        private void gestionare_s_Click(object sender, EventArgs e)
        {
            Hide();
            Studenti studenti = new Studenti();
            studenti.Show();
        }

        private void inapoi_m_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();    
        }

        private void gestionare_c_Click(object sender, EventArgs e)
        {
            Hide();
            Cadre cadre = new Cadre();
            cadre.Show();
        }

        private void cicluri_Click(object sender, EventArgs e)
        {
            Hide();
            Cicluri_de_Invatamant c= new Cicluri_de_Invatamant();
            c.Show();
        }

        private void programe_Click(object sender, EventArgs e)
        {
            Hide();
            Programe_de_Studii p = new Programe_de_Studii();
            p.Show();
        }

        private void discipline_Click(object sender, EventArgs e)
        {
            Hide();
            Discipline d= new Discipline();
            d.Show();
        }

        private void gestionare_g_Click(object sender, EventArgs e)
        {
            Hide();
            Grupe gestionare = new Grupe();
            gestionare.Show();
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            Hide();
            Catalog catalog = new Catalog();
            catalog.Show();
        }

        private void meniu_Load(object sender, EventArgs e)
        {

        }
    }
}

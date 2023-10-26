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
    public partial class Cicluri_de_Invatamant : Form
    {
        public Cicluri_de_Invatamant()
        {
            InitializeComponent();
        }

        private void add_ci_Click(object sender, EventArgs e)
        {
            Hide();
            Adaugare_Ciclu c = new Adaugare_Ciclu();
            c.Show();
        }

        private void delete_ci_Click(object sender, EventArgs e)
        {
            Hide();
            Eliminare_Ciclu c = new Eliminare_Ciclu();
            c.Show();

        }

        private void vizualizare_ci_Click(object sender, EventArgs e)
        {
            Hide();
            Vizualizare_Cicluri v = new Vizualizare_Cicluri();
            v.Show();
        }

        private void back_ci_Click(object sender, EventArgs e)
        {
            Hide();
            meniu m= new meniu();
            m.Show();
        }
    }
}

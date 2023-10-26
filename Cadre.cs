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
    public partial class Cadre : Form
    {
        public Cadre()
        {
            InitializeComponent();
        }

        private void add_c_Click(object sender, EventArgs e)
        {
            Hide();
            Adaugare_Cadru add = new Adaugare_Cadru();
            add.Show();
        }

        private void delete_c_Click(object sender, EventArgs e)
        {
            Hide();
            Eliminare_Cadru elim = new Eliminare_Cadru();
            elim.Show();
        }

        private void back_c_Click(object sender, EventArgs e)
        {
            Hide();
            meniu meniu= new meniu();
            meniu.Show();
        }

        private void view_c_Click(object sender, EventArgs e)
        {
            Hide();
            Vizualizare_Cadre c = new Vizualizare_Cadre();
            c.Show();
        }
    }
}

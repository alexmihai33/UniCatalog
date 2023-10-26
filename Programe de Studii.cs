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
    public partial class Programe_de_Studii : Form
    {
        public Programe_de_Studii()
        {
            InitializeComponent();
        }

        private void add_p_Click(object sender, EventArgs e)
        {
            Hide();
            Adaugare_Programa a = new Adaugare_Programa();
            a.Show();
        }

        private void delete_p_Click(object sender, EventArgs e)
        {
            Hide();
            Eliminare_Programa ep = new Eliminare_Programa();
            ep.Show();
        }

        private void view_p_Click(object sender, EventArgs e)
        {
            Hide();
            Vizualizare_Programe v = new Vizualizare_Programe();
            v.Show();
        }

        private void back_p_Click(object sender, EventArgs e)
        {
            Hide();
            meniu meniu = new meniu();
            meniu.Show();
        }
    }
}

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
    public partial class Grupe : Form
    {
        public Grupe()
        {
            InitializeComponent();
        }

        private void add_g_Click(object sender, EventArgs e)
        {
            Hide();
            Adaugare_Grupa ag=new Adaugare_Grupa();
            ag.Show();
        }

        private void elim_g_Click(object sender, EventArgs e)
        {
            Hide();
            Eliminare_Grupe eliminare_Grupe =   new Eliminare_Grupe();
            eliminare_Grupe.Show(); 
        }

        private void view_g_Click(object sender, EventArgs e)
        {
            Hide();
            Vizualizare_Grupe v = new Vizualizare_Grupe();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            meniu m =  new meniu();
            m.Show();
        }
    }
}

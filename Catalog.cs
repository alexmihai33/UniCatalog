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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Adaugare_Nota adaugare = new Adaugare_Nota();
            adaugare.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Vizualizare_Note n = new Vizualizare_Note();
            n.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            meniu meniu = new meniu();
            meniu.Show();
        }
    }
}

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
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void add_s_Click(object sender, EventArgs e)
        {
            Hide();
            Adaugare_Student adaugare_Student = new Adaugare_Student();
            adaugare_Student.Show();
        }

        private void vizualizare_Click(object sender, EventArgs e)
        {
            Hide();
            Vizualizare_Studenti vizualizare_s=new Vizualizare_Studenti();
            vizualizare_s.Show();

        }

        private void delete_s_Click(object sender, EventArgs e)
        {
            Hide();
            Eliminare_Student eliminare=new Eliminare_Student();
            eliminare.Show();
        }

        private void back_s_Click(object sender, EventArgs e)
        {
            Hide();
            meniu meniu = new meniu();
            meniu.Show();
        }
    }
}

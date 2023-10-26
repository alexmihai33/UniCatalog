using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POOProiect
{
    public partial class Discipline : Form
    {
        public Discipline()
        {
            InitializeComponent();
       
        }

        private void add_d_Click(object sender, EventArgs e)
        {
            Hide();
            Adaugare_Disciplina ad = new Adaugare_Disciplina();
            ad.Show();
        }

        private void delete_d_Click(object sender, EventArgs e)
        {
            Hide();
            Eliminare_Disciplina d = new Eliminare_Disciplina();
            d.Show();
        }

        private void view_d_Click(object sender, EventArgs e)
        {
            Hide();
            Vizualizare_Discipline d = new Vizualizare_Discipline();
            d.Show();
        }

        private void back_d_Click(object sender, EventArgs e)
        {
            Hide();
            meniu m = new meniu();
            m.Show();
        }
    }
}

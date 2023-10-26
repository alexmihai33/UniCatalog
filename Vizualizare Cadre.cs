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

namespace POOProiect
{
    public partial class Vizualizare_Cadre : Form
    {
        public Vizualizare_Cadre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Cadre c =   new Cadre();
            c.Show();
        }

        private void Vizualizare_Cadre_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM cadre_didactice", con);
            SqlDataReader dr = cmd.ExecuteReader();



            vizualizare_c.View = View.Details;
            vizualizare_c.GridLines = true;
            vizualizare_c.FullRowSelect = true;

            vizualizare_c.Columns.Add("Nume", 100);
            vizualizare_c.Columns.Add("Prenume", 100);
            vizualizare_c.Columns.Add("Marca angajat", 100);
            vizualizare_c.Columns.Add("Titlu", 100);

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());

                vizualizare_c.Items.Add(lv);
            }

            dr.Close();
            con.Close();
        }
    }
}

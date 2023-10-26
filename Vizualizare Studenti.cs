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
    public partial class Vizualizare_Studenti : Form
    {
        public Vizualizare_Studenti()
        {
            InitializeComponent();
        }

        private void vizualizare_s_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Vizualizare_Studenti_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM studenti", con);
            SqlDataReader dr = cmd.ExecuteReader();

            

            vizualizare_s.View = View.Details;
            vizualizare_s.GridLines = true;
            vizualizare_s.FullRowSelect = true;


            vizualizare_s.Columns.Add("Numar Matricol", 100);
            vizualizare_s.Columns.Add("Nume", 100);
            vizualizare_s.Columns.Add("Prenume", 100);
            vizualizare_s.Columns.Add("Initiala Tata", 100);
            vizualizare_s.Columns.Add("CNP", 100);
            vizualizare_s.Columns.Add("Data Inscriere", 100);
            vizualizare_s.Columns.Add("Ciclu Invatamant", 100);
            vizualizare_s.Columns.Add("Medie de intrare", 100);

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                lv.SubItems.Add(dr[4].ToString());
                lv.SubItems.Add(dr[5].ToString());
                lv.SubItems.Add(dr[6].ToString());
                lv.SubItems.Add(dr[7].ToString());

                vizualizare_s.Items.Add(lv);
            }

            dr.Close();
            con.Close();
        }

        private void back_vs_Click(object sender, EventArgs e)
        {
            Hide();
            Studenti s = new Studenti();
            s.Show();
        }
    }
}

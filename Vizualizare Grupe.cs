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
    public partial class Vizualizare_Grupe : Form
    {
        public Vizualizare_Grupe()
        {
            InitializeComponent();
        }

        private void Vizualizare_Grupe_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM grupe", con);
            SqlDataReader dr = cmd.ExecuteReader();



            vizualizare_g.View = View.Details;
            vizualizare_g.GridLines = true;
            vizualizare_g.FullRowSelect = true;

            vizualizare_g.Columns.Add("C", 100);
            vizualizare_g.Columns.Add("F", 100);
            vizualizare_g.Columns.Add("P", 100);
            vizualizare_g.Columns.Add("A", 100);

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());

                vizualizare_g.Items.Add(lv);
            }

            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Grupe grupe = new Grupe();
            grupe.Show();
        }
    }
}

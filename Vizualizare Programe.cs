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
    public partial class Vizualizare_Programe : Form
    {
        public Vizualizare_Programe()
        {
            InitializeComponent();
        }

        private void back_vp_Click(object sender, EventArgs e)
        {
            Hide();
            Programe_de_Studii p = new Programe_de_Studii();
            p.Show();
        }


        private void Vizualizare_Programe_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM programe_studii", con);
            SqlDataReader dr = cmd.ExecuteReader();



            vizualizare_p.View = View.Details;
            vizualizare_p.GridLines = true;
            vizualizare_p.FullRowSelect = true;

            vizualizare_p.Columns.Add("Ciclu", 100);
            vizualizare_p.Columns.Add("Cod", 100);
            vizualizare_p.Columns.Add("Tip", 100);
            vizualizare_p.Columns.Add("Ani", 100);

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());

                vizualizare_p.Items.Add(lv);
            }

            dr.Close();
            con.Close();
        }
    }
}

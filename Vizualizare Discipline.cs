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
    public partial class Vizualizare_Discipline : Form
    {
        public Vizualizare_Discipline()
        {
            InitializeComponent();
        }

        private void back_vd_Click(object sender, EventArgs e)
        {
            Hide();
            Discipline d = new Discipline();
            d.Show();
        }

        public void BindData()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            SqlDataReader dr;
            con.Open();
            SqlCommand cmd = new SqlCommand("select tip from programe_studii", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                programe_d_cb.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void Vizualizare_Discipline_Load(object sender, EventArgs e)
        {
            BindData();
            vizualizare_d.View = View.Details;
            vizualizare_d.GridLines = true;
            vizualizare_d.FullRowSelect = true;

            vizualizare_d.Columns.Add("An", 100);
            vizualizare_d.Columns.Add("Semestru", 100);
            vizualizare_d.Columns.Add("Cod", 100);
            vizualizare_d.Columns.Add("Nume", 100);
            vizualizare_d.Columns.Add("Acronim", 100);
            vizualizare_d.Columns.Add("Credite", 100);
            vizualizare_d.Columns.Add("Programa", 100);  
        }

        private void programe_d_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            vizualizare_d.Items.Clear();
            if (programe_d_cb.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM discipline WHERE programa = '" + programe_d_cb.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
               

                while (dr.Read())
                {
                    ListViewItem lv = new ListViewItem(dr[0].ToString());
                    lv.SubItems.Add(dr[1].ToString());
                    lv.SubItems.Add(dr[2].ToString());
                    lv.SubItems.Add(dr[3].ToString());
                    lv.SubItems.Add(dr[4].ToString());
                    lv.SubItems.Add(dr[5].ToString());
                    lv.SubItems.Add(dr[6].ToString());

                    vizualizare_d.Items.Add(lv);
                }

                dr.Close();
                con.Close();
            }
        }
    }
}

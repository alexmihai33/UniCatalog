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
    public partial class Vizualizare_Note : Form
    {
        public Vizualizare_Note()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Catalog c= new Catalog();
            c.Show();
        }

        private void Vizualizare_Note_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM catalog_note", con);
            SqlDataReader dr = cmd.ExecuteReader();



            vizualizare_n.View = View.Details;
            vizualizare_n.GridLines = true;
            vizualizare_n.FullRowSelect = true;

            vizualizare_n.Columns.Add("Numar matricol student", 100);
            vizualizare_n.Columns.Add("Disciplina", 100);
            vizualizare_n.Columns.Add("Nota", 100);

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());

                vizualizare_n.Items.Add(lv);
            }

            dr.Close();
            con.Close();
        }
    }
}

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
    public partial class Vizualizare_Cicluri : Form
    {
        public Vizualizare_Cicluri()
        {
            InitializeComponent();
        }

        private void Vizualizare_Cicluri_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM cicluri_invatamant", con);
            SqlDataReader dr = cmd.ExecuteReader();



            vizualizare_ci.View = View.Details;
            vizualizare_ci.GridLines = true;
            vizualizare_ci.FullRowSelect = true;


            vizualizare_ci.Columns.Add("Cod", 100);
            vizualizare_ci.Columns.Add("Tip", 100);

            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
  
                vizualizare_ci.Items.Add(lv);
            }

            dr.Close();
            con.Close();
        }

        private void back_vci_Click(object sender, EventArgs e)
        {
            Hide();
            Cicluri_de_Invatamant c = new Cicluri_de_Invatamant();
            c.Show();
        }
    }
}

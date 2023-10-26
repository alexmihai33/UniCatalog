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
    public partial class Adaugare_Cadru : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        public Adaugare_Cadru()
        {
            InitializeComponent();
        }

        private void Adaugare_Cadru_Load(object sender, EventArgs e)
        {

        }

        private void confirm_c_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();


            if (marcac_tb.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from cadre_didactice where marca_angajat='" + marcac_tb.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Exista deja un cadru didactic cu aceasta marca de angajat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into cadre_didactice values(@nume,@prenume,@marca_angajat,@titlu)", con);
                    cmd.Parameters.AddWithValue("nume", numec_tb.Text);
                    cmd.Parameters.AddWithValue("prenume", prenumec_tb.Text);
                    cmd.Parameters.AddWithValue("marca_angajat", marcac_tb.Text);
                    cmd.Parameters.AddWithValue("titlu", titluc_tb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadrul didactic a fost adaugat");

                }

            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare");
            }

            con.Close();
            Hide();
            Cadre c = new Cadre();
            c.Show();
        }

        private void back_ac_Click(object sender, EventArgs e)
        {
            Hide();
            Cadre cadre = new Cadre();
            cadre.Show();
        }
    }
}

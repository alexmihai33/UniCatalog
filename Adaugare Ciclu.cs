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
    public partial class Adaugare_Ciclu : Form
    {
        public Adaugare_Ciclu()
        {
            InitializeComponent();
        }

        private void add_ci_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            if (cod_ci_tb.Text != string.Empty)
            {
                SqlCommand cmd;
                SqlDataReader dr;
                cmd = new SqlCommand("select * from cicluri_invatamant where cod='" + cod_ci_tb.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Exista deja un ciclu cu acest cod", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into cicluri_invatamant values(@cod,@tip)", con);
                    cmd.Parameters.AddWithValue("cod", cod_ci_tb.Text);
                    cmd.Parameters.AddWithValue("tip", add_ci_tb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ciclul de invatamant a fost adaugat", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare");
            }

            con.Close();
            Hide();
            Cicluri_de_Invatamant c = new Cicluri_de_Invatamant();
            c.Show();
        }

        private void back_aci_Click(object sender, EventArgs e)
        {
            Hide();
            Cicluri_de_Invatamant c = new Cicluri_de_Invatamant();
            c.Show();
        }
    }
}

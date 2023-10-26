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
    public partial class Adaugare_Programa : Form
    {
        public Adaugare_Programa()
        {
            InitializeComponent();
        }

        private void confirm_add_p_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();


            if (cod_ci_p_tb.Text != string.Empty)
            {
                SqlCommand cmd;
                SqlDataReader dr;
                cmd = new SqlCommand("select * from programe_studii where cod='" + cod_p_tb.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Exista deja o programa cu acest cod", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into programe_studii values(@ciclu,@cod,@tip,@ani)", con);
                    cmd.Parameters.AddWithValue("ciclu", cod_ci_p_tb.Text);
                    cmd.Parameters.AddWithValue("cod", cod_p_tb.Text);
                    cmd.Parameters.AddWithValue("tip", tip_p_tb.Text);
                    cmd.Parameters.AddWithValue("ani", ani_p_tb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Programa a fost adaugata");

                }

            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare");
            }

            con.Close();
            Hide();
            Programe_de_Studii p = new Programe_de_Studii();
            p.Show();
        }

        private void back_add_p_Click(object sender, EventArgs e)
        {
            Hide();
            Programe_de_Studii p = new Programe_de_Studii();
            p.Show();
        }
    }
}

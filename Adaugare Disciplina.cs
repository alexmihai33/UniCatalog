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
    public partial class Adaugare_Disciplina : Form
    {
        public Adaugare_Disciplina()
        {
            InitializeComponent();
        }

        private void confirm_add_d_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();


            if (cod_d_tb.Text != string.Empty)
            {
                SqlCommand cmd;
                SqlDataReader dr;
                cmd = new SqlCommand("select * from discipline where cod='" + cod_d_tb.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Exista deja aceasta disciplina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into discipline values(@an,@semestru,@cod,@nume,@acronim,@credite,@programa)", con);
                    cmd.Parameters.AddWithValue("an", an_d_tb.Text);
                    cmd.Parameters.AddWithValue("semestru", sem_d_tb.Text);
                    cmd.Parameters.AddWithValue("cod", cod_d_tb.Text);
                    cmd.Parameters.AddWithValue("nume", nume_d_tb.Text);
                    cmd.Parameters.AddWithValue("acronim", acronim_d_tb.Text);
                    cmd.Parameters.AddWithValue("credite", credite_d_tb.Text);
                    cmd.Parameters.AddWithValue("programa", programa_d_tb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Disciplina a fost adaugata");

                }

            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare");
            }

            con.Close();
            Hide();
            Discipline d = new Discipline();
            d.Show();
        }

        private void back_ad_Click(object sender, EventArgs e)
        {
            Hide();
            Discipline d = new Discipline();
            d.Show();
        }
    }
}

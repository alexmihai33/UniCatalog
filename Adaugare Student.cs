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
    public partial class Adaugare_Student : Form
    {
        
        public Adaugare_Student()
        {
            InitializeComponent();
        }

        private void confirm_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            
            
            if (nrmat_tb.Text != string.Empty)
            {
                SqlCommand cmd;
                SqlDataReader dr;
                cmd = new SqlCommand("select * from studenti where nr_matricol='" + nrmat_tb.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Exista deja un student cu acest numar matricol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into studenti values(@nr_matricol,@nume,@prenume,@initiala_tata,@CNP,@data_inscriere,@ciclu_invatamant,@medie)", con);
                    cmd.Parameters.AddWithValue("nr_matricol", nrmat_tb.Text);
                    cmd.Parameters.AddWithValue("nume", nume_tb.Text);
                    cmd.Parameters.AddWithValue("prenume", prenume_tb.Text);
                    cmd.Parameters.AddWithValue("initiala_tata", inittata_tb.Text);
                    cmd.Parameters.AddWithValue("CNP", cnp_tb.Text);
                    cmd.Parameters.AddWithValue("data_inscriere", datains_date.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("ciclu_invatamant", cicluinv_tb.Text);
                    cmd.Parameters.AddWithValue("medie", medie_tb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Studentul a fost adaugat");
                    
                }

            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare");
            }

            con.Close();
            Hide();
            Studenti studenti = new Studenti();
            studenti.Show();
        }

        private void back_as_Click(object sender, EventArgs e)
        {
            Hide();
            Studenti studenti = new Studenti();
            studenti.Show();

        }

        private void Adaugare_Student_Load(object sender, EventArgs e)
        {

        }
    }

}

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
    public partial class Adaugare_Nota : Form
    {
        public Adaugare_Nota()
        {
            InitializeComponent();
        }

        private void Inapoi_Click(object sender, EventArgs e)
        {
            Hide();
            Catalog c=new Catalog();
            c.Show();
        }

        private void confirm_an_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();

            if (nr_mat_tb.Text != string.Empty && disc_tb.Text != string.Empty && nota_tb.Text != string.Empty)
            {
                SqlCommand cmd;
                cmd = new SqlCommand("insert into catalog_note values(@nr_matricol_student,@disciplina,@nota)", con);
                cmd.Parameters.AddWithValue("nr_matricol_student", nr_mat_tb.Text);
                cmd.Parameters.AddWithValue("disciplina", disc_tb.Text);
                cmd.Parameters.AddWithValue("nota", nota_tb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Nota a fost adaugata");



            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare");
            }

            con.Close();
            Hide();
            Catalog c= new Catalog();
            c.Show();

        }
    }
}

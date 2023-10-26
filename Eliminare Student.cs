using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOProiect
{
    public partial class Eliminare_Student : Form
    {
        SqlCommand cmd;
        public Eliminare_Student()
        {
            InitializeComponent();
        }

        private void confirm_es_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            try
            {
                cmd = new SqlCommand("DELETE FROM studenti WHERE nr_matricol='"+eliminares_tb.Text+"'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Studentul a fost eliminat");
                Hide();
                Studenti studenti= new Studenti();
                studenti.Show();
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
                Trace.WriteLine(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
                
           
        }

        private void back_es_Click(object sender, EventArgs e)
        {
            Hide();
            Studenti studenti = new Studenti();
            studenti.Show();
        }

        private void Eliminare_Student_Load(object sender, EventArgs e)
        {

        }

    }
}

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
    public partial class Eliminare_Programa : Form
    {
        public Eliminare_Programa()
        {
            InitializeComponent();
        }

        private void confirm_ep_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            try
            {
                cmd = new SqlCommand("DELETE FROM programe_studii WHERE cod='" + delete_p_tb.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Programa de studii a fost eliminat.");
                Hide();
                Programe_de_Studii p = new Programe_de_Studii();
                p.Show();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                Trace.WriteLine(ex.StackTrace);
            }
            finally
            {
                con.Close();
            }
        }

        private void back_ep_Click(object sender, EventArgs e)
        {
            Hide();
            Programe_de_Studii p = new Programe_de_Studii();
            p.Show();
        }
    }
}

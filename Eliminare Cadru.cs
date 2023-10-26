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
    public partial class Eliminare_Cadru : Form
    {
        SqlCommand cmd;

        public Eliminare_Cadru()
        {
            InitializeComponent();
        }

        private void deletec_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            try
            {
                cmd = new SqlCommand("DELETE FROM cadre_didactice WHERE marca_angajat='" + deletec_tb.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadrul didactic a fost eliminat.");
                Hide();
                Cadre cadre = new Cadre();
                cadre.Show();
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

        private void back_ec_Click(object sender, EventArgs e)
        {
            Hide();
            Cadre cadre = new Cadre();
            cadre.Show();
        }
    }
}

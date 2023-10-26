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
    public partial class Eliminare_Grupe : Form
    {
        public Eliminare_Grupe()
        {
            InitializeComponent();
        }

        private void confirm_eg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM grupe WHERE C='" + ci_tb.Text + "' AND F='" + fi_tb.Text + "' AND P='" + ps_tb.Text + "' AND A='" + ca_tb.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grupa a fost eliminata");
                Hide();
                Grupe g = new Grupe();
                g.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Grupe grupe = new Grupe(); 
            grupe.Show();
        }
    }
}

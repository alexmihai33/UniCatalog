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
    public partial class Eliminare_Disciplina : Form
    {
        public Eliminare_Disciplina()
        {
            InitializeComponent();
        }

        private void confirm_ed_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            try
            {
                cmd = new SqlCommand("DELETE FROM discipline WHERE cod='" + delete_d_tb.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Disciplina a fost eliminata.");
                Hide();
                Discipline d = new Discipline();
                d.Show();
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

        private void back_ed_Click(object sender, EventArgs e)
        {
            Hide();
            Discipline discipline = new Discipline();
            discipline.Show();  
        }
    }
}

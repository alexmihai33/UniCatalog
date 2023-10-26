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
    public partial class Adaugare_Grupa : Form
    {
        public Adaugare_Grupa()
        {
            InitializeComponent();
        }

        private void confirm_ag_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();


            if (ci_tb.Text != string.Empty)
            {
                SqlCommand cmd;
                    cmd = new SqlCommand("insert into grupe values(@C,@F,@P,@A)", con);
                    cmd.Parameters.AddWithValue("C", ci_tb.Text);
                    cmd.Parameters.AddWithValue("F", fi_tb.Text);
                    cmd.Parameters.AddWithValue("P", ps_tb.Text);
                    cmd.Parameters.AddWithValue("A", ca_tb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Grupa a fost adaugata");

                

            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare");
            }

            con.Close();
            Hide();
            Grupe grupe = new Grupe();
            grupe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Grupe g =   new Grupe();
            g.Show();
        }
    }
}

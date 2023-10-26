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
    public partial class Inregistrare : Form
    {
        SqlDataReader dr;
        SqlCommand cmd;
        public Inregistrare()
        {
            InitializeComponent();
        }

        private void Inregistrare_Load(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.Show();
        }

        private void register_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();


            if (pass_tb_i.Text != string.Empty || user_tb_i.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from conturi where username='" + user_tb_i.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Numele de utilizator este deja existent, incercati altul", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into conturi values(@username,@parola,@administrator,@secretar,@cadru_didactic)", con);
                    cmd.Parameters.AddWithValue("username", user_tb_i.Text);
                    cmd.Parameters.AddWithValue("parola", pass_tb_i.Text);
                    if (admin_cb.Checked == true)
                        cmd.Parameters.AddWithValue("administrator", "da");
                    else
                        cmd.Parameters.AddWithValue("administrator", "nu");
                    if (secretar_cb.Checked == true)
                        cmd.Parameters.AddWithValue("secretar", "da");
                    else
                        cmd.Parameters.AddWithValue("secretar", "nu");
                    if (cadru_cb.Checked == true)
                        cmd.Parameters.AddWithValue("cadru_didactic", "da");
                    else
                        cmd.Parameters.AddWithValue("cadru_didactic", "nu");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contul dumneavoastra a fost creat. Va puteti conecta");
                }

            }
            else
            {
                MessageBox.Show("Va rugam introduceti datele necesare", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            Hide();
            Login login = new Login();
            login.Show();
        }
    }
}

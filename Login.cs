using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace POOProiect
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-63GC3A1;Initial Catalog=conturi;Integrated Security=True");
        }


        private void register_Click(object sender, EventArgs e)
        {
            Hide();
            Inregistrare inregistrare = new Inregistrare();
            inregistrare.Show();
        }

        private void logare_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-63GC3A1;Initial Catalog=ProiectPOO;Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.conturi WHERE username='" + user_tb.Text + "' AND parola = '" + pass_tb.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {              
                Hide();
                meniu m = new meniu();
                m.Show();
            }
            else
            {
                MessageBox.Show("Logare nereusita, incercati din nou!");
            }

            con.Close();
        }
    }
}

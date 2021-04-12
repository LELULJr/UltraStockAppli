using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;


namespace PPE
{
    public partial class Connection : Form
    {


        public Connection()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("database=tp_gestion_stock; server=localhost; port=3306; user id = root; pwd=");
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.Parameters.AddWithValue("@email", identifiant.Text);
                command.CommandText =
                    "SELECT * FROM utilisateurs WHERE email=@email ";
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    conn.Close();
                    conn.Open();

                    MySqlCommand cmd = conn.CreateCommand();

                    cmd.Parameters.AddWithValue("@email", identifiant.Text);
                    cmd.CommandText = "SELECT password FROM utilisateurs WHERE email = @email";

                    MySqlDataReader rdr = cmd.ExecuteReader();

                    rdr.Read();

                    if (BCrypt.Net.BCrypt.Verify(MotDePasse.Text, rdr.GetString(0)) == true)
                    {
                        conn.Close();
                        conn.Open();
                        MySqlCommand c = conn.CreateCommand();
                        c.Parameters.AddWithValue("@email", identifiant.Text);
                        c.CommandText = "SELECT id_role FROM utilisateurs WHERE email = @email";








                        MySqlDataReader r = c.ExecuteReader();

                        r.Read();

                        if (r.GetInt32(0) == 3)
                        {
                            Administration page2 = new Administration();
                            page2.Show();
                        }
                        else
                        {
                            MessageBox.Show("vous n'êtes pas administrateur");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mot de passe incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("c'est non");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void MotDePasse_MouseClick(object sender, MouseEventArgs e)
        {
            MotDePasse.SelectAll();
        }

        private void Connection_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace PPE
{
    public partial class Form2 : Form
    {
        private static MySqlConnection conn = new MySqlConnection("database=tp_gestion_stock; server=localhost; port=3306; user id=root; pwd=");

        public Form2(int id_item, int id_tab)
        {
            InitializeComponent();
            dataGridView_Comments.DataSource = display_Comments_Table(id_item, id_tab);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Connexion échouée...");
            }
            conn.Close();
        }

        public DataTable display_Comments_Table(int id_item, int id_tab)
        {

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_com = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_com = new DataTable(); // créé un objet de table de données

            cmd.Parameters.AddWithValue("@id_item", id_item);

            if (id_tab == 2)
            {
                cmd.CommandText = "SELECT c.id_comm, user.username, c.contenu, c.date_create FROM commentaires AS c " +
                    "INNER JOIN user ON user.id = c.id_user " +
                    "WHERE c.id_jeu = @id_item";
            }
            else if (id_tab == 4)
            {
                cmd.CommandText = "SELECT * FROM topic_comment WHERE id_topic = @id_item";
            }
            
            mydtadp_com.SelectCommand = cmd;
            mydtadp_com.Fill(table_com); // rempli cette table par les données récupéré par la commande SQL

            return table_com; // retourne le tableau
        }

        private void dataGridView_Comments_MouseUp(object sender, MouseEventArgs e) // Fonction pour récupérer les valeurs lorsque l'on clic sur un element du tableau 
        {
            int row = dataGridView_Comments.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 

            string id_comm = dataGridView_Comments.Rows[row].Cells[0].Value.ToString();
            string contenu = dataGridView_Comments.Rows[row].Cells[2].Value.ToString(); // sauvegarde le message de la cellule pointé

            textBox_Comment_Content.Text = contenu; // on remplit la TEXTBOX de la valeur sauvegarder (ici l'ID)

            try
            {
                dataGridView_Reponses.DataSource = display_Reponses_Table(Convert.ToInt32(id_comm));
            }
            catch { }
        }

        public DataTable display_Reponses_Table(int id_comm) // Fonction pour charger la table SQL "categorie" 
        {

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_rep = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_rep = new DataTable(); // créé un objet de table de données

            cmd.Parameters.AddWithValue("@id_comm", id_comm);      

            cmd.CommandText = "SELECT rc.id, rc.contenu, rc.date_create, user.username AS user, user.id AS uid FROM reply_comment AS rc " +
                "LEFT JOIN user ON rc.id_user = user.id " +
                "WHERE rc.id_comment = @id_comm";

            mydtadp_rep.SelectCommand = cmd;
            mydtadp_rep.Fill(table_rep); // rempli cette table par les données récupéré par la commande SQL            

            return table_rep; // retourne le tableau
        }

        private void dataGridView_Reponses_MouseUp(object sender, MouseEventArgs e)
        {
            int row = dataGridView_Reponses.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 

            string id_reponse = dataGridView_Reponses.Rows[row].Cells[0].Value.ToString();
            string contenu = dataGridView_Reponses.Rows[row].Cells[1].Value.ToString(); // sauvegarde le message de la cellule pointé
            string id_user = dataGridView_Reponses.Rows[row].Cells[4].Value.ToString();

            textBox_Reponse_Content.Text = contenu; // on remplit la TEXTBOX de le contenu de la réponse séléctionné du commentaire

            label_ID_Reponse.Text = id_reponse;
            label_ID_User.Text = id_user;
        }

        private void Del_Reponse_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id_reponse", label_ID_Reponse.Text);

            command.CommandText = "DELETE FROM reply_comment WHERE id = @id_reponse";
            command.ExecuteNonQuery();

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Suppression effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression!");
            }

            conn.Close();

            dataGridView_Reponses.DataSource = display_Reponses_Table(Convert.ToInt32(label_ID_Reponse.Text));
            conn.Close();
        }
    }

}

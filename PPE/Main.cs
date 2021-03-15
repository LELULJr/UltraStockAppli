﻿using System;
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

    public partial class Administration : Form
    {

        private static MySqlConnection conn = new MySqlConnection("database=tp_gestion_stock; server=localhost; port=3306; user id=root; pwd=" );

        public Administration()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
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

        private void Categorie_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("Categorie_Tab");
            
        }

        private void Jeux_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("Produits");
        }

        private void Evenement_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("Evenement_Tab");
        }

        private void Topic_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("Topic_Tab");
        }

        private void User_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("Utilisateur_Tab");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
                Open_Tab_Categories();
            else if (e.TabPageIndex == 2)
                Open_Tab_Jeux();
            /*else if (e.TabPageIndex == 3)
                Open_Tab_Events();
            else if (e.TabPageIndex == 4)
                Open_Tab_Topics();*/
            else if (e.TabPageIndex == 5)
                Open_Tab_User();
        }

        private void enable_Button(object sender, EventArgs e)
        {
            //Catégorie TAB
            if (textBox_ID_categorie.TextLength != 0)
            {
                Add_Categorie.Enabled = false;
                Edit_Categorie.Enabled = true;
                Del_Categorie.Enabled = true;
            }
            else
            {
                Add_Categorie.Enabled = true;
                Edit_Categorie.Enabled = false;
                Del_Categorie.Enabled = false;
            }

            if (textBox_Name_categorie.TextLength == 0)
            {
                Add_Categorie.Enabled = false;
                Edit_Categorie.Enabled = false;
                Del_Categorie.Enabled = false;
            }

            //Jeux TAB
            if (textBoxID.TextLength != 0)
            {
                Add_Jeu.Enabled = false;
                Edit_Jeu.Enabled = true;
                Del_Jeu.Enabled = true;
                Comment_Jeu.Enabled = true;
            }
            else
            {
                Add_Jeu.Enabled = true;
                Edit_Jeu.Enabled = false;
                Del_Jeu.Enabled = false;
                Comment_Jeu.Enabled = false;
            }

            if (textBoxNom.TextLength == 0 || textBoxDescription.TextLength == 0 || textBoxImage.TextLength == 0)
            {
                Add_Jeu.Enabled = false;
                Edit_Jeu.Enabled = false;
                Del_Jeu.Enabled = false;
            }

            //User TAB
            if (textBox_ID_user.TextLength != 0)
            {
                Reset_User.Enabled = true;
                Edit_User.Enabled = true;
            }
            else
            {
                Reset_User.Enabled = false;
                Edit_User.Enabled = false;
            }

            if (textBox_Username_user.TextLength == 0 || textBox_Email_user.TextLength == 0 || comboBox_Role_user.Text == "")
            {
                Edit_User.Enabled = false;
            }
        }

        //////////////////////// CATEGORIES ///////////////////////////////

        public DataTable display_Categorie_Table() // Fonction pour charger la table SQL "categorie" 
        {
            conn.Close();
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_cat = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_cat = new DataTable(); // créé un objet de table de données

            cmd.CommandText = "SELECT * FROM categories";

            mydtadp_cat.SelectCommand = cmd;
            mydtadp_cat.Fill(table_cat); // rempli cette table par les données récupéré par la commande SQL
            
            return table_cat; // retourne le tableau
        }

        public void Open_Tab_Categories() // Fonction lorsque l'on rentre dans un onglet
        {

            dataGridView_Categorie.DataSource = display_Categorie_Table(); // lancement de la fonction pour charger la table SQL "categorie" dans le tableau indiqué
            dataGridView_Jeux2.DataSource = display_Jeu_Table(); // lancement de la fonction pour charger la table SQL "jeu" dans le tableau indiqué

            conn.Close();

            Add_Categorie.Enabled = false; // désactive tout les bouttons lorsque l'on arrive sur l'onglet
            Edit_Categorie.Enabled = false;
            Del_Categorie.Enabled = false;
        }

        private void dataGridView_Categorie_MouseUp(object sender, MouseEventArgs e) // Fonction pour récupérer les valeurs lorsque l'on clic sur un element du tableau 
        {
            int row = dataGridView_Categorie.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 

            for (int i = 0; i < 2; i++) // boucle pour chaque cellule de la ligne
            {
                string val = dataGridView_Categorie.Rows[row].Cells[i].Value.ToString(); // sauvegarde la valeur de la cellule pointé
                switch (i)
                {
                    case 0: // pour la premiere cellule 
                        textBox_ID_categorie.Text = val; // on remplit la TEXTBOX de la valeur sauvegarder (ici l'ID)
                        break;
                    case 1: // pour la seconde cellule 
                        textBox_Name_categorie.Text = val; // on remplit la TEXTBOX de la valeur sauvegarder (ici le nom)
                        break;
                }
            }
        }

        private void display_Jeu_from_Categorie(object sender, EventArgs e)
        {
            enable_Button(sender, e);

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_jeu = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();

            if (textBox_Name_categorie.Text == "")
            {
                cmd.CommandText = "SELECT * FROM jeux";
            }
            else
            {
                cmd.Parameters.AddWithValue("@name", textBox_Name_categorie.Text);

                cmd.CommandText = "SELECT jeux.id, jeux.name, jeux.description, jeux.site, jeux.images FROM jeux " +
                    "INNER JOIN categoriser ON categoriser.id_jeux = jeux.id " +
                    "INNER JOIN categories ON categories.id = categoriser.id_categories AND categories.name = @name";
            }
            mydtadp_jeu.SelectCommand = cmd;
            
            dataGridView_Jeux2.DataSource = null;
            mydtadp_jeu.Fill(table_jeu);

            dataGridView_Jeux2.DataSource = table_jeu;
        }

        private void Add_Categorie_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@name", textBox_Name_categorie.Text);

            command.CommandText = "INSERT INTO categories (name) VALUES (@name)";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insertion effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de l’insertion!");
            }

            conn.Close();

            dataGridView_Categorie.DataSource = display_Categorie_Table();
            conn.Close();
        }

        private void Edit_Categorie_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@name", textBox_Name_categorie.Text);
            command.Parameters.AddWithValue("@id", textBox_ID_categorie.Text);

            command.CommandText = "UPDATE categories SET name = @name WHERE id = @id ";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Insertion effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification!");
            }

            conn.Close();

            dataGridView_Categorie.DataSource = display_Categorie_Table();
            conn.Close();
        }

        private void Del_Categorie_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", textBox_ID_categorie.Text);

            command.CommandText = "DELETE FROM categories WHERE id = @id";
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM categoriser WHERE id_categories = @id";
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

            dataGridView_Categorie.DataSource = display_Categorie_Table();
            conn.Close();
        }

        //////////////////////// JEUX ///////////////////////////////

        public DataTable display_Jeu_Table()
        {
            conn.Close();
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_jeu = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();

            cmd.CommandText = "SELECT p.id, t.nom AS type, m.nom AS marque, p.nom, p.description, p.prix, p.quantite, p.image FROM produits p " +
                "INNER JOIN type t ON t.id = p.id_type " +
                "INNER JOIN marque m ON m.id = p.id_marque";
            mydtadp_jeu.SelectCommand = cmd;

            mydtadp_jeu.Fill(table_jeu);

            return table_jeu;
        }

        public void Open_Tab_Jeux()
        {
            dataGridView_Jeux.DataSource = display_Jeu_Table();

            MySqlDataAdapter mydtadp = new MySqlDataAdapter();
            DataTable table_jeu = new DataTable();
            mydtadp.SelectCommand = new MySqlCommand("SELECT * FROM categorie", conn);
            mydtadp.Fill(table_jeu);
            listBoxAllCategories.DataSource = table_jeu;
            listBoxAllCategories.DisplayMember = "nom";


            dataGridView_Jeux.DataSource = display_Jeu_Table();

            MySqlDataAdapter mydtadp2 = new MySqlDataAdapter();
            DataTable table_marque = new DataTable();
            mydtadp2.SelectCommand = new MySqlCommand("SELECT * FROM marque", conn);
            mydtadp2.Fill(table_marque);
            checkedListBoxMarque.DataSource = table_marque;
            checkedListBoxMarque.DisplayMember = "nom";


            dataGridView_Jeux.DataSource = display_Jeu_Table();

            MySqlDataAdapter mydtadp3 = new MySqlDataAdapter();
            DataTable table_type = new DataTable();
            mydtadp3.SelectCommand = new MySqlCommand("SELECT * FROM type", conn);
            mydtadp3.Fill(table_type);
            checkedListBoxType.DataSource = table_type;
            checkedListBoxType.DisplayMember = "nom";



            conn.Close();

            Add_Jeu.Enabled = false;
            Edit_Jeu.Enabled = false;
            Del_Jeu.Enabled = false;
            Comment_Jeu.Enabled = false;
        }

        private void dataGridView_Jeux_MouseUp(object sendere, MouseEventArgs ee)
        { 
            for (int i = 0; i < listBoxAllCategories.Items.Count; i++)
                listBoxAllCategories.SetItemCheckState(i, CheckState.Unchecked);

            for (int i = 0; i < checkedListBoxMarque.Items.Count; i++)
                checkedListBoxMarque.SetItemCheckState(i, CheckState.Unchecked);

            for (int i = 0; i < checkedListBoxType.Items.Count; i++)
                checkedListBoxType.SetItemCheckState(i, CheckState.Unchecked);


            int row = dataGridView_Jeux.CurrentCell.RowIndex;
            int id_produits = 0;

            for (int i = 0; i < 8; i++)
            {
                string val = dataGridView_Jeux.Rows[row].Cells[i].Value.ToString();
                switch (i)
                {
                    case 0:
                        textBoxID.Text = val;
                        try
                        {
                            id_produits = Convert.ToInt32(val);
                        }
                        catch { }
                        break;

                    case 3:
                        textBoxNom.Text = val;
                        break;
                    case 4:
                        textBoxDescription.Text = val;
                        break;
                    case 5:
                        textBoxPrix.Text = val;
                        break;
                    case 6:
                        textBoxQuantite.Text = val;
                        break;
                    case 7:
                        textBoxImage.Text = val;
                        break;
                }

            }


            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id_produits", id_produits);

            command.CommandText = "" +
                "SELECT c.id " +
                "FROM Categorie c " +
                "INNER JOIN categoriser cr ON c.id = cr.id_cat " +
                "INNER JOIN produits p ON p.id = @id_produits AND p.id = cr.id_produit";

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int valeur = reader.GetInt32(0);
                listBoxAllCategories.SetItemChecked(valeur - 1, true);
            }
            conn.Close();
        




        conn.Open();
            MySqlCommand command2 = conn.CreateCommand();
            command2.Parameters.AddWithValue("@id_produits", id_produits);

            command2.CommandText = "" +
                "SELECT m.id " +
                "FROM Marque m " +
                "INNER JOIN produits p ON p.id = @id_produits AND m.id = p.id_marque";

            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                int valeur = reader2.GetInt32(0);
                checkedListBoxMarque.SetItemChecked(valeur - 1, true);
            }
            conn.Close();


            conn.Open();
            MySqlCommand command3 = conn.CreateCommand();
            command3.Parameters.AddWithValue("@id_produits", id_produits);

            command3.CommandText = "" +
                "SELECT t.id " +
                "FROM Type t " +
                "INNER JOIN produits p ON p.id = @id_produits AND t.id = p.id_type";

            MySqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                int valeur = reader3.GetInt32(0);
                checkedListBoxType.SetItemChecked(valeur - 1, true);
            }
            conn.Close();
        }

        private void Add_Jeu_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@nom", textBoxNom.Text);
            command.Parameters.AddWithValue("@description", textBoxDescription.Text);
            command.Parameters.AddWithValue("@prix", textBoxPrix.Text);
            command.Parameters.AddWithValue("@quantite", textBoxQuantite.Text);
            command.Parameters.AddWithValue("@image", textBoxImage.Text);

            command.CommandText = "INSERT INTO produits (id_type, id_marque, nom, description, prix, quantite, image) VALUES (1, 1, @nom, @description, @prix, @quantite, @image) ";

            if (command.ExecuteNonQuery() > 0)
            {
                conn.Close();
                conn.Open();

                foreach (object itemChecked in listBoxAllCategories.CheckedItems)
                {
                    MySqlCommand command3 = conn.CreateCommand();
                    DataRowView castedItem = itemChecked as DataRowView;
                    command3.Parameters.AddWithValue("@name_cat", castedItem["nom"].ToString());
                    command3.CommandText = "INSERT INTO categoriser (id_produit, id_cat) " +
                        "VALUES ((SELECT MAX(id) FROM produits), (SELECT id FROM categorie WHERE categorie.nom = @name_cat)) ";
                    command3.ExecuteNonQuery();

                }
                MessageBox.Show("Insertion effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de l’insertion!");
            }

            conn.Close();

            dataGridView_Jeux.DataSource = display_Jeu_Table();
            conn.Close();
        }

        private void Edit_Jeu_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@name", textBoxNom.Text);
            command.Parameters.AddWithValue("@description", textBoxDescription.Text);
           
            command.Parameters.AddWithValue("@images", textBoxImage.Text);
            command.Parameters.AddWithValue("@id", textBoxID.Text);

            command.CommandText = "DELETE FROM categoriser WHERE id_jeux = @id";
            command.ExecuteNonQuery();
            command.CommandText = "UPDATE jeux SET name = @name , description = @description , site = @site , images = @images WHERE id = @id";
            

            if (command.ExecuteNonQuery() > 0)
            {
                conn.Close();
                conn.Open();

                foreach (object itemChecked in listBoxAllCategories.CheckedItems)
                {
                    MySqlCommand command3 = conn.CreateCommand();
                    DataRowView castedItem = itemChecked as DataRowView;
                    command3.Parameters.AddWithValue("@name_cat", castedItem["name"].ToString());
                    command3.CommandText = "INSERT INTO categoriser (id_jeux, id_categories) " +
                        "VALUES ((SELECT MAX(id) FROM jeux), (SELECT id FROM categories WHERE categories.name = @name_cat)) ";
                    command3.ExecuteNonQuery();

                }
                MessageBox.Show("Modification effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification!");
            }

            conn.Close();

            dataGridView_Jeux.DataSource = display_Jeu_Table();
            conn.Close();
        }

        private void Del_Jeu_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", textBoxID.Text);

            command.CommandText = "DELETE FROM jeux WHERE id = @id";
            command.ExecuteNonQuery();
            command.CommandText = "DELETE FROM categoriser WHERE id_jeux = @id";
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

            dataGridView_Jeux.DataSource = display_Jeu_Table();
            conn.Close();
        }

        /////////////////////// USER /////////////////////////////

        public DataTable display_User_Table() // Fonction pour charger la table SQL "user" 
        {
            conn.Close();
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataAdapter mydtadp_user = new MySqlDataAdapter(); // créé un objet pour remplir    
            DataTable table_user = new DataTable(); // créé un objet de table de données

            cmd.CommandText = "SELECT * FROM user";

            mydtadp_user.SelectCommand = cmd;
            mydtadp_user.Fill(table_user); // rempli cette table par les données récupéré par la commande SQL

            return table_user; // retourne le tableau
        }

        public void Open_Tab_User() // Fonction lorsque l'on rentre dans un onglet
        {

            dataGridView_Users.DataSource = display_User_Table(); // lancement de la fonction pour charger la table SQL "user" dans le tableau indiqué

            conn.Close();

            Reset_User.Enabled = false; // désactive tout les bouttons lorsque l'on arrive sur l'onglet
            Edit_User.Enabled = false;
        }

        private void dataGridView_Users_MouseUp(object sender, MouseEventArgs e)
        {
            int row = dataGridView_Users.CurrentCell.RowIndex; // attribue a une variable la valeur de la ligne sur laquelle on a cliqué 
            
            for (int i = 0; i < 11; i++) // boucle pour chaque cellule de la ligne
            {
                string val = dataGridView_Users.Rows[row].Cells[i].Value.ToString(); // sauvegarde la valeur de la cellule pointé
                switch (i)
                {
                    case 0:
                        textBox_ID_user.Text = val;
                    break;
                    case 1:
                        textBox_Username_user.Text = val;
                    break;
                    case 2:
                        textBox_Email_user.Text = val;
                    break;

                    case 4:
                        textBox_Nom_user.Text = val;
                    break;
                    case 5:
                        textBox_Prenom_user.Text = val;
                    break;
                    case 6:
                        textBox_Anniv_user.Text = val;
                    break;
                    case 7:
                        textBox_Numero_user.Text = val;
                    break;
                    case 8:
                        textBox_Adresse_user.Text = val;
                    break;
                    case 9:
                        textBox_Pays_user.Text = val;
                    break;
                    case 10:
                        comboBox_Role_user.SelectedIndex = comboBox_Role_user.FindStringExact(val);
                    break;
                }

            }

            conn.Close();
        }

        private void Reset_User_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", textBox_ID_user.Text);

            command.CommandText = "UPDATE user SET password = '' WHERE id = @id ";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Mot de passe réinitialisé!");
            }
            else
            {
                MessageBox.Show("Erreur lors de l’insertion!");
            }

            conn.Close();

            dataGridView_Users.DataSource = display_User_Table();
            conn.Close();
        }

        private void Edit_User_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand command = conn.CreateCommand();
            command.Parameters.AddWithValue("@id", textBox_ID_user.Text);
            command.Parameters.AddWithValue("@username", textBox_Username_user.Text);
            command.Parameters.AddWithValue("@email", textBox_Email_user.Text);
            command.Parameters.AddWithValue("@nom", textBox_Nom_user.Text);
            command.Parameters.AddWithValue("@prenom", textBox_Prenom_user.Text);
            command.Parameters.AddWithValue("@anniv", textBox_Anniv_user.Text);
            command.Parameters.AddWithValue("@num", textBox_Numero_user.Text);
            command.Parameters.AddWithValue("@adresse", textBox_Adresse_user.Text);
            command.Parameters.AddWithValue("@pays", textBox_Pays_user.Text);
            command.Parameters.AddWithValue("@role", comboBox_Role_user.Text);

            command.CommandText = "UPDATE user SET username = @username , email = @email , nom = @nom , prenom = @prenom, birthday = @anniv, num_tel = @num, adresse = @adresse, pays = @pays, status = @role WHERE id = @id";

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Modification effectuée!");
            }
            else
            {
                MessageBox.Show("Erreur lors de la modification!");
            }

            conn.Close();

            dataGridView_Users.DataSource = display_User_Table();
            conn.Close();
        }

        //////////////////////////// COMMENTAIRES ////////////////////////////////////

        private void Commentaires_Admin(object sender, EventArgs e)
        {
            Form2 Jeu_Comments = new Form2(Convert.ToInt32(textBoxID.Text), tabControl1.SelectedIndex);
            Jeu_Comments.Show();
        }
    }
}





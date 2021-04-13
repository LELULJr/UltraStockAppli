
namespace PPE
{
    partial class Administration
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Utilisateur_Tab = new System.Windows.Forms.TabPage();
            this.comboBox_Role_user = new System.Windows.Forms.ComboBox();
            this.label_role_user = new System.Windows.Forms.Label();
            this.textBox_Nom_user = new System.Windows.Forms.TextBox();
            this.textBox_Prenom_user = new System.Windows.Forms.TextBox();
            this.textBox_Email_user = new System.Windows.Forms.TextBox();
            this.textBox_ID_user = new System.Windows.Forms.TextBox();
            this.Edit_User = new System.Windows.Forms.Button();
            this.Reset_User = new System.Windows.Forms.Button();
            this.label_nom_user = new System.Windows.Forms.Label();
            this.label_prenom_user = new System.Windows.Forms.Label();
            this.label_email_user = new System.Windows.Forms.Label();
            this.label_id_user = new System.Windows.Forms.Label();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.Produits = new System.Windows.Forms.TabPage();
            this.checkedListBoxType = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxMarque = new System.Windows.Forms.CheckedListBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxQuantite = new System.Windows.Forms.TextBox();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.listBoxAllCategories = new System.Windows.Forms.CheckedListBox();
            this.labelCategories = new System.Windows.Forms.Label();
            this.labelImage = new System.Windows.Forms.Label();
            this.labelMarque = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.DelProduit = new System.Windows.Forms.Button();
            this.EditProduit = new System.Windows.Forms.Button();
            this.AddProduit = new System.Windows.Forms.Button();
            this.dataGridView_Produits = new System.Windows.Forms.DataGridView();
            this.Categorie_Tab = new System.Windows.Forms.TabPage();
            this.label_id_categorie = new System.Windows.Forms.Label();
            this.dataGridView_Produits2 = new System.Windows.Forms.DataGridView();
            this.label_Produits_de_la_cat = new System.Windows.Forms.Label();
            this.label_nom_categorie = new System.Windows.Forms.Label();
            this.textBox_Name_categorie = new System.Windows.Forms.TextBox();
            this.textBox_ID_categorie = new System.Windows.Forms.TextBox();
            this.Del_Categorie = new System.Windows.Forms.Button();
            this.Edit_Categorie = new System.Windows.Forms.Button();
            this.Add_Categorie = new System.Windows.Forms.Button();
            this.dataGridView_Categorie = new System.Windows.Forms.DataGridView();
            this.Menu = new System.Windows.Forms.TabPage();
            this.Categorie_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Produits_Btn = new System.Windows.Forms.Button();
            this.Utilisateur_Btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Utilisateur_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            this.Produits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).BeginInit();
            this.Categorie_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categorie)).BeginInit();
            this.Menu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Utilisateur_Tab
            // 
            this.Utilisateur_Tab.Controls.Add(this.comboBox_Role_user);
            this.Utilisateur_Tab.Controls.Add(this.label_role_user);
            this.Utilisateur_Tab.Controls.Add(this.textBox_Nom_user);
            this.Utilisateur_Tab.Controls.Add(this.textBox_Prenom_user);
            this.Utilisateur_Tab.Controls.Add(this.textBox_Email_user);
            this.Utilisateur_Tab.Controls.Add(this.textBox_ID_user);
            this.Utilisateur_Tab.Controls.Add(this.Edit_User);
            this.Utilisateur_Tab.Controls.Add(this.Reset_User);
            this.Utilisateur_Tab.Controls.Add(this.label_nom_user);
            this.Utilisateur_Tab.Controls.Add(this.label_prenom_user);
            this.Utilisateur_Tab.Controls.Add(this.label_email_user);
            this.Utilisateur_Tab.Controls.Add(this.label_id_user);
            this.Utilisateur_Tab.Controls.Add(this.dataGridView_Users);
            this.Utilisateur_Tab.Location = new System.Drawing.Point(4, 22);
            this.Utilisateur_Tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Utilisateur_Tab.Name = "Utilisateur_Tab";
            this.Utilisateur_Tab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Utilisateur_Tab.Size = new System.Drawing.Size(595, 666);
            this.Utilisateur_Tab.TabIndex = 6;
            this.Utilisateur_Tab.Text = "Users";
            this.Utilisateur_Tab.UseVisualStyleBackColor = true;
            // 
            // comboBox_Role_user
            // 
            this.comboBox_Role_user.FormattingEnabled = true;
            this.comboBox_Role_user.Items.AddRange(new object[] {
            "utilisateur",
            "moderateur",
            "administrateur"});
            this.comboBox_Role_user.Location = new System.Drawing.Point(249, 483);
            this.comboBox_Role_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Role_user.Name = "comboBox_Role_user";
            this.comboBox_Role_user.Size = new System.Drawing.Size(120, 21);
            this.comboBox_Role_user.TabIndex = 36;
            this.comboBox_Role_user.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // label_role_user
            // 
            this.label_role_user.AllowDrop = true;
            this.label_role_user.AutoSize = true;
            this.label_role_user.Location = new System.Drawing.Point(209, 485);
            this.label_role_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_role_user.Name = "label_role_user";
            this.label_role_user.Size = new System.Drawing.Size(39, 13);
            this.label_role_user.TabIndex = 35;
            this.label_role_user.Text = "Rôle* :";
            this.label_role_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Nom_user
            // 
            this.textBox_Nom_user.Location = new System.Drawing.Point(464, 515);
            this.textBox_Nom_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Nom_user.Name = "textBox_Nom_user";
            this.textBox_Nom_user.Size = new System.Drawing.Size(120, 20);
            this.textBox_Nom_user.TabIndex = 19;
            // 
            // textBox_Prenom_user
            // 
            this.textBox_Prenom_user.Location = new System.Drawing.Point(464, 485);
            this.textBox_Prenom_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Prenom_user.Name = "textBox_Prenom_user";
            this.textBox_Prenom_user.Size = new System.Drawing.Size(120, 20);
            this.textBox_Prenom_user.TabIndex = 17;
            // 
            // textBox_Email_user
            // 
            this.textBox_Email_user.Location = new System.Drawing.Point(60, 515);
            this.textBox_Email_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Email_user.Name = "textBox_Email_user";
            this.textBox_Email_user.Size = new System.Drawing.Size(151, 20);
            this.textBox_Email_user.TabIndex = 15;
            this.textBox_Email_user.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBox_ID_user
            // 
            this.textBox_ID_user.Location = new System.Drawing.Point(40, 483);
            this.textBox_ID_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ID_user.Name = "textBox_ID_user";
            this.textBox_ID_user.Size = new System.Drawing.Size(76, 20);
            this.textBox_ID_user.TabIndex = 11;
            this.textBox_ID_user.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // Edit_User
            // 
            this.Edit_User.Location = new System.Drawing.Point(361, 629);
            this.Edit_User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit_User.Name = "Edit_User";
            this.Edit_User.Size = new System.Drawing.Size(75, 24);
            this.Edit_User.TabIndex = 27;
            this.Edit_User.Text = "Modifier";
            this.Edit_User.UseVisualStyleBackColor = true;
            this.Edit_User.Click += new System.EventHandler(this.Edit_User_Click);
            // 
            // Reset_User
            // 
            this.Reset_User.Location = new System.Drawing.Point(146, 629);
            this.Reset_User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reset_User.Name = "Reset_User";
            this.Reset_User.Size = new System.Drawing.Size(101, 24);
            this.Reset_User.TabIndex = 26;
            this.Reset_User.Text = "Réinitialiser MdP";
            this.Reset_User.UseVisualStyleBackColor = true;
            this.Reset_User.Click += new System.EventHandler(this.Reset_User_Click);
            // 
            // label_nom_user
            // 
            this.label_nom_user.AllowDrop = true;
            this.label_nom_user.AutoSize = true;
            this.label_nom_user.Location = new System.Drawing.Point(422, 518);
            this.label_nom_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nom_user.Name = "label_nom_user";
            this.label_nom_user.Size = new System.Drawing.Size(35, 13);
            this.label_nom_user.TabIndex = 20;
            this.label_nom_user.Text = "Nom :";
            this.label_nom_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_prenom_user
            // 
            this.label_prenom_user.AutoSize = true;
            this.label_prenom_user.Location = new System.Drawing.Point(411, 488);
            this.label_prenom_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_prenom_user.Name = "label_prenom_user";
            this.label_prenom_user.Size = new System.Drawing.Size(49, 13);
            this.label_prenom_user.TabIndex = 18;
            this.label_prenom_user.Text = "Prénom :";
            this.label_prenom_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_email_user
            // 
            this.label_email_user.AutoSize = true;
            this.label_email_user.Location = new System.Drawing.Point(14, 518);
            this.label_email_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_email_user.Name = "label_email_user";
            this.label_email_user.Size = new System.Drawing.Size(42, 13);
            this.label_email_user.TabIndex = 16;
            this.label_email_user.Text = "Email* :";
            this.label_email_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_id_user
            // 
            this.label_id_user.AutoSize = true;
            this.label_id_user.Location = new System.Drawing.Point(14, 485);
            this.label_id_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id_user.Name = "label_id_user";
            this.label_id_user.Size = new System.Drawing.Size(24, 13);
            this.label_id_user.TabIndex = 13;
            this.label_id_user.Text = "ID :";
            this.label_id_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Location = new System.Drawing.Point(11, 12);
            this.dataGridView_Users.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.RowHeadersWidth = 51;
            this.dataGridView_Users.RowTemplate.Height = 24;
            this.dataGridView_Users.Size = new System.Drawing.Size(572, 454);
            this.dataGridView_Users.TabIndex = 1;
            this.dataGridView_Users.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Users_MouseUp);
            // 
            // Produits
            // 
            this.Produits.Controls.Add(this.checkedListBoxType);
            this.Produits.Controls.Add(this.checkedListBoxMarque);
            this.Produits.Controls.Add(this.labelPrix);
            this.Produits.Controls.Add(this.textBoxPrix);
            this.Produits.Controls.Add(this.textBoxQuantite);
            this.Produits.Controls.Add(this.textBoxImage);
            this.Produits.Controls.Add(this.textBoxDescription);
            this.Produits.Controls.Add(this.textBoxNom);
            this.Produits.Controls.Add(this.textBoxID);
            this.Produits.Controls.Add(this.labelType);
            this.Produits.Controls.Add(this.labelQuantite);
            this.Produits.Controls.Add(this.listBoxAllCategories);
            this.Produits.Controls.Add(this.labelCategories);
            this.Produits.Controls.Add(this.labelImage);
            this.Produits.Controls.Add(this.labelMarque);
            this.Produits.Controls.Add(this.labelDescription);
            this.Produits.Controls.Add(this.labelNom);
            this.Produits.Controls.Add(this.labelID);
            this.Produits.Controls.Add(this.DelProduit);
            this.Produits.Controls.Add(this.EditProduit);
            this.Produits.Controls.Add(this.AddProduit);
            this.Produits.Controls.Add(this.dataGridView_Produits);
            this.Produits.Location = new System.Drawing.Point(4, 22);
            this.Produits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Produits.Name = "Produits";
            this.Produits.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Produits.Size = new System.Drawing.Size(595, 666);
            this.Produits.TabIndex = 2;
            this.Produits.Text = "Produit";
            this.Produits.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxType
            // 
            this.checkedListBoxType.CheckOnClick = true;
            this.checkedListBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkedListBoxType.FormattingEnabled = true;
            this.checkedListBoxType.Location = new System.Drawing.Point(316, 453);
            this.checkedListBoxType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBoxType.Name = "checkedListBoxType";
            this.checkedListBoxType.Size = new System.Drawing.Size(149, 148);
            this.checkedListBoxType.TabIndex = 30;
            // 
            // checkedListBoxMarque
            // 
            this.checkedListBoxMarque.CheckOnClick = true;
            this.checkedListBoxMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkedListBoxMarque.FormattingEnabled = true;
            this.checkedListBoxMarque.Location = new System.Drawing.Point(164, 453);
            this.checkedListBoxMarque.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBoxMarque.Name = "checkedListBoxMarque";
            this.checkedListBoxMarque.Size = new System.Drawing.Size(149, 148);
            this.checkedListBoxMarque.TabIndex = 29;
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(386, 344);
            this.labelPrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(34, 13);
            this.labelPrix.TabIndex = 28;
            this.labelPrix.Text = "Prix* :";
            this.labelPrix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(428, 341);
            this.textBoxPrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(151, 20);
            this.textBoxPrix.TabIndex = 27;
            // 
            // textBoxQuantite
            // 
            this.textBoxQuantite.Location = new System.Drawing.Point(428, 307);
            this.textBoxQuantite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxQuantite.Name = "textBoxQuantite";
            this.textBoxQuantite.Size = new System.Drawing.Size(151, 20);
            this.textBoxQuantite.TabIndex = 23;
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(428, 384);
            this.textBoxImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(151, 20);
            this.textBoxImage.TabIndex = 8;
            this.textBoxImage.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(79, 341);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(292, 63);
            this.textBoxDescription.TabIndex = 6;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(168, 310);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(151, 20);
            this.textBoxNom.TabIndex = 5;
            this.textBoxNom.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(36, 307);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(76, 20);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(368, 436);
            this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(41, 13);
            this.labelType.TabIndex = 26;
            this.labelType.Text = "Type* :";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Location = new System.Drawing.Point(368, 310);
            this.labelQuantite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(57, 13);
            this.labelQuantite.TabIndex = 24;
            this.labelQuantite.Text = "Quantite* :";
            this.labelQuantite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBoxAllCategories
            // 
            this.listBoxAllCategories.CheckOnClick = true;
            this.listBoxAllCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listBoxAllCategories.FormattingEnabled = true;
            this.listBoxAllCategories.Location = new System.Drawing.Point(12, 453);
            this.listBoxAllCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxAllCategories.Name = "listBoxAllCategories";
            this.listBoxAllCategories.Size = new System.Drawing.Size(149, 148);
            this.listBoxAllCategories.TabIndex = 21;
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.Location = new System.Drawing.Point(34, 436);
            this.labelCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(101, 13);
            this.labelCategories.TabIndex = 20;
            this.labelCategories.Text = "Liste des catégories";
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(380, 388);
            this.labelImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(46, 13);
            this.labelImage.TabIndex = 13;
            this.labelImage.Text = "Image* :";
            this.labelImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMarque
            // 
            this.labelMarque.AutoSize = true;
            this.labelMarque.Location = new System.Drawing.Point(211, 436);
            this.labelMarque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarque.Name = "labelMarque";
            this.labelMarque.Size = new System.Drawing.Size(53, 13);
            this.labelMarque.TabIndex = 12;
            this.labelMarque.Text = "Marque* :";
            this.labelMarque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(9, 344);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(70, 13);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Description* :";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(126, 312);
            this.labelNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(39, 13);
            this.labelNom.TabIndex = 10;
            this.labelNom.Text = "Nom* :";
            this.labelNom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(10, 310);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(24, 13);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID :";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DelProduit
            // 
            this.DelProduit.Location = new System.Drawing.Point(508, 629);
            this.DelProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelProduit.Name = "DelProduit";
            this.DelProduit.Size = new System.Drawing.Size(75, 24);
            this.DelProduit.TabIndex = 3;
            this.DelProduit.Text = "Supprimer";
            this.DelProduit.UseVisualStyleBackColor = true;
            this.DelProduit.Click += new System.EventHandler(this.DelProduit_Click);
            // 
            // EditProduit
            // 
            this.EditProduit.Location = new System.Drawing.Point(246, 629);
            this.EditProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditProduit.Name = "EditProduit";
            this.EditProduit.Size = new System.Drawing.Size(75, 24);
            this.EditProduit.TabIndex = 2;
            this.EditProduit.Text = "Modifier";
            this.EditProduit.UseVisualStyleBackColor = true;
            this.EditProduit.Click += new System.EventHandler(this.EditProduit_Click);
            // 
            // AddProduit
            // 
            this.AddProduit.Location = new System.Drawing.Point(11, 629);
            this.AddProduit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddProduit.Name = "AddProduit";
            this.AddProduit.Size = new System.Drawing.Size(75, 24);
            this.AddProduit.TabIndex = 1;
            this.AddProduit.Text = "Ajouter";
            this.AddProduit.UseVisualStyleBackColor = true;
            this.AddProduit.Click += new System.EventHandler(this.AddProduit_Click);
            // 
            // dataGridView_Produits
            // 
            this.dataGridView_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produits.Location = new System.Drawing.Point(11, 12);
            this.dataGridView_Produits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Produits.Name = "dataGridView_Produits";
            this.dataGridView_Produits.RowHeadersWidth = 51;
            this.dataGridView_Produits.RowTemplate.Height = 24;
            this.dataGridView_Produits.Size = new System.Drawing.Size(572, 275);
            this.dataGridView_Produits.TabIndex = 0;
            this.dataGridView_Produits.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Produits_MouseUp);
            // 
            // Categorie_Tab
            // 
            this.Categorie_Tab.Controls.Add(this.label_id_categorie);
            this.Categorie_Tab.Controls.Add(this.dataGridView_Produits2);
            this.Categorie_Tab.Controls.Add(this.label_Produits_de_la_cat);
            this.Categorie_Tab.Controls.Add(this.label_nom_categorie);
            this.Categorie_Tab.Controls.Add(this.textBox_Name_categorie);
            this.Categorie_Tab.Controls.Add(this.textBox_ID_categorie);
            this.Categorie_Tab.Controls.Add(this.Del_Categorie);
            this.Categorie_Tab.Controls.Add(this.Edit_Categorie);
            this.Categorie_Tab.Controls.Add(this.Add_Categorie);
            this.Categorie_Tab.Controls.Add(this.dataGridView_Categorie);
            this.Categorie_Tab.Location = new System.Drawing.Point(4, 22);
            this.Categorie_Tab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Categorie_Tab.Name = "Categorie_Tab";
            this.Categorie_Tab.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Categorie_Tab.Size = new System.Drawing.Size(595, 666);
            this.Categorie_Tab.TabIndex = 1;
            this.Categorie_Tab.Text = "Categorie";
            this.Categorie_Tab.UseVisualStyleBackColor = true;
            // 
            // label_id_categorie
            // 
            this.label_id_categorie.AutoSize = true;
            this.label_id_categorie.Location = new System.Drawing.Point(12, 314);
            this.label_id_categorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_id_categorie.Name = "label_id_categorie";
            this.label_id_categorie.Size = new System.Drawing.Size(24, 13);
            this.label_id_categorie.TabIndex = 37;
            this.label_id_categorie.Text = "ID :";
            this.label_id_categorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView_Produits2
            // 
            this.dataGridView_Produits2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produits2.Location = new System.Drawing.Point(14, 406);
            this.dataGridView_Produits2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Produits2.Name = "dataGridView_Produits2";
            this.dataGridView_Produits2.RowHeadersWidth = 51;
            this.dataGridView_Produits2.RowTemplate.Height = 24;
            this.dataGridView_Produits2.Size = new System.Drawing.Size(572, 204);
            this.dataGridView_Produits2.TabIndex = 36;
            // 
            // label_Produits_de_la_cat
            // 
            this.label_Produits_de_la_cat.AutoSize = true;
            this.label_Produits_de_la_cat.Location = new System.Drawing.Point(247, 375);
            this.label_Produits_de_la_cat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Produits_de_la_cat.Name = "label_Produits_de_la_cat";
            this.label_Produits_de_la_cat.Size = new System.Drawing.Size(118, 13);
            this.label_Produits_de_la_cat.TabIndex = 35;
            this.label_Produits_de_la_cat.Text = "Produits de la catégorie";
            // 
            // label_nom_categorie
            // 
            this.label_nom_categorie.AutoSize = true;
            this.label_nom_categorie.Location = new System.Drawing.Point(181, 314);
            this.label_nom_categorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nom_categorie.Name = "label_nom_categorie";
            this.label_nom_categorie.Size = new System.Drawing.Size(39, 13);
            this.label_nom_categorie.TabIndex = 31;
            this.label_nom_categorie.Text = "Nom* :";
            this.label_nom_categorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_Name_categorie
            // 
            this.textBox_Name_categorie.Location = new System.Drawing.Point(223, 312);
            this.textBox_Name_categorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Name_categorie.Name = "textBox_Name_categorie";
            this.textBox_Name_categorie.Size = new System.Drawing.Size(151, 20);
            this.textBox_Name_categorie.TabIndex = 27;
            this.textBox_Name_categorie.TextChanged += new System.EventHandler(this.display_Produits_from_Categorie);
            // 
            // textBox_ID_categorie
            // 
            this.textBox_ID_categorie.Location = new System.Drawing.Point(39, 312);
            this.textBox_ID_categorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ID_categorie.Name = "textBox_ID_categorie";
            this.textBox_ID_categorie.Size = new System.Drawing.Size(76, 20);
            this.textBox_ID_categorie.TabIndex = 26;
            this.textBox_ID_categorie.TextChanged += new System.EventHandler(this.enable_Button);
            // 
            // Del_Categorie
            // 
            this.Del_Categorie.Location = new System.Drawing.Point(511, 634);
            this.Del_Categorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Del_Categorie.Name = "Del_Categorie";
            this.Del_Categorie.Size = new System.Drawing.Size(75, 24);
            this.Del_Categorie.TabIndex = 25;
            this.Del_Categorie.Text = "Supprimer";
            this.Del_Categorie.UseVisualStyleBackColor = true;
            this.Del_Categorie.Click += new System.EventHandler(this.Del_Categorie_Click);
            // 
            // Edit_Categorie
            // 
            this.Edit_Categorie.Location = new System.Drawing.Point(249, 634);
            this.Edit_Categorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Edit_Categorie.Name = "Edit_Categorie";
            this.Edit_Categorie.Size = new System.Drawing.Size(75, 24);
            this.Edit_Categorie.TabIndex = 24;
            this.Edit_Categorie.Text = "Modifier";
            this.Edit_Categorie.UseVisualStyleBackColor = true;
            this.Edit_Categorie.Click += new System.EventHandler(this.Edit_Categorie_Click);
            // 
            // Add_Categorie
            // 
            this.Add_Categorie.Location = new System.Drawing.Point(14, 634);
            this.Add_Categorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add_Categorie.Name = "Add_Categorie";
            this.Add_Categorie.Size = new System.Drawing.Size(75, 24);
            this.Add_Categorie.TabIndex = 23;
            this.Add_Categorie.Text = "Ajouter";
            this.Add_Categorie.UseVisualStyleBackColor = true;
            this.Add_Categorie.Click += new System.EventHandler(this.Add_Categorie_Click);
            // 
            // dataGridView_Categorie
            // 
            this.dataGridView_Categorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Categorie.Location = new System.Drawing.Point(165, 12);
            this.dataGridView_Categorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Categorie.Name = "dataGridView_Categorie";
            this.dataGridView_Categorie.RowHeadersWidth = 51;
            this.dataGridView_Categorie.RowTemplate.Height = 24;
            this.dataGridView_Categorie.Size = new System.Drawing.Size(276, 275);
            this.dataGridView_Categorie.TabIndex = 22;
            this.dataGridView_Categorie.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Categorie_MouseUp);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Categorie_Btn);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.Produits_Btn);
            this.Menu.Controls.Add(this.Utilisateur_Btn);
            this.Menu.Location = new System.Drawing.Point(4, 22);
            this.Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Menu.Size = new System.Drawing.Size(595, 666);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            // 
            // Categorie_Btn
            // 
            this.Categorie_Btn.Location = new System.Drawing.Point(6, 343);
            this.Categorie_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Categorie_Btn.Name = "Categorie_Btn";
            this.Categorie_Btn.Size = new System.Drawing.Size(192, 106);
            this.Categorie_Btn.TabIndex = 0;
            this.Categorie_Btn.Text = "Catégorie";
            this.Categorie_Btn.UseVisualStyleBackColor = true;
            this.Categorie_Btn.Click += new System.EventHandler(this.Categorie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(135, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Outil d\'administration de Ultra stock";
            // 
            // Produits_Btn
            // 
            this.Produits_Btn.Location = new System.Drawing.Point(202, 343);
            this.Produits_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Produits_Btn.Name = "Produits_Btn";
            this.Produits_Btn.Size = new System.Drawing.Size(192, 106);
            this.Produits_Btn.TabIndex = 2;
            this.Produits_Btn.Text = "Produits";
            this.Produits_Btn.UseVisualStyleBackColor = true;
            this.Produits_Btn.Click += new System.EventHandler(this.Produits_Click);
            // 
            // Utilisateur_Btn
            // 
            this.Utilisateur_Btn.Location = new System.Drawing.Point(399, 343);
            this.Utilisateur_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Utilisateur_Btn.Name = "Utilisateur_Btn";
            this.Utilisateur_Btn.Size = new System.Drawing.Size(192, 106);
            this.Utilisateur_Btn.TabIndex = 5;
            this.Utilisateur_Btn.Text = "Gerer les utilisateurs";
            this.Utilisateur_Btn.UseVisualStyleBackColor = true;
            this.Utilisateur_Btn.Click += new System.EventHandler(this.User_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Menu);
            this.tabControl1.Controls.Add(this.Categorie_Tab);
            this.tabControl1.Controls.Add(this.Produits);
            this.tabControl1.Controls.Add(this.Utilisateur_Tab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 692);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 683);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Utilisateur_Tab.ResumeLayout(false);
            this.Utilisateur_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            this.Produits.ResumeLayout(false);
            this.Produits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).EndInit();
            this.Categorie_Tab.ResumeLayout(false);
            this.Categorie_Tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Categorie)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Utilisateur_Tab;
        private System.Windows.Forms.ComboBox comboBox_Role_user;
        private System.Windows.Forms.Label label_role_user;
        private System.Windows.Forms.TextBox textBox_Nom_user;
        private System.Windows.Forms.TextBox textBox_Prenom_user;
        private System.Windows.Forms.TextBox textBox_Email_user;
        private System.Windows.Forms.TextBox textBox_ID_user;
        private System.Windows.Forms.Button Edit_User;
        private System.Windows.Forms.Button Reset_User;
        private System.Windows.Forms.Label label_nom_user;
        private System.Windows.Forms.Label label_prenom_user;
        private System.Windows.Forms.Label label_email_user;
        private System.Windows.Forms.Label label_id_user;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.TabPage Produits;
        private System.Windows.Forms.CheckedListBox checkedListBoxType;
        private System.Windows.Forms.CheckedListBox checkedListBoxMarque;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.TextBox textBoxQuantite;
        private System.Windows.Forms.TextBox textBoxImage;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.CheckedListBox listBoxAllCategories;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.Label labelMarque;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button DelProduit;
        private System.Windows.Forms.Button EditProduit;
        private System.Windows.Forms.Button AddProduit;
        private System.Windows.Forms.DataGridView dataGridView_Produits;
        private System.Windows.Forms.TabPage Categorie_Tab;
        private System.Windows.Forms.Label label_id_categorie;
        private System.Windows.Forms.DataGridView dataGridView_Produits2;
        private System.Windows.Forms.Label label_Produits_de_la_cat;
        private System.Windows.Forms.Label label_nom_categorie;
        private System.Windows.Forms.TextBox textBox_Name_categorie;
        private System.Windows.Forms.TextBox textBox_ID_categorie;
        private System.Windows.Forms.Button Del_Categorie;
        private System.Windows.Forms.Button Edit_Categorie;
        private System.Windows.Forms.Button Add_Categorie;
        private System.Windows.Forms.DataGridView dataGridView_Categorie;
        private System.Windows.Forms.TabPage Menu;
        private System.Windows.Forms.Button Categorie_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Produits_Btn;
        private System.Windows.Forms.Button Utilisateur_Btn;
        private System.Windows.Forms.TabControl tabControl1;
    }
}


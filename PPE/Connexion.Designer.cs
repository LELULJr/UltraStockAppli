
namespace PPE
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.identifiant = new System.Windows.Forms.TextBox();
            this.MotDePasse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // identifiant
            // 
            this.identifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.identifiant.Location = new System.Drawing.Point(203, 141);
            this.identifiant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(218, 20);
            this.identifiant.TabIndex = 0;
            this.identifiant.Text = "Adresse mail";
            // 
            // MotDePasse
            // 
            this.MotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MotDePasse.Location = new System.Drawing.Point(203, 164);
            this.MotDePasse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(218, 20);
            this.MotDePasse.TabIndex = 1;
            this.MotDePasse.Text = "Mot de passe";
            this.MotDePasse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MotDePasse_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenue sur le site de suivie UltraStock ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "veuillez-vous connecter";
            // 
            // Connect
            // 
            this.Connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Connect.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(258, 187);
            this.Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(109, 21);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Se connecter";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.identifiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Connection";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox identifiant;
        private System.Windows.Forms.TextBox MotDePasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Connect;
    }
}


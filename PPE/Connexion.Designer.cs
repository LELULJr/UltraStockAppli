
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
            this.test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // identifiant
            // 
            this.identifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.identifiant.Location = new System.Drawing.Point(271, 173);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(289, 22);
            this.identifiant.TabIndex = 0;
            this.identifiant.Text = "Adresse mail";
            // 
            // MotDePasse
            // 
            this.MotDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MotDePasse.Location = new System.Drawing.Point(271, 202);
            this.MotDePasse.Name = "MotDePasse";
            this.MotDePasse.Size = new System.Drawing.Size(289, 22);
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
            this.label1.Location = new System.Drawing.Point(174, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenue sur le site de suivie UltraStock ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "veuillez-vous connecter";
            // 
            // Connect
            // 
            this.Connect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Connect.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(344, 230);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(145, 26);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Se connecter";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // test
            // 
            this.test.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.test.Location = new System.Drawing.Point(12, 131);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(170, 23);
            this.test.TabIndex = 7;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MotDePasse);
            this.Controls.Add(this.identifiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button test;
    }
}



namespace PPE
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Comments = new System.Windows.Forms.DataGridView();
            this.Del_Comment = new System.Windows.Forms.Button();
            this.dataGridView_Reponses = new System.Windows.Forms.DataGridView();
            this.textBox_Comment_Content = new System.Windows.Forms.TextBox();
            this.label_Comment_Content = new System.Windows.Forms.Label();
            this.label_Comment_list = new System.Windows.Forms.Label();
            this.label_Reponses_list = new System.Windows.Forms.Label();
            this.label_Reponse_Content = new System.Windows.Forms.Label();
            this.textBox_Reponse_Content = new System.Windows.Forms.TextBox();
            this.label_ID_User = new System.Windows.Forms.Label();
            this.Del_Reponse = new System.Windows.Forms.Button();
            this.label_ID_Comment = new System.Windows.Forms.Label();
            this.label_ID_Reponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Comments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reponses)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Comments
            // 
            this.dataGridView_Comments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Comments.Location = new System.Drawing.Point(12, 30);
            this.dataGridView_Comments.Name = "dataGridView_Comments";
            this.dataGridView_Comments.RowHeadersWidth = 51;
            this.dataGridView_Comments.RowTemplate.Height = 24;
            this.dataGridView_Comments.Size = new System.Drawing.Size(627, 365);
            this.dataGridView_Comments.TabIndex = 0;
            this.dataGridView_Comments.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Comments_MouseUp);
            // 
            // Del_Comment
            // 
            this.Del_Comment.Location = new System.Drawing.Point(740, 334);
            this.Del_Comment.Name = "Del_Comment";
            this.Del_Comment.Size = new System.Drawing.Size(188, 30);
            this.Del_Comment.TabIndex = 5;
            this.Del_Comment.Text = "Supprimer le commentaire";
            this.Del_Comment.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Reponses
            // 
            this.dataGridView_Reponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Reponses.Location = new System.Drawing.Point(12, 443);
            this.dataGridView_Reponses.Name = "dataGridView_Reponses";
            this.dataGridView_Reponses.RowHeadersWidth = 51;
            this.dataGridView_Reponses.RowTemplate.Height = 24;
            this.dataGridView_Reponses.Size = new System.Drawing.Size(627, 331);
            this.dataGridView_Reponses.TabIndex = 6;
            this.dataGridView_Reponses.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView_Reponses_MouseUp);
            // 
            // textBox_Comment_Content
            // 
            this.textBox_Comment_Content.Location = new System.Drawing.Point(655, 60);
            this.textBox_Comment_Content.Multiline = true;
            this.textBox_Comment_Content.Name = "textBox_Comment_Content";
            this.textBox_Comment_Content.ReadOnly = true;
            this.textBox_Comment_Content.Size = new System.Drawing.Size(362, 257);
            this.textBox_Comment_Content.TabIndex = 7;
            // 
            // label_Comment_Content
            // 
            this.label_Comment_Content.AutoSize = true;
            this.label_Comment_Content.Location = new System.Drawing.Point(758, 40);
            this.label_Comment_Content.Name = "label_Comment_Content";
            this.label_Comment_Content.Size = new System.Drawing.Size(170, 17);
            this.label_Comment_Content.TabIndex = 8;
            this.label_Comment_Content.Text = "Message du commentaire";
            // 
            // label_Comment_list
            // 
            this.label_Comment_list.AutoSize = true;
            this.label_Comment_list.Location = new System.Drawing.Point(246, 10);
            this.label_Comment_list.Name = "label_Comment_list";
            this.label_Comment_list.Size = new System.Drawing.Size(157, 17);
            this.label_Comment_list.TabIndex = 9;
            this.label_Comment_list.Text = "Liste des commentaires";
            // 
            // label_Reponses_list
            // 
            this.label_Reponses_list.AutoSize = true;
            this.label_Reponses_list.Location = new System.Drawing.Point(265, 423);
            this.label_Reponses_list.Name = "label_Reponses_list";
            this.label_Reponses_list.Size = new System.Drawing.Size(128, 17);
            this.label_Reponses_list.TabIndex = 10;
            this.label_Reponses_list.Text = "Liste des réponses";
            // 
            // label_Reponse_Content
            // 
            this.label_Reponse_Content.AutoSize = true;
            this.label_Reponse_Content.Location = new System.Drawing.Point(758, 443);
            this.label_Reponse_Content.Name = "label_Reponse_Content";
            this.label_Reponse_Content.Size = new System.Drawing.Size(156, 17);
            this.label_Reponse_Content.TabIndex = 12;
            this.label_Reponse_Content.Text = "Message de la réponse";
            // 
            // textBox_Reponse_Content
            // 
            this.textBox_Reponse_Content.Location = new System.Drawing.Point(655, 463);
            this.textBox_Reponse_Content.Multiline = true;
            this.textBox_Reponse_Content.Name = "textBox_Reponse_Content";
            this.textBox_Reponse_Content.ReadOnly = true;
            this.textBox_Reponse_Content.Size = new System.Drawing.Size(362, 241);
            this.textBox_Reponse_Content.TabIndex = 11;
            // 
            // label_ID_User
            // 
            this.label_ID_User.AutoSize = true;
            this.label_ID_User.Location = new System.Drawing.Point(983, 707);
            this.label_ID_User.Name = "label_ID_User";
            this.label_ID_User.Size = new System.Drawing.Size(0, 17);
            this.label_ID_User.TabIndex = 13;
            // 
            // Del_Reponse
            // 
            this.Del_Reponse.Location = new System.Drawing.Point(740, 722);
            this.Del_Reponse.Name = "Del_Reponse";
            this.Del_Reponse.Size = new System.Drawing.Size(188, 30);
            this.Del_Reponse.TabIndex = 14;
            this.Del_Reponse.Text = "Supprimer la réponse";
            this.Del_Reponse.UseVisualStyleBackColor = true;
            this.Del_Reponse.Click += new System.EventHandler(this.Del_Reponse_Click);
            // 
            // label_ID_Comment
            // 
            this.label_ID_Comment.Location = new System.Drawing.Point(0, 0);
            this.label_ID_Comment.Name = "label_ID_Comment";
            this.label_ID_Comment.Size = new System.Drawing.Size(100, 23);
            this.label_ID_Comment.TabIndex = 0;
            // 
            // label_ID_Reponse
            // 
            this.label_ID_Reponse.AutoSize = true;
            this.label_ID_Reponse.Location = new System.Drawing.Point(0, 0);
            this.label_ID_Reponse.Name = "label_ID_Reponse";
            this.label_ID_Reponse.Size = new System.Drawing.Size(46, 17);
            this.label_ID_Reponse.TabIndex = 15;
            this.label_ID_Reponse.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 800);
            this.Controls.Add(this.label_ID_Reponse);
            this.Controls.Add(this.label_ID_Comment);
            this.Controls.Add(this.Del_Reponse);
            this.Controls.Add(this.label_ID_User);
            this.Controls.Add(this.label_Reponse_Content);
            this.Controls.Add(this.textBox_Reponse_Content);
            this.Controls.Add(this.label_Reponses_list);
            this.Controls.Add(this.label_Comment_list);
            this.Controls.Add(this.label_Comment_Content);
            this.Controls.Add(this.textBox_Comment_Content);
            this.Controls.Add(this.dataGridView_Reponses);
            this.Controls.Add(this.Del_Comment);
            this.Controls.Add(this.dataGridView_Comments);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Comments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Reponses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Comments;
        private System.Windows.Forms.Button Del_Comment;
        private System.Windows.Forms.DataGridView dataGridView_Reponses;
        private System.Windows.Forms.TextBox textBox_Comment_Content;
        private System.Windows.Forms.Label label_Comment_Content;
        private System.Windows.Forms.Label label_Comment_list;
        private System.Windows.Forms.Label label_Reponses_list;
        private System.Windows.Forms.Label label_Reponse_Content;
        private System.Windows.Forms.TextBox textBox_Reponse_Content;
        private System.Windows.Forms.Label label_ID_User;
        private System.Windows.Forms.Button Del_Reponse;
        private System.Windows.Forms.Label label_ID_Comment;
        private System.Windows.Forms.Label label_ID_Reponse;
    }
}
namespace Mercure.Vue
{
    partial class Ajouter_Modifier_Article
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
            this.groupBox_article = new System.Windows.Forms.GroupBox();
            this.NumericUpDown_Quantite = new System.Windows.Forms.NumericUpDown();
            this.TextBox_Description = new System.Windows.Forms.TextBox();
            this.TextBox_RefArticle = new System.Windows.Forms.TextBox();
            this.ComboBox_Marque = new System.Windows.Forms.ComboBox();
            this.ComboBox_SousFamille = new System.Windows.Forms.ComboBox();
            this.NumericUpDown_PrixHT = new System.Windows.Forms.NumericUpDown();
            this.label_description = new System.Windows.Forms.Label();
            this.label_quantite = new System.Windows.Forms.Label();
            this.label_prixht = new System.Windows.Forms.Label();
            this.label_marque = new System.Windows.Forms.Label();
            this.label_sousfamille = new System.Windows.Forms.Label();
            this.label_refArticle = new System.Windows.Forms.Label();
            this.Button_Annuler = new System.Windows.Forms.Button();
            this.Button_Ajouter_Modifier = new System.Windows.Forms.Button();
            this.groupBox_article.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Quantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_PrixHT)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_article
            // 
            this.groupBox_article.Controls.Add(this.NumericUpDown_Quantite);
            this.groupBox_article.Controls.Add(this.TextBox_Description);
            this.groupBox_article.Controls.Add(this.TextBox_RefArticle);
            this.groupBox_article.Controls.Add(this.ComboBox_Marque);
            this.groupBox_article.Controls.Add(this.ComboBox_SousFamille);
            this.groupBox_article.Controls.Add(this.NumericUpDown_PrixHT);
            this.groupBox_article.Controls.Add(this.label_description);
            this.groupBox_article.Controls.Add(this.label_quantite);
            this.groupBox_article.Controls.Add(this.label_prixht);
            this.groupBox_article.Controls.Add(this.label_marque);
            this.groupBox_article.Controls.Add(this.label_sousfamille);
            this.groupBox_article.Controls.Add(this.label_refArticle);
            this.groupBox_article.Location = new System.Drawing.Point(12, 12);
            this.groupBox_article.Name = "groupBox_article";
            this.groupBox_article.Size = new System.Drawing.Size(511, 405);
            this.groupBox_article.TabIndex = 0;
            this.groupBox_article.TabStop = false;
            // 
            // NumericUpDown_Quantite
            // 
            this.NumericUpDown_Quantite.Location = new System.Drawing.Point(154, 217);
            this.NumericUpDown_Quantite.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumericUpDown_Quantite.Name = "NumericUpDown_Quantite";
            this.NumericUpDown_Quantite.Size = new System.Drawing.Size(71, 20);
            this.NumericUpDown_Quantite.TabIndex = 26;
            this.NumericUpDown_Quantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TextBox_Description
            // 
            this.TextBox_Description.Location = new System.Drawing.Point(153, 269);
            this.TextBox_Description.Multiline = true;
            this.TextBox_Description.Name = "TextBox_Description";
            this.TextBox_Description.Size = new System.Drawing.Size(337, 121);
            this.TextBox_Description.TabIndex = 24;
            // 
            // TextBox_RefArticle
            // 
            this.TextBox_RefArticle.Location = new System.Drawing.Point(153, 39);
            this.TextBox_RefArticle.Name = "TextBox_RefArticle";
            this.TextBox_RefArticle.Size = new System.Drawing.Size(121, 20);
            this.TextBox_RefArticle.TabIndex = 23;
            // 
            // ComboBox_Marque
            // 
            this.ComboBox_Marque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Marque.FormattingEnabled = true;
            this.ComboBox_Marque.Location = new System.Drawing.Point(153, 119);
            this.ComboBox_Marque.Name = "ComboBox_Marque";
            this.ComboBox_Marque.Size = new System.Drawing.Size(201, 21);
            this.ComboBox_Marque.TabIndex = 22;
            // 
            // ComboBox_SousFamille
            // 
            this.ComboBox_SousFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_SousFamille.Location = new System.Drawing.Point(153, 83);
            this.ComboBox_SousFamille.Name = "ComboBox_SousFamille";
            this.ComboBox_SousFamille.Size = new System.Drawing.Size(201, 21);
            this.ComboBox_SousFamille.TabIndex = 21;
            // 
            // NumericUpDown_PrixHT
            // 
            this.NumericUpDown_PrixHT.DecimalPlaces = 2;
            this.NumericUpDown_PrixHT.Location = new System.Drawing.Point(154, 166);
            this.NumericUpDown_PrixHT.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.NumericUpDown_PrixHT.Name = "NumericUpDown_PrixHT";
            this.NumericUpDown_PrixHT.Size = new System.Drawing.Size(71, 20);
            this.NumericUpDown_PrixHT.TabIndex = 20;
            this.NumericUpDown_PrixHT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(35, 269);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(60, 13);
            this.label_description.TabIndex = 18;
            this.label_description.Text = "Description";
            // 
            // label_quantite
            // 
            this.label_quantite.AutoSize = true;
            this.label_quantite.Location = new System.Drawing.Point(35, 224);
            this.label_quantite.Name = "label_quantite";
            this.label_quantite.Size = new System.Drawing.Size(76, 13);
            this.label_quantite.TabIndex = 17;
            this.label_quantite.Text = "Nombre Article";
            // 
            // label_prixht
            // 
            this.label_prixht.AutoSize = true;
            this.label_prixht.Location = new System.Drawing.Point(35, 173);
            this.label_prixht.Name = "label_prixht";
            this.label_prixht.Size = new System.Drawing.Size(76, 13);
            this.label_prixht.TabIndex = 16;
            this.label_prixht.Text = "Prix Hors Taxe";
            // 
            // label_marque
            // 
            this.label_marque.AutoSize = true;
            this.label_marque.Location = new System.Drawing.Point(35, 119);
            this.label_marque.Name = "label_marque";
            this.label_marque.Size = new System.Drawing.Size(46, 13);
            this.label_marque.TabIndex = 15;
            this.label_marque.Text = "Marque ";
            // 
            // label_sousfamille
            // 
            this.label_sousfamille.AutoSize = true;
            this.label_sousfamille.Location = new System.Drawing.Point(35, 83);
            this.label_sousfamille.Name = "label_sousfamille";
            this.label_sousfamille.Size = new System.Drawing.Size(69, 13);
            this.label_sousfamille.TabIndex = 14;
            this.label_sousfamille.Text = " Sous famille ";
            // 
            // label_refArticle
            // 
            this.label_refArticle.AutoSize = true;
            this.label_refArticle.Location = new System.Drawing.Point(35, 42);
            this.label_refArticle.Name = "label_refArticle";
            this.label_refArticle.Size = new System.Drawing.Size(92, 13);
            this.label_refArticle.TabIndex = 13;
            this.label_refArticle.Text = "Reférence Article ";
            // 
            // Button_Annuler
            // 
            this.Button_Annuler.Location = new System.Drawing.Point(427, 449);
            this.Button_Annuler.Name = "Button_Annuler";
            this.Button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Button_Annuler.TabIndex = 28;
            this.Button_Annuler.Text = "Annuler";
            this.Button_Annuler.UseVisualStyleBackColor = true;
            this.Button_Annuler.Click += new System.EventHandler(this.Button_Annuler_Click);
            // 
            // Button_Ajouter_Modifier
            // 
            this.Button_Ajouter_Modifier.Location = new System.Drawing.Point(329, 449);
            this.Button_Ajouter_Modifier.Name = "Button_Ajouter_Modifier";
            this.Button_Ajouter_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Button_Ajouter_Modifier.TabIndex = 27;
            this.Button_Ajouter_Modifier.Text = "Ajouter";
            this.Button_Ajouter_Modifier.UseVisualStyleBackColor = true;
            this.Button_Ajouter_Modifier.Click += new System.EventHandler(this.Button_Ajouter_Modifier_Click);
            // 
            // Ajouter_Modifier_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 484);
            this.Controls.Add(this.Button_Ajouter_Modifier);
            this.Controls.Add(this.Button_Annuler);
            this.Controls.Add(this.groupBox_article);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajouter_Modifier_Article";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox_article.ResumeLayout(false);
            this.groupBox_article.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_Quantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_PrixHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_article;
        private System.Windows.Forms.TextBox TextBox_Description;
        private System.Windows.Forms.TextBox TextBox_RefArticle;
        private System.Windows.Forms.ComboBox ComboBox_Marque;
        private System.Windows.Forms.ComboBox ComboBox_SousFamille;
        private System.Windows.Forms.NumericUpDown NumericUpDown_PrixHT;
        private System.Windows.Forms.Label label_quantite;
        private System.Windows.Forms.Label label_prixht;
        private System.Windows.Forms.Label label_marque;
        private System.Windows.Forms.Label label_sousfamille;
        private System.Windows.Forms.Label label_refArticle;
        private System.Windows.Forms.NumericUpDown NumericUpDown_Quantite;
        private System.Windows.Forms.Button Button_Annuler;
        private System.Windows.Forms.Button Button_Ajouter_Modifier;
        private System.Windows.Forms.Label label_description;
    }
}
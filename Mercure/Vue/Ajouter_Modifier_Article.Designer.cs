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
            this.numericUpDown_quantite = new System.Windows.Forms.NumericUpDown();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_refArticle = new System.Windows.Forms.TextBox();
            this.comboBox_marque = new System.Windows.Forms.ComboBox();
            this.comboBox_sousfamille = new System.Windows.Forms.ComboBox();
            this.numericUpDown_prixht = new System.Windows.Forms.NumericUpDown();
            this.label_description = new System.Windows.Forms.Label();
            this.label_quantite = new System.Windows.Forms.Label();
            this.label_prixht = new System.Windows.Forms.Label();
            this.label_marque = new System.Windows.Forms.Label();
            this.label_sousfamille = new System.Windows.Forms.Label();
            this.label_refArticle = new System.Windows.Forms.Label();
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_ajouter_modifier = new System.Windows.Forms.Button();
            this.groupBox_article.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prixht)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_article
            // 
            this.groupBox_article.Controls.Add(this.numericUpDown_quantite);
            this.groupBox_article.Controls.Add(this.textBox_description);
            this.groupBox_article.Controls.Add(this.textBox_refArticle);
            this.groupBox_article.Controls.Add(this.comboBox_marque);
            this.groupBox_article.Controls.Add(this.comboBox_sousfamille);
            this.groupBox_article.Controls.Add(this.numericUpDown_prixht);
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
            // numericUpDown_quantite
            // 
            this.numericUpDown_quantite.Location = new System.Drawing.Point(154, 217);
            this.numericUpDown_quantite.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_quantite.Name = "numericUpDown_quantite";
            this.numericUpDown_quantite.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown_quantite.TabIndex = 26;
            this.numericUpDown_quantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(153, 269);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(337, 121);
            this.textBox_description.TabIndex = 24;
            // 
            // textBox_refArticle
            // 
            this.textBox_refArticle.Location = new System.Drawing.Point(153, 39);
            this.textBox_refArticle.Name = "textBox_refArticle";
            this.textBox_refArticle.Size = new System.Drawing.Size(121, 20);
            this.textBox_refArticle.TabIndex = 23;
            // 
            // comboBox_marque
            // 
            this.comboBox_marque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_marque.FormattingEnabled = true;
            this.comboBox_marque.Location = new System.Drawing.Point(153, 119);
            this.comboBox_marque.Name = "comboBox_marque";
            this.comboBox_marque.Size = new System.Drawing.Size(201, 21);
            this.comboBox_marque.TabIndex = 22;
            // 
            // comboBox_sousfamille
            // 
            this.comboBox_sousfamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sousfamille.Location = new System.Drawing.Point(153, 83);
            this.comboBox_sousfamille.Name = "comboBox_sousfamille";
            this.comboBox_sousfamille.Size = new System.Drawing.Size(201, 21);
            this.comboBox_sousfamille.TabIndex = 21;
            // 
            // numericUpDown_prixht
            // 
            this.numericUpDown_prixht.DecimalPlaces = 2;
            this.numericUpDown_prixht.Location = new System.Drawing.Point(154, 166);
            this.numericUpDown_prixht.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_prixht.Name = "numericUpDown_prixht";
            this.numericUpDown_prixht.Size = new System.Drawing.Size(71, 20);
            this.numericUpDown_prixht.TabIndex = 20;
            this.numericUpDown_prixht.Value = new decimal(new int[] {
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
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(427, 449);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 28;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_ajouter_modifier
            // 
            this.button_ajouter_modifier.Location = new System.Drawing.Point(329, 449);
            this.button_ajouter_modifier.Name = "button_ajouter_modifier";
            this.button_ajouter_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_modifier.TabIndex = 27;
            this.button_ajouter_modifier.Text = "Ajouter";
            this.button_ajouter_modifier.UseVisualStyleBackColor = true;
            this.button_ajouter_modifier.Click += new System.EventHandler(this.button_ajouter_modifier_Click);
            // 
            // Ajouter_Modifier_Artcle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 484);
            this.Controls.Add(this.button_ajouter_modifier);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.groupBox_article);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajouter_Modifier_Artcle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox_article.ResumeLayout(false);
            this.groupBox_article.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_prixht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_article;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_refArticle;
        private System.Windows.Forms.ComboBox comboBox_marque;
        private System.Windows.Forms.ComboBox comboBox_sousfamille;
        private System.Windows.Forms.NumericUpDown numericUpDown_prixht;
        private System.Windows.Forms.Label label_quantite;
        private System.Windows.Forms.Label label_prixht;
        private System.Windows.Forms.Label label_marque;
        private System.Windows.Forms.Label label_sousfamille;
        private System.Windows.Forms.Label label_refArticle;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantite;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Button button_ajouter_modifier;
        private System.Windows.Forms.Label label_description;
    }
}
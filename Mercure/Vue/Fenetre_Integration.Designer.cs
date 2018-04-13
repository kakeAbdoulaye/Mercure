namespace Mercure.Vue
{
    partial class Fenetre_Integration
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
            this.label_Accueil = new System.Windows.Forms.Label();
            this.button_choix_fichier = new System.Windows.Forms.Button();
            this.text_chemin_fichier_choisi = new System.Windows.Forms.TextBox();
            this.label_choix_fichier = new System.Windows.Forms.Label();
            this.Bar_Progression_Integration_fichier_XML = new System.Windows.Forms.ProgressBar();
            this.textBox_affichage_resultateterreurs = new System.Windows.Forms.TextBox();
            this.groupBox_Integration = new System.Windows.Forms.GroupBox();
            this.radioButton_mise_jour = new System.Windows.Forms.RadioButton();
            this.radioButton_nouvelle_Integration = new System.Windows.Forms.RadioButton();
            this.button_integration = new System.Windows.Forms.Button();
            this.groupBox_choix_fichier = new System.Windows.Forms.GroupBox();
            this.Ouvrir_XML_Fichier = new System.Windows.Forms.OpenFileDialog();
            this.Travail_En_Arriere_Plan = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Integration.SuspendLayout();
            this.groupBox_choix_fichier.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Accueil
            // 
            this.label_Accueil.AutoSize = true;
            this.label_Accueil.Location = new System.Drawing.Point(263, 19);
            this.label_Accueil.Name = "label_Accueil";
            this.label_Accueil.Size = new System.Drawing.Size(59, 13);
            this.label_Accueil.TabIndex = 0;
            this.label_Accueil.Text = " integration";
            // 
            // button_choix_fichier
            // 
            this.button_choix_fichier.Location = new System.Drawing.Point(161, 36);
            this.button_choix_fichier.Name = "button_choix_fichier";
            this.button_choix_fichier.Size = new System.Drawing.Size(75, 23);
            this.button_choix_fichier.TabIndex = 1;
            this.button_choix_fichier.Text = "parcourir";
            this.button_choix_fichier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_choix_fichier.UseVisualStyleBackColor = true;
            this.button_choix_fichier.Click += new System.EventHandler(this.button_choix_fichier_Click);
            // 
            // text_chemin_fichier_choisi
            // 
            this.text_chemin_fichier_choisi.Location = new System.Drawing.Point(254, 38);
            this.text_chemin_fichier_choisi.Name = "text_chemin_fichier_choisi";
            this.text_chemin_fichier_choisi.Size = new System.Drawing.Size(315, 20);
            this.text_chemin_fichier_choisi.TabIndex = 4;
            this.text_chemin_fichier_choisi.TextChanged += new System.EventHandler(this.text_chemin_fichier_choisi_TextChanged);
            this.text_chemin_fichier_choisi.VisibleChanged += new System.EventHandler(this.text_chemin_fichier_choisi_VisibleChanged);
            // 
            // label_choix_fichier
            // 
            this.label_choix_fichier.AutoSize = true;
            this.label_choix_fichier.Location = new System.Drawing.Point(48, 41);
            this.label_choix_fichier.Name = "label_choix_fichier";
            this.label_choix_fichier.Size = new System.Drawing.Size(93, 13);
            this.label_choix_fichier.TabIndex = 5;
            this.label_choix_fichier.Text = "Choisir un fichier : ";
            // 
            // Bar_Progression_Integration_fichier_XML
            // 
            this.Bar_Progression_Integration_fichier_XML.Location = new System.Drawing.Point(91, 94);
            this.Bar_Progression_Integration_fichier_XML.Name = "Bar_Progression_Integration_fichier_XML";
            this.Bar_Progression_Integration_fichier_XML.Size = new System.Drawing.Size(342, 23);
            this.Bar_Progression_Integration_fichier_XML.TabIndex = 6;
            // 
            // textBox_affichage_resultateterreurs
            // 
            this.textBox_affichage_resultateterreurs.Location = new System.Drawing.Point(91, 136);
            this.textBox_affichage_resultateterreurs.Multiline = true;
            this.textBox_affichage_resultateterreurs.Name = "textBox_affichage_resultateterreurs";
            this.textBox_affichage_resultateterreurs.ReadOnly = true;
            this.textBox_affichage_resultateterreurs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_affichage_resultateterreurs.Size = new System.Drawing.Size(342, 173);
            this.textBox_affichage_resultateterreurs.TabIndex = 7;
            // 
            // groupBox_Integration
            // 
            this.groupBox_Integration.Controls.Add(this.radioButton_mise_jour);
            this.groupBox_Integration.Controls.Add(this.radioButton_nouvelle_Integration);
            this.groupBox_Integration.Controls.Add(this.Bar_Progression_Integration_fichier_XML);
            this.groupBox_Integration.Controls.Add(this.textBox_affichage_resultateterreurs);
            this.groupBox_Integration.Controls.Add(this.button_integration);
            this.groupBox_Integration.Location = new System.Drawing.Point(12, 179);
            this.groupBox_Integration.Name = "groupBox_Integration";
            this.groupBox_Integration.Size = new System.Drawing.Size(569, 326);
            this.groupBox_Integration.TabIndex = 8;
            this.groupBox_Integration.TabStop = false;
            this.groupBox_Integration.Text = "Intégration - Base de données";
            // 
            // radioButton_mise_jour
            // 
            this.radioButton_mise_jour.AutoSize = true;
            this.radioButton_mise_jour.Location = new System.Drawing.Point(241, 37);
            this.radioButton_mise_jour.Name = "radioButton_mise_jour";
            this.radioButton_mise_jour.Size = new System.Drawing.Size(79, 17);
            this.radioButton_mise_jour.TabIndex = 11;
            this.radioButton_mise_jour.TabStop = true;
            this.radioButton_mise_jour.Text = "Mise à jour ";
            this.radioButton_mise_jour.UseVisualStyleBackColor = true;
            this.radioButton_mise_jour.CheckedChanged += new System.EventHandler(this.radioButton_mise_jour_CheckedChanged);
            // 
            // radioButton_nouvelle_Integration
            // 
            this.radioButton_nouvelle_Integration.AutoSize = true;
            this.radioButton_nouvelle_Integration.Location = new System.Drawing.Point(51, 37);
            this.radioButton_nouvelle_Integration.Name = "radioButton_nouvelle_Integration";
            this.radioButton_nouvelle_Integration.Size = new System.Drawing.Size(120, 17);
            this.radioButton_nouvelle_Integration.TabIndex = 10;
            this.radioButton_nouvelle_Integration.TabStop = true;
            this.radioButton_nouvelle_Integration.Text = "Nouvelle Intégration";
            this.radioButton_nouvelle_Integration.UseVisualStyleBackColor = true;
            this.radioButton_nouvelle_Integration.CheckedChanged += new System.EventHandler(this.radioButton_nouvelle_Integration_CheckedChanged);
            // 
            // button_integration
            // 
            this.button_integration.Enabled = false;
            this.button_integration.Location = new System.Drawing.Point(403, 37);
            this.button_integration.Name = "button_integration";
            this.button_integration.Size = new System.Drawing.Size(75, 23);
            this.button_integration.TabIndex = 2;
            this.button_integration.Text = "Integrer";
            this.button_integration.UseVisualStyleBackColor = true;
            this.button_integration.Click += new System.EventHandler(this.button_integration_Click);
            // 
            // groupBox_choix_fichier
            // 
            this.groupBox_choix_fichier.Controls.Add(this.button_choix_fichier);
            this.groupBox_choix_fichier.Controls.Add(this.label_choix_fichier);
            this.groupBox_choix_fichier.Controls.Add(this.text_chemin_fichier_choisi);
            this.groupBox_choix_fichier.Location = new System.Drawing.Point(12, 60);
            this.groupBox_choix_fichier.Name = "groupBox_choix_fichier";
            this.groupBox_choix_fichier.Size = new System.Drawing.Size(580, 100);
            this.groupBox_choix_fichier.TabIndex = 9;
            this.groupBox_choix_fichier.TabStop = false;
            // 
            // Ouvrir_XML_Fichier
            // 
            this.Ouvrir_XML_Fichier.DefaultExt = "xml";
            this.Ouvrir_XML_Fichier.Filter = "Fichiers XML|*.xml|Tous les fichiers |*.*";
            this.Ouvrir_XML_Fichier.ReadOnlyChecked = true;
            this.Ouvrir_XML_Fichier.Tag = "Ouvrir Fichier XML";
            this.Ouvrir_XML_Fichier.Title = "Fichier XML";
            // 
            // Travail_En_Arriere_Plan
            // 
            this.Travail_En_Arriere_Plan.WorkerReportsProgress = true;
            this.Travail_En_Arriere_Plan.WorkerSupportsCancellation = true;
            this.Travail_En_Arriere_Plan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Travail_En_Arriere_Plan_DoWork);
            this.Travail_En_Arriere_Plan.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.Travail_En_Arriere_Plan_ProgressChanged);
            this.Travail_En_Arriere_Plan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Travail_En_Arriere_Plan_RunWorkerCompleted);
            // 
            // Fenetre_Integration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(649, 517);
            this.Controls.Add(this.groupBox_choix_fichier);
            this.Controls.Add(this.groupBox_Integration);
            this.Controls.Add(this.label_Accueil);
            this.Name = "Fenetre_Integration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fenetre d\'Integration";
            this.groupBox_Integration.ResumeLayout(false);
            this.groupBox_Integration.PerformLayout();
            this.groupBox_choix_fichier.ResumeLayout(false);
            this.groupBox_choix_fichier.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Accueil;
        private System.Windows.Forms.Button button_choix_fichier;
        private System.Windows.Forms.TextBox text_chemin_fichier_choisi;
        private System.Windows.Forms.Label label_choix_fichier;
        private System.Windows.Forms.ProgressBar Bar_Progression_Integration_fichier_XML;
        private System.Windows.Forms.TextBox textBox_affichage_resultateterreurs;
        private System.Windows.Forms.GroupBox groupBox_Integration;
        private System.Windows.Forms.GroupBox groupBox_choix_fichier;
        private System.Windows.Forms.OpenFileDialog Ouvrir_XML_Fichier;
        private System.ComponentModel.BackgroundWorker Travail_En_Arriere_Plan;
        private System.Windows.Forms.RadioButton radioButton_nouvelle_Integration;
        private System.Windows.Forms.RadioButton radioButton_mise_jour;
        private System.Windows.Forms.Button button_integration;
    }
}
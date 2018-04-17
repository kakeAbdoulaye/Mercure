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
            this.Button_Choix_Fichier = new System.Windows.Forms.Button();
            this.Text_Chemin_Fichier_Choisi = new System.Windows.Forms.TextBox();
            this.label_choix_fichier = new System.Windows.Forms.Label();
            this.Bar_Progression_Integration_Fichier_XML = new System.Windows.Forms.ProgressBar();
            this.TextBox_Affichage_ResultatEtErreurs = new System.Windows.Forms.TextBox();
            this.groupBox_Integration = new System.Windows.Forms.GroupBox();
            this.RadioButton_Mise_Jour = new System.Windows.Forms.RadioButton();
            this.RadioButton_Nouvelle_Integration = new System.Windows.Forms.RadioButton();
            this.Button_Integration = new System.Windows.Forms.Button();
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
            // Button_Choix_Fichier
            // 
            this.Button_Choix_Fichier.Location = new System.Drawing.Point(161, 36);
            this.Button_Choix_Fichier.Name = "Button_Choix_Fichier";
            this.Button_Choix_Fichier.Size = new System.Drawing.Size(75, 23);
            this.Button_Choix_Fichier.TabIndex = 1;
            this.Button_Choix_Fichier.Text = "parcourir";
            this.Button_Choix_Fichier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Choix_Fichier.UseVisualStyleBackColor = true;
            this.Button_Choix_Fichier.Click += new System.EventHandler(this.Button_Choix_Fichier_Click);
            // 
            // Text_Chemin_Fichier_Choisi
            // 
            this.Text_Chemin_Fichier_Choisi.Location = new System.Drawing.Point(254, 38);
            this.Text_Chemin_Fichier_Choisi.Name = "Text_Chemin_Fichier_Choisi";
            this.Text_Chemin_Fichier_Choisi.Size = new System.Drawing.Size(315, 20);
            this.Text_Chemin_Fichier_Choisi.TabIndex = 4;
            this.Text_Chemin_Fichier_Choisi.TextChanged += new System.EventHandler(this.Text_Chemin_Fichier_Choisi_TextChanged);
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
            // Bar_Progression_Integration_Fichier_XML
            // 
            this.Bar_Progression_Integration_Fichier_XML.Location = new System.Drawing.Point(91, 94);
            this.Bar_Progression_Integration_Fichier_XML.Name = "Bar_Progression_Integration_Fichier_XML";
            this.Bar_Progression_Integration_Fichier_XML.Size = new System.Drawing.Size(342, 23);
            this.Bar_Progression_Integration_Fichier_XML.TabIndex = 6;
            // 
            // TextBox_Affichage_ResultatEtErreurs
            // 
            this.TextBox_Affichage_ResultatEtErreurs.Location = new System.Drawing.Point(91, 136);
            this.TextBox_Affichage_ResultatEtErreurs.Multiline = true;
            this.TextBox_Affichage_ResultatEtErreurs.Name = "TextBox_Affichage_ResultatEtErreurs";
            this.TextBox_Affichage_ResultatEtErreurs.ReadOnly = true;
            this.TextBox_Affichage_ResultatEtErreurs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBox_Affichage_ResultatEtErreurs.Size = new System.Drawing.Size(342, 173);
            this.TextBox_Affichage_ResultatEtErreurs.TabIndex = 7;
            // 
            // groupBox_Integration
            // 
            this.groupBox_Integration.Controls.Add(this.RadioButton_Mise_Jour);
            this.groupBox_Integration.Controls.Add(this.RadioButton_Nouvelle_Integration);
            this.groupBox_Integration.Controls.Add(this.Bar_Progression_Integration_Fichier_XML);
            this.groupBox_Integration.Controls.Add(this.TextBox_Affichage_ResultatEtErreurs);
            this.groupBox_Integration.Controls.Add(this.Button_Integration);
            this.groupBox_Integration.Location = new System.Drawing.Point(12, 179);
            this.groupBox_Integration.Name = "groupBox_Integration";
            this.groupBox_Integration.Size = new System.Drawing.Size(569, 326);
            this.groupBox_Integration.TabIndex = 8;
            this.groupBox_Integration.TabStop = false;
            this.groupBox_Integration.Text = "Intégration - Base de données";
            // 
            // RadioButton_Mise_Jour
            // 
            this.RadioButton_Mise_Jour.AutoSize = true;
            this.RadioButton_Mise_Jour.Location = new System.Drawing.Point(241, 37);
            this.RadioButton_Mise_Jour.Name = "RadioButton_Mise_Jour";
            this.RadioButton_Mise_Jour.Size = new System.Drawing.Size(79, 17);
            this.RadioButton_Mise_Jour.TabIndex = 11;
            this.RadioButton_Mise_Jour.TabStop = true;
            this.RadioButton_Mise_Jour.Text = "Mise à jour ";
            this.RadioButton_Mise_Jour.UseVisualStyleBackColor = true;
            this.RadioButton_Mise_Jour.CheckedChanged += new System.EventHandler(this.RadioButton_Mise_Jour_CheckedChanged);
            // 
            // RadioButton_Nouvelle_Integration
            // 
            this.RadioButton_Nouvelle_Integration.AutoSize = true;
            this.RadioButton_Nouvelle_Integration.Location = new System.Drawing.Point(51, 37);
            this.RadioButton_Nouvelle_Integration.Name = "RadioButton_Nouvelle_Integration";
            this.RadioButton_Nouvelle_Integration.Size = new System.Drawing.Size(120, 17);
            this.RadioButton_Nouvelle_Integration.TabIndex = 10;
            this.RadioButton_Nouvelle_Integration.TabStop = true;
            this.RadioButton_Nouvelle_Integration.Text = "Nouvelle Intégration";
            this.RadioButton_Nouvelle_Integration.UseVisualStyleBackColor = true;
            this.RadioButton_Nouvelle_Integration.CheckedChanged += new System.EventHandler(this.RadioButton_Nouvelle_Integration_CheckedChanged);
            // 
            // Button_Integration
            // 
            this.Button_Integration.Enabled = false;
            this.Button_Integration.Location = new System.Drawing.Point(403, 37);
            this.Button_Integration.Name = "Button_Integration";
            this.Button_Integration.Size = new System.Drawing.Size(75, 23);
            this.Button_Integration.TabIndex = 2;
            this.Button_Integration.Text = "Integrer";
            this.Button_Integration.UseVisualStyleBackColor = true;
            this.Button_Integration.Click += new System.EventHandler(this.Button_Integration_Click);
            // 
            // groupBox_choix_fichier
            // 
            this.groupBox_choix_fichier.Controls.Add(this.Button_Choix_Fichier);
            this.groupBox_choix_fichier.Controls.Add(this.label_choix_fichier);
            this.groupBox_choix_fichier.Controls.Add(this.Text_Chemin_Fichier_Choisi);
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
        private System.Windows.Forms.Button Button_Choix_Fichier;
        private System.Windows.Forms.TextBox Text_Chemin_Fichier_Choisi;
        private System.Windows.Forms.Label label_choix_fichier;
        private System.Windows.Forms.ProgressBar Bar_Progression_Integration_Fichier_XML;
        private System.Windows.Forms.TextBox TextBox_Affichage_ResultatEtErreurs;
        private System.Windows.Forms.GroupBox groupBox_Integration;
        private System.Windows.Forms.GroupBox groupBox_choix_fichier;
        private System.Windows.Forms.OpenFileDialog Ouvrir_XML_Fichier;
        private System.ComponentModel.BackgroundWorker Travail_En_Arriere_Plan;
        private System.Windows.Forms.RadioButton RadioButton_Nouvelle_Integration;
        private System.Windows.Forms.RadioButton RadioButton_Mise_Jour;
        private System.Windows.Forms.Button Button_Integration;
    }
}
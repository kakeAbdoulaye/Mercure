namespace Mercure.Vue
{
    partial class ApplicatioCentrale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicatioCentrale));
            this.Barre_Menu = new System.Windows.Forms.MenuStrip();
            this.Fichier_Menu_Item = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Barre_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barre_Outil = new System.Windows.Forms.ToolStrip();
            this.listView_Articles = new System.Windows.Forms.ListView();
            this.contextMenu_optionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Barre_Menu.SuspendLayout();
            this.Barre_Status.SuspendLayout();
            this.contextMenu_optionClicDroit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barre_Menu
            // 
            this.Barre_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier_Menu_Item,
            this.familleToolStripMenuItem,
            this.sousFamilleToolStripMenuItem,
            this.marqueToolStripMenuItem});
            this.Barre_Menu.Location = new System.Drawing.Point(0, 0);
            this.Barre_Menu.Name = "Barre_Menu";
            this.Barre_Menu.Size = new System.Drawing.Size(887, 24);
            this.Barre_Menu.TabIndex = 0;
            this.Barre_Menu.Text = "menuStrip1";
            // 
            // Fichier_Menu_Item
            // 
            this.Fichier_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.Fichier_Menu_Item.Name = "Fichier_Menu_Item";
            this.Fichier_Menu_Item.Size = new System.Drawing.Size(54, 20);
            this.Fichier_Menu_Item.Text = "&Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(108, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem,
            this.ajouterToolStripMenuItem});
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.familleToolStripMenuItem.Text = "Famille";
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.afficherToolStripMenuItem.Text = "Afficher";
            this.afficherToolStripMenuItem.Click += new System.EventHandler(this.afficherFamilleToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterFamilleToolStripMenuItem_Click);
            // 
            // sousFamilleToolStripMenuItem
            // 
            this.sousFamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem1,
            this.ajouterToolStripMenuItem1});
            this.sousFamilleToolStripMenuItem.Name = "sousFamilleToolStripMenuItem";
            this.sousFamilleToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sousFamilleToolStripMenuItem.Text = "Sous Famille";
            // 
            // afficherToolStripMenuItem1
            // 
            this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
            this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.afficherToolStripMenuItem1.Text = "Afficher";
            this.afficherToolStripMenuItem1.Click += new System.EventHandler(this.afficherSousFamilleToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            this.ajouterToolStripMenuItem1.Click += new System.EventHandler(this.ajouterSousFamilleToolStripMenuItem_Click);
            // 
            // marqueToolStripMenuItem
            // 
            this.marqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherToolStripMenuItem2,
            this.ajouterToolStripMenuItem2});
            this.marqueToolStripMenuItem.Name = "marqueToolStripMenuItem";
            this.marqueToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.marqueToolStripMenuItem.Text = "Marque";
            // 
            // afficherToolStripMenuItem2
            // 
            this.afficherToolStripMenuItem2.Name = "afficherToolStripMenuItem2";
            this.afficherToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.afficherToolStripMenuItem2.Text = "Afficher";
            this.afficherToolStripMenuItem2.Click += new System.EventHandler(this.afficherMarqueToolStripMenuItem_Click);
            // 
            // ajouterToolStripMenuItem2
            // 
            this.ajouterToolStripMenuItem2.Name = "ajouterToolStripMenuItem2";
            this.ajouterToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.ajouterToolStripMenuItem2.Text = "Ajouter";
            this.ajouterToolStripMenuItem2.Click += new System.EventHandler(this.ajouterMarqueToolStripMenuItem_Click);
            // 
            // Barre_Status
            // 
            this.Barre_Status.BackColor = System.Drawing.Color.Transparent;
            this.Barre_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.label_Status});
            this.Barre_Status.Location = new System.Drawing.Point(0, 424);
            this.Barre_Status.Name = "Barre_Status";
            this.Barre_Status.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Barre_Status.Size = new System.Drawing.Size(887, 22);
            this.Barre_Status.TabIndex = 1;
            this.Barre_Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // label_Status
            // 
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 17);
            // 
            // Barre_Outil
            // 
            this.Barre_Outil.Location = new System.Drawing.Point(0, 24);
            this.Barre_Outil.Name = "Barre_Outil";
            this.Barre_Outil.Size = new System.Drawing.Size(887, 25);
            this.Barre_Outil.TabIndex = 2;
            this.Barre_Outil.Text = "toolStrip1";
            // 
            // listView_Articles
            // 
            this.listView_Articles.FullRowSelect = true;
            this.listView_Articles.GridLines = true;
            this.listView_Articles.Location = new System.Drawing.Point(12, 52);
            this.listView_Articles.MultiSelect = false;
            this.listView_Articles.Name = "listView_Articles";
            this.listView_Articles.Size = new System.Drawing.Size(858, 344);
            this.listView_Articles.TabIndex = 4;
            this.listView_Articles.UseCompatibleStateImageBehavior = false;
            this.listView_Articles.View = System.Windows.Forms.View.Details;
            this.listView_Articles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Articles_KeyDown);
            this.listView_Articles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Articles_MouseClick);
            this.listView_Articles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Articles_MouseDoubleClick);
            // 
            // contextMenu_optionClicDroit
            // 
            this.contextMenu_optionClicDroit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.contextMenu_optionClicDroit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.contextMenu_optionClicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem3,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenu_optionClicDroit.Name = "contextMenu_optionClicDroit";
            this.contextMenu_optionClicDroit.Size = new System.Drawing.Size(153, 92);
            this.contextMenu_optionClicDroit.TabStop = true;
            // 
            // ajouterToolStripMenuItem3
            // 
            this.ajouterToolStripMenuItem3.Name = "ajouterToolStripMenuItem3";
            this.ajouterToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem3.Text = "Ajouter";
            this.ajouterToolStripMenuItem3.Click += new System.EventHandler(this.ajouterToolStripMenuItem3_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // ApplicatioCentrale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 446);
            this.Controls.Add(this.listView_Articles);
            this.Controls.Add(this.Barre_Outil);
            this.Controls.Add(this.Barre_Status);
            this.Controls.Add(this.Barre_Menu);
            this.MainMenuStrip = this.Barre_Menu;
            this.Name = "ApplicatioCentrale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Centrale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicatioCentrale_FormClosing);
            this.Barre_Menu.ResumeLayout(false);
            this.Barre_Menu.PerformLayout();
            this.Barre_Status.ResumeLayout(false);
            this.Barre_Status.PerformLayout();
            this.contextMenu_optionClicDroit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Barre_Menu;
        private System.Windows.Forms.StatusStrip Barre_Status;
        private System.Windows.Forms.ToolStrip Barre_Outil;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel label_Status;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem marqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem2;
        private System.Windows.Forms.ListView listView_Articles;
        private System.Windows.Forms.ToolStripMenuItem Fichier_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu_optionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}


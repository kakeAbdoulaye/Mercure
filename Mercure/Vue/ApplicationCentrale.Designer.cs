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
            this.OuvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AfficherFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AfficherSousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterSousFamilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AfficherMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AjouterMarqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Barre_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Statuslabel_Operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.Barre_Outil = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_AjoutArticle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton_QuitterApplication = new System.Windows.Forms.ToolStripButton();
            this.ListView_Articles = new System.Windows.Forms.ListView();
            this.ContextMenu_OptionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AjouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SupprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Barre_Menu.SuspendLayout();
            this.Barre_Status.SuspendLayout();
            this.Barre_Outil.SuspendLayout();
            this.ContextMenu_OptionClicDroit.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barre_Menu
            // 
            this.Barre_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fichier_Menu_Item,
            this.FamilleToolStripMenuItem,
            this.SousFamilleToolStripMenuItem,
            this.MarqueToolStripMenuItem});
            this.Barre_Menu.Location = new System.Drawing.Point(0, 0);
            this.Barre_Menu.Name = "Barre_Menu";
            this.Barre_Menu.Size = new System.Drawing.Size(887, 24);
            this.Barre_Menu.TabIndex = 0;
            this.Barre_Menu.Text = "menuStrip1";
            // 
            // Fichier_Menu_Item
            // 
            this.Fichier_Menu_Item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OuvrirToolStripMenuItem,
            this.toolStripSeparator2,
            this.QuitterToolStripMenuItem});
            this.Fichier_Menu_Item.Name = "Fichier_Menu_Item";
            this.Fichier_Menu_Item.Size = new System.Drawing.Size(54, 20);
            this.Fichier_Menu_Item.Text = "&Fichier";
            // 
            // OuvrirToolStripMenuItem
            // 
            this.OuvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OuvrirToolStripMenuItem.Image")));
            this.OuvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem";
            this.OuvrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OuvrirToolStripMenuItem.Text = "&Ouvrir";
            this.OuvrirToolStripMenuItem.Click += new System.EventHandler(this.OuvrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // QuitterToolStripMenuItem
            // 
            this.QuitterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("QuitterToolStripMenuItem.Image")));
            this.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem";
            this.QuitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.QuitterToolStripMenuItem.Text = "&Quitter";
            this.QuitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // FamilleToolStripMenuItem
            // 
            this.FamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AfficherFamilleToolStripMenuItem,
            this.AjouterFamilleToolStripMenuItem});
            this.FamilleToolStripMenuItem.Name = "FamilleToolStripMenuItem";
            this.FamilleToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FamilleToolStripMenuItem.Text = "Famille";
            // 
            // AfficherFamilleToolStripMenuItem
            // 
            this.AfficherFamilleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AfficherFamilleToolStripMenuItem.Image")));
            this.AfficherFamilleToolStripMenuItem.Name = "AfficherFamilleToolStripMenuItem";
            this.AfficherFamilleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.AfficherFamilleToolStripMenuItem.Text = "Liste des familles";
            this.AfficherFamilleToolStripMenuItem.Click += new System.EventHandler(this.AfficherFamilleToolStripMenuItem_Click);
            // 
            // AjouterFamilleToolStripMenuItem
            // 
            this.AjouterFamilleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AjouterFamilleToolStripMenuItem.Image")));
            this.AjouterFamilleToolStripMenuItem.Name = "AjouterFamilleToolStripMenuItem";
            this.AjouterFamilleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.AjouterFamilleToolStripMenuItem.Text = "Ajouter ";
            this.AjouterFamilleToolStripMenuItem.Click += new System.EventHandler(this.AjouterFamilleToolStripMenuItem_Click);
            // 
            // SousFamilleToolStripMenuItem
            // 
            this.SousFamilleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AfficherSousFamilleToolStripMenuItem,
            this.AjouterSousFamilleToolStripMenuItem});
            this.SousFamilleToolStripMenuItem.Name = "SousFamilleToolStripMenuItem";
            this.SousFamilleToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.SousFamilleToolStripMenuItem.Text = "Sous Famille";
            // 
            // AfficherSousFamilleToolStripMenuItem
            // 
            this.AfficherSousFamilleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AfficherSousFamilleToolStripMenuItem.Image")));
            this.AfficherSousFamilleToolStripMenuItem.Name = "AfficherSousFamilleToolStripMenuItem";
            this.AfficherSousFamilleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.AfficherSousFamilleToolStripMenuItem.Text = "Liste des sous familles";
            this.AfficherSousFamilleToolStripMenuItem.Click += new System.EventHandler(this.AfficherSousFamilleToolStripMenuItem_Click);
            // 
            // AjouterSousFamilleToolStripMenuItem
            // 
            this.AjouterSousFamilleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AjouterSousFamilleToolStripMenuItem.Image")));
            this.AjouterSousFamilleToolStripMenuItem.Name = "AjouterSousFamilleToolStripMenuItem";
            this.AjouterSousFamilleToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.AjouterSousFamilleToolStripMenuItem.Text = "Ajouter";
            this.AjouterSousFamilleToolStripMenuItem.Click += new System.EventHandler(this.AjouterSousFamilleToolStripMenuItem_Click);
            // 
            // MarqueToolStripMenuItem
            // 
            this.MarqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AfficherMarqueToolStripMenuItem,
            this.AjouterMarqueToolStripMenuItem});
            this.MarqueToolStripMenuItem.Name = "MarqueToolStripMenuItem";
            this.MarqueToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.MarqueToolStripMenuItem.Text = "Marque";
            // 
            // AfficherMarqueToolStripMenuItem
            // 
            this.AfficherMarqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AfficherMarqueToolStripMenuItem.Image")));
            this.AfficherMarqueToolStripMenuItem.Name = "AfficherMarqueToolStripMenuItem";
            this.AfficherMarqueToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AfficherMarqueToolStripMenuItem.Text = "Liste des marques";
            this.AfficherMarqueToolStripMenuItem.Click += new System.EventHandler(this.AfficherMarqueToolStripMenuItem_Click);
            // 
            // AjouterMarqueToolStripMenuItem
            // 
            this.AjouterMarqueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AjouterMarqueToolStripMenuItem.Image")));
            this.AjouterMarqueToolStripMenuItem.Name = "AjouterMarqueToolStripMenuItem";
            this.AjouterMarqueToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.AjouterMarqueToolStripMenuItem.Text = "Ajouter";
            this.AjouterMarqueToolStripMenuItem.Click += new System.EventHandler(this.AjouterMarqueToolStripMenuItem_Click);
            // 
            // Barre_Status
            // 
            this.Barre_Status.BackColor = System.Drawing.Color.Transparent;
            this.Barre_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.label_Status,
            this.Statuslabel_Operation});
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
            // Statuslabel_Operation
            // 
            this.Statuslabel_Operation.ForeColor = System.Drawing.Color.Maroon;
            this.Statuslabel_Operation.Name = "Statuslabel_Operation";
            this.Statuslabel_Operation.Size = new System.Drawing.Size(58, 17);
            this.Statuslabel_Operation.Text = "Connecté";
            // 
            // Barre_Outil
            // 
            this.Barre_Outil.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_AjoutArticle,
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.ToolStripButton_QuitterApplication});
            this.Barre_Outil.Location = new System.Drawing.Point(0, 24);
            this.Barre_Outil.Name = "Barre_Outil";
            this.Barre_Outil.Size = new System.Drawing.Size(887, 25);
            this.Barre_Outil.TabIndex = 2;
            this.Barre_Outil.Text = "toolStrip1";
            // 
            // ToolStripButton_AjoutArticle
            // 
            this.ToolStripButton_AjoutArticle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AjoutArticle.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_AjoutArticle.Image")));
            this.ToolStripButton_AjoutArticle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_AjoutArticle.Name = "ToolStripButton_AjoutArticle";
            this.ToolStripButton_AjoutArticle.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_AjoutArticle.Text = "Ajouter un nouvel article";
            this.ToolStripButton_AjoutArticle.Click += new System.EventHandler(this.ToolStripButton_AjoutArticle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton_QuitterApplication
            // 
            this.ToolStripButton_QuitterApplication.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_QuitterApplication.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_QuitterApplication.Image")));
            this.ToolStripButton_QuitterApplication.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_QuitterApplication.Name = "ToolStripButton_QuitterApplication";
            this.ToolStripButton_QuitterApplication.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_QuitterApplication.Text = "Quitter Application";
            this.ToolStripButton_QuitterApplication.Click += new System.EventHandler(this.ToolStripButton_QuitterApplication_Click);
            // 
            // ListView_Articles
            // 
            this.ListView_Articles.FullRowSelect = true;
            this.ListView_Articles.GridLines = true;
            this.ListView_Articles.Location = new System.Drawing.Point(12, 52);
            this.ListView_Articles.MultiSelect = false;
            this.ListView_Articles.Name = "ListView_Articles";
            this.ListView_Articles.Size = new System.Drawing.Size(858, 344);
            this.ListView_Articles.TabIndex = 4;
            this.ListView_Articles.UseCompatibleStateImageBehavior = false;
            this.ListView_Articles.View = System.Windows.Forms.View.Details;
            this.ListView_Articles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_Articles_KeyDown);
            this.ListView_Articles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Articles_MouseClick);
            this.ListView_Articles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Articles_MouseDoubleClick);
            // 
            // ContextMenu_OptionClicDroit
            // 
            this.ContextMenu_OptionClicDroit.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.ContextMenu_OptionClicDroit.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ContextMenu_OptionClicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AjouterToolStripMenuItem,
            this.ModifierToolStripMenuItem,
            this.SupprimerToolStripMenuItem});
            this.ContextMenu_OptionClicDroit.Name = "contextMenu_optionClicDroit";
            this.ContextMenu_OptionClicDroit.Size = new System.Drawing.Size(130, 70);
            this.ContextMenu_OptionClicDroit.TabStop = true;
            // 
            // AjouterToolStripMenuItem
            // 
            this.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem";
            this.AjouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.AjouterToolStripMenuItem.Text = "Ajouter";
            this.AjouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem3_Click);
            // 
            // ModifierToolStripMenuItem
            // 
            this.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem";
            this.ModifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ModifierToolStripMenuItem.Text = "Modifier";
            this.ModifierToolStripMenuItem.Click += new System.EventHandler(this.ModifierToolStripMenuItem_Click);
            // 
            // SupprimerToolStripMenuItem
            // 
            this.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem";
            this.SupprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.SupprimerToolStripMenuItem.Text = "Supprimer";
            this.SupprimerToolStripMenuItem.Click += new System.EventHandler(this.SupprimerToolStripMenuItem_Click);
            // 
            // ApplicatioCentrale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(887, 446);
            this.Controls.Add(this.ListView_Articles);
            this.Controls.Add(this.Barre_Outil);
            this.Controls.Add(this.Barre_Status);
            this.Controls.Add(this.Barre_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.Barre_Menu;
            this.Name = "ApplicatioCentrale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Centrale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ApplicatioCentrale_FormClosing);
            this.Barre_Menu.ResumeLayout(false);
            this.Barre_Menu.PerformLayout();
            this.Barre_Status.ResumeLayout(false);
            this.Barre_Status.PerformLayout();
            this.Barre_Outil.ResumeLayout(false);
            this.Barre_Outil.PerformLayout();
            this.ContextMenu_OptionClicDroit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Barre_Menu;
        private System.Windows.Forms.StatusStrip Barre_Status;
        private System.Windows.Forms.ToolStrip Barre_Outil;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel label_Status;
        private System.Windows.Forms.ToolStripMenuItem FamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AfficherFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjouterFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AfficherSousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjouterSousFamilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AfficherMarqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjouterMarqueToolStripMenuItem;
        private System.Windows.Forms.ListView ListView_Articles;
        private System.Windows.Forms.ToolStripMenuItem Fichier_Menu_Item;
        private System.Windows.Forms.ToolStripMenuItem OuvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem QuitterToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_OptionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem AjouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SupprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AjoutArticle;
        private System.Windows.Forms.ToolStripStatusLabel Statuslabel_Operation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ToolStripButton_QuitterApplication;
    }
}


namespace Mercure.Vue
{
    partial class ApplicationFamille
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationFamille));
            this.ListView_Famille = new System.Windows.Forms.ListView();
            this.ContextMenu_OptionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_Operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip_Menu = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_AjoutFamille = new System.Windows.Forms.ToolStripButton();
            this.ContextMenu_OptionClicDroit.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.ToolStrip_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView_Famille
            // 
            this.ListView_Famille.FullRowSelect = true;
            this.ListView_Famille.GridLines = true;
            this.ListView_Famille.Location = new System.Drawing.Point(28, 28);
            this.ListView_Famille.MultiSelect = false;
            this.ListView_Famille.Name = "ListView_Famille";
            this.ListView_Famille.Size = new System.Drawing.Size(668, 379);
            this.ListView_Famille.TabIndex = 0;
            this.ListView_Famille.UseCompatibleStateImageBehavior = false;
            this.ListView_Famille.View = System.Windows.Forms.View.Details;
            this.ListView_Famille.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_Famille_KeyDown);
            this.ListView_Famille.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Famille_MouseClick);
            this.ListView_Famille.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Famille_MouseDoubleClick);
            // 
            // contextMenu_optionClicDroit
            // 
            this.ContextMenu_OptionClicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.ContextMenu_OptionClicDroit.Name = "contextMenu_optionClicDroit";
            this.ContextMenu_OptionClicDroit.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.AjouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.ModifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.SupprimerToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_Operation});
            this.statusStrip.Location = new System.Drawing.Point(0, 421);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(759, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StatusLabel_Operation
            // 
            this.StatusLabel_Operation.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.StatusLabel_Operation.ForeColor = System.Drawing.Color.Maroon;
            this.StatusLabel_Operation.Name = "StatusLabel_Operation";
            this.StatusLabel_Operation.Size = new System.Drawing.Size(58, 17);
            this.StatusLabel_Operation.Text = "Connecté";
            // 
            // ToolStrip_Menu
            // 
            this.ToolStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_AjoutFamille});
            this.ToolStrip_Menu.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip_Menu.Name = "ToolStrip_Menu";
            this.ToolStrip_Menu.Size = new System.Drawing.Size(759, 25);
            this.ToolStrip_Menu.TabIndex = 2;
            this.ToolStrip_Menu.Text = "toolStrip1";
            // 
            // ToolStripButton_AjoutFamille
            // 
            this.ToolStripButton_AjoutFamille.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AjoutFamille.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_AjoutFamille.Image")));
            this.ToolStripButton_AjoutFamille.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_AjoutFamille.Name = "ToolStripButton_AjoutFamille";
            this.ToolStripButton_AjoutFamille.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_AjoutFamille.Text = "Ajouter Famille";
            this.ToolStripButton_AjoutFamille.ToolTipText = "Ajouter Famille";
            this.ToolStripButton_AjoutFamille.Click += new System.EventHandler(this.ToolStripButton_AjoutFamille_Click);
            // 
            // ApplicationFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(759, 443);
            this.Controls.Add(this.ToolStrip_Menu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ListView_Famille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Famille";
            this.ContextMenu_OptionClicDroit.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ToolStrip_Menu.ResumeLayout(false);
            this.ToolStrip_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Famille;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_OptionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Operation;
        private System.Windows.Forms.ToolStrip ToolStrip_Menu;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AjoutFamille;
    }
}
namespace Mercure.Vue
{
    partial class ApplicationSousFamille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSousFamille));
            this.ListView_SousFamille = new System.Windows.Forms.ListView();
            this.ContextMenu_OptionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_AjoutSousFamille = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_Operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContextMenu_OptionClicDroit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView_SousFamille
            // 
            this.ListView_SousFamille.FullRowSelect = true;
            this.ListView_SousFamille.GridLines = true;
            this.ListView_SousFamille.Location = new System.Drawing.Point(24, 27);
            this.ListView_SousFamille.MultiSelect = false;
            this.ListView_SousFamille.Name = "ListView_SousFamille";
            this.ListView_SousFamille.Size = new System.Drawing.Size(648, 391);
            this.ListView_SousFamille.TabIndex = 0;
            this.ListView_SousFamille.UseCompatibleStateImageBehavior = false;
            this.ListView_SousFamille.View = System.Windows.Forms.View.Details;
            this.ListView_SousFamille.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_SousFamille_KeyDown);
            this.ListView_SousFamille.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_SousFamille_MouseClick);
            this.ListView_SousFamille.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_SousFamille_MouseDoubleClick);
            // 
            // ContextMenu_OptionClicDroit
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_AjoutSousFamille});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(711, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "ToolStrip_Menu";
            // 
            // ToolStripButton_AjoutSousFamille
            // 
            this.ToolStripButton_AjoutSousFamille.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AjoutSousFamille.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_AjoutSousFamille.Image")));
            this.ToolStripButton_AjoutSousFamille.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_AjoutSousFamille.Name = "ToolStripButton_AjoutSousFamille";
            this.ToolStripButton_AjoutSousFamille.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_AjoutSousFamille.Text = "Ajouter une sous famille";
            this.ToolStripButton_AjoutSousFamille.Click += new System.EventHandler(this.ToolStripButton_AjoutSousFamille_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_Operation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(711, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // StatusLabel_Operation
            // 
            this.StatusLabel_Operation.ForeColor = System.Drawing.Color.Maroon;
            this.StatusLabel_Operation.Name = "StatusLabel_Operation";
            this.StatusLabel_Operation.Size = new System.Drawing.Size(58, 17);
            this.StatusLabel_Operation.Text = "Connecté";
            // 
            // ApplicationSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ListView_SousFamille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Sous Famille";
            this.ContextMenu_OptionClicDroit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_SousFamille;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_OptionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Operation;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AjoutSousFamille;
    }
}
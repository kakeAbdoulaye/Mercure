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
            this.listView_SousFamille = new System.Windows.Forms.ListView();
            this.contextMenu_optionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_optionClicDroit.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_SousFamille
            // 
            this.listView_SousFamille.FullRowSelect = true;
            this.listView_SousFamille.GridLines = true;
            this.listView_SousFamille.Location = new System.Drawing.Point(24, 27);
            this.listView_SousFamille.MultiSelect = false;
            this.listView_SousFamille.Name = "listView_SousFamille";
            this.listView_SousFamille.Size = new System.Drawing.Size(685, 391);
            this.listView_SousFamille.TabIndex = 0;
            this.listView_SousFamille.UseCompatibleStateImageBehavior = false;
            this.listView_SousFamille.View = System.Windows.Forms.View.Details;
            this.listView_SousFamille.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_SousFamille_KeyDown);
            this.listView_SousFamille.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_SousFamille_MouseClick);
            this.listView_SousFamille.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_SousFamille_MouseDoubleClick);
            // 
            // contextMenu_optionClicDroit
            // 
            this.contextMenu_optionClicDroit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenu_optionClicDroit.Name = "contextMenu_optionClicDroit";
            this.contextMenu_optionClicDroit.Size = new System.Drawing.Size(153, 92);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
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
            // ApplicationSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 430);
            this.Controls.Add(this.listView_SousFamille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Sous Famille";
            this.contextMenu_optionClicDroit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_SousFamille;
        private System.Windows.Forms.ContextMenuStrip contextMenu_optionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
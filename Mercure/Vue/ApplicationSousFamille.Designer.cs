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
            this.listView_SousFamille = new System.Windows.Forms.ListView();
            this.contextMenu_optionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel_operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripButton_ajoutSousFamille = new System.Windows.Forms.ToolStripButton();
            this.contextMenu_optionClicDroit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_SousFamille
            // 
            this.listView_SousFamille.FullRowSelect = true;
            this.listView_SousFamille.GridLines = true;
            this.listView_SousFamille.Location = new System.Drawing.Point(24, 27);
            this.listView_SousFamille.MultiSelect = false;
            this.listView_SousFamille.Name = "listView_SousFamille";
            this.listView_SousFamille.Size = new System.Drawing.Size(648, 391);
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
            this.contextMenu_optionClicDroit.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_ajoutSousFamille});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(711, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel_operation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(711, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel_operation
            // 
            this.statuslabel_operation.ForeColor = System.Drawing.Color.Maroon;
            this.statuslabel_operation.Name = "statuslabel_operation";
            this.statuslabel_operation.Size = new System.Drawing.Size(58, 17);
            this.statuslabel_operation.Text = "Connecté";
            // 
            // toolStripButton_ajoutSousFamille
            // 
            this.toolStripButton_ajoutSousFamille.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ajoutSousFamille.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ajoutSousFamille.Image")));
            this.toolStripButton_ajoutSousFamille.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ajoutSousFamille.Name = "toolStripButton_ajoutSousFamille";
            this.toolStripButton_ajoutSousFamille.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_ajoutSousFamille.Text = "Ajouter une sous famille";
            this.toolStripButton_ajoutSousFamille.Click += new System.EventHandler(this.toolStripButton_ajoutSousFamille_Click);
            // 
            // ApplicationSousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView_SousFamille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationSousFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Sous Famille";
            this.contextMenu_optionClicDroit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_SousFamille;
        private System.Windows.Forms.ContextMenuStrip contextMenu_optionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel_operation;
        private System.Windows.Forms.ToolStripButton toolStripButton_ajoutSousFamille;
    }
}
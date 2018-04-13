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
            this.listView_Famille = new System.Windows.Forms.ListView();
            this.contextMenu_optionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu_optionClicDroit.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Famille
            // 
            this.listView_Famille.FullRowSelect = true;
            this.listView_Famille.GridLines = true;
            this.listView_Famille.Location = new System.Drawing.Point(36, 43);
            this.listView_Famille.MultiSelect = false;
            this.listView_Famille.Name = "listView_Famille";
            this.listView_Famille.Size = new System.Drawing.Size(668, 379);
            this.listView_Famille.TabIndex = 0;
            this.listView_Famille.UseCompatibleStateImageBehavior = false;
            this.listView_Famille.View = System.Windows.Forms.View.Details;
            this.listView_Famille.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Famille_KeyDown);
            this.listView_Famille.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Famille_MouseClick);
            this.listView_Famille.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Famille_MouseDoubleClick);
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
            // ApplicationFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 443);
            this.Controls.Add(this.listView_Famille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationFamille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Famille";
            this.contextMenu_optionClicDroit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Famille;
        private System.Windows.Forms.ContextMenuStrip contextMenu_optionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
namespace Mercure.Vue
{
    partial class ApplicationMarque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationMarque));
            this.listView_Marque = new System.Windows.Forms.ListView();
            this.contextMenu_optionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripButton_ajoutMarque = new System.Windows.Forms.ToolStripButton();
            this.statuslabel_operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenu_optionClicDroit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Marque
            // 
            this.listView_Marque.FullRowSelect = true;
            this.listView_Marque.GridLines = true;
            this.listView_Marque.Location = new System.Drawing.Point(35, 28);
            this.listView_Marque.MultiSelect = false;
            this.listView_Marque.Name = "listView_Marque";
            this.listView_Marque.Size = new System.Drawing.Size(620, 423);
            this.listView_Marque.TabIndex = 0;
            this.listView_Marque.UseCompatibleStateImageBehavior = false;
            this.listView_Marque.View = System.Windows.Forms.View.Details;
            this.listView_Marque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_Marque_KeyDown);
            this.listView_Marque.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_Marque_MouseClick);
            this.listView_Marque.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Marque_MouseDoubleClick);
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
            this.toolStripButton_ajoutMarque});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel_operation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripButton_ajoutMarque
            // 
            this.toolStripButton_ajoutMarque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ajoutMarque.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ajoutMarque.Image")));
            this.toolStripButton_ajoutMarque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ajoutMarque.Name = "toolStripButton_ajoutMarque";
            this.toolStripButton_ajoutMarque.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton_ajoutMarque.Text = "Ajouter une marque";
            this.toolStripButton_ajoutMarque.Click += new System.EventHandler(this.toolStripButton_ajoutMarque_Click);
            // 
            // statuslabel_operation
            // 
            this.statuslabel_operation.ForeColor = System.Drawing.Color.Maroon;
            this.statuslabel_operation.Name = "statuslabel_operation";
            this.statuslabel_operation.Size = new System.Drawing.Size(58, 17);
            this.statuslabel_operation.Text = "Connecté";
            // 
            // ApplicationMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView_Marque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationMarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Marque";
            this.contextMenu_optionClicDroit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Marque;
        private System.Windows.Forms.ContextMenuStrip contextMenu_optionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_ajoutMarque;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel_operation;
    }
}
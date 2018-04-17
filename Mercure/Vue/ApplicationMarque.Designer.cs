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
            this.ListView_Marque = new System.Windows.Forms.ListView();
            this.ContextMenu_OptionClicDroit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_AjoutMarque = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel_Operation = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContextMenu_OptionClicDroit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView_Marque
            // 
            this.ListView_Marque.FullRowSelect = true;
            this.ListView_Marque.GridLines = true;
            this.ListView_Marque.Location = new System.Drawing.Point(35, 28);
            this.ListView_Marque.MultiSelect = false;
            this.ListView_Marque.Name = "ListView_Marque";
            this.ListView_Marque.Size = new System.Drawing.Size(620, 423);
            this.ListView_Marque.TabIndex = 0;
            this.ListView_Marque.UseCompatibleStateImageBehavior = false;
            this.ListView_Marque.View = System.Windows.Forms.View.Details;
            this.ListView_Marque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView_Marque_KeyDown);
            this.ListView_Marque.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Marque_MouseClick);
            this.ListView_Marque.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_Marque_MouseDoubleClick);
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_AjoutMarque});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(704, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton_AjoutMarque
            // 
            this.ToolStripButton_AjoutMarque.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton_AjoutMarque.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_AjoutMarque.Image")));
            this.ToolStripButton_AjoutMarque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_AjoutMarque.Name = "ToolStripButton_AjoutMarque";
            this.ToolStripButton_AjoutMarque.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_AjoutMarque.Text = "Ajouter une marque";
            this.ToolStripButton_AjoutMarque.Click += new System.EventHandler(this.ToolStripButton_AjoutMarque_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel_Operation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel_Operation
            // 
            this.StatusLabel_Operation.ForeColor = System.Drawing.Color.Maroon;
            this.StatusLabel_Operation.Name = "StatusLabel_Operation";
            this.StatusLabel_Operation.Size = new System.Drawing.Size(58, 17);
            this.StatusLabel_Operation.Text = "Connecté";
            // 
            // ApplicationMarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 473);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ListView_Marque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ApplicationMarque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Marque";
            this.ContextMenu_OptionClicDroit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Marque;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_OptionClicDroit;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton ToolStripButton_AjoutMarque;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel_Operation;
    }
}
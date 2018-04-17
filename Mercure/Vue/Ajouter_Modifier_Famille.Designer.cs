namespace Mercure.Vue
{
    partial class Ajouter_Modifier_Famille
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
            this.groupBox_Famille = new System.Windows.Forms.GroupBox();
            this.TextBox_NomFamille = new System.Windows.Forms.TextBox();
            this.Label_Nom_Famille = new System.Windows.Forms.Label();
            this.Button_Ajouter_Modifier = new System.Windows.Forms.Button();
            this.Button_Annuler = new System.Windows.Forms.Button();
            this.groupBox_Famille.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Famille
            // 
            this.groupBox_Famille.Controls.Add(this.TextBox_NomFamille);
            this.groupBox_Famille.Controls.Add(this.Label_Nom_Famille);
            this.groupBox_Famille.Location = new System.Drawing.Point(12, 24);
            this.groupBox_Famille.Name = "groupBox_Famille";
            this.groupBox_Famille.Size = new System.Drawing.Size(334, 170);
            this.groupBox_Famille.TabIndex = 0;
            this.groupBox_Famille.TabStop = false;
            // 
            // TextBox_NomFamille
            // 
            this.TextBox_NomFamille.Location = new System.Drawing.Point(151, 73);
            this.TextBox_NomFamille.Name = "TextBox_NomFamille";
            this.TextBox_NomFamille.Size = new System.Drawing.Size(134, 20);
            this.TextBox_NomFamille.TabIndex = 1;
            // 
            // Label_Nom_Famille
            // 
            this.Label_Nom_Famille.AutoSize = true;
            this.Label_Nom_Famille.Location = new System.Drawing.Point(27, 76);
            this.Label_Nom_Famille.Name = "Label_Nom_Famille";
            this.Label_Nom_Famille.Size = new System.Drawing.Size(64, 13);
            this.Label_Nom_Famille.TabIndex = 0;
            this.Label_Nom_Famille.Text = "Nom Famille";
            // 
            // Button_Ajouter_Modifier
            // 
            this.Button_Ajouter_Modifier.Location = new System.Drawing.Point(163, 213);
            this.Button_Ajouter_Modifier.Name = "Button_Ajouter_Modifier";
            this.Button_Ajouter_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Button_Ajouter_Modifier.TabIndex = 1;
            this.Button_Ajouter_Modifier.Text = "Ajouter";
            this.Button_Ajouter_Modifier.UseVisualStyleBackColor = true;
            this.Button_Ajouter_Modifier.Click += new System.EventHandler(this.Button_Ajouter_Modifier_Click);
            // 
            // Button_Annuler
            // 
            this.Button_Annuler.Location = new System.Drawing.Point(268, 213);
            this.Button_Annuler.Name = "Button_Annuler";
            this.Button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Button_Annuler.TabIndex = 2;
            this.Button_Annuler.Text = "Annuler";
            this.Button_Annuler.UseVisualStyleBackColor = true;
            this.Button_Annuler.Click += new System.EventHandler(this.Button_Annuler_Click);
            // 
            // Ajouter_Modifier_Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.Button_Annuler);
            this.Controls.Add(this.Button_Ajouter_Modifier);
            this.Controls.Add(this.groupBox_Famille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajouter_Modifier_Famille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox_Famille.ResumeLayout(false);
            this.groupBox_Famille.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Famille;
        private System.Windows.Forms.TextBox TextBox_NomFamille;
        private System.Windows.Forms.Label Label_Nom_Famille;
        private System.Windows.Forms.Button Button_Ajouter_Modifier;
        private System.Windows.Forms.Button Button_Annuler;
    }
}
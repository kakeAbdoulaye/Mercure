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
            this.textBox_nomfamille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ajouter_modifier = new System.Windows.Forms.Button();
            this.button_annuler = new System.Windows.Forms.Button();
            this.groupBox_Famille.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Famille
            // 
            this.groupBox_Famille.Controls.Add(this.textBox_nomfamille);
            this.groupBox_Famille.Controls.Add(this.label1);
            this.groupBox_Famille.Location = new System.Drawing.Point(12, 24);
            this.groupBox_Famille.Name = "groupBox_Famille";
            this.groupBox_Famille.Size = new System.Drawing.Size(334, 170);
            this.groupBox_Famille.TabIndex = 0;
            this.groupBox_Famille.TabStop = false;
            // 
            // textBox_nomfamille
            // 
            this.textBox_nomfamille.Location = new System.Drawing.Point(151, 73);
            this.textBox_nomfamille.Name = "textBox_nomfamille";
            this.textBox_nomfamille.Size = new System.Drawing.Size(134, 20);
            this.textBox_nomfamille.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Famille";
            // 
            // button_ajouter_modifier
            // 
            this.button_ajouter_modifier.Location = new System.Drawing.Point(163, 213);
            this.button_ajouter_modifier.Name = "button_ajouter_modifier";
            this.button_ajouter_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_modifier.TabIndex = 1;
            this.button_ajouter_modifier.Text = "Ajouter";
            this.button_ajouter_modifier.UseVisualStyleBackColor = true;
            this.button_ajouter_modifier.Click += new System.EventHandler(this.button_ajouter_modifier_Click);
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(268, 213);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 2;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // Ajouter_Modifier_Famille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.button_ajouter_modifier);
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
        private System.Windows.Forms.TextBox textBox_nomfamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ajouter_modifier;
        private System.Windows.Forms.Button button_annuler;
    }
}
namespace Mercure.Vue
{
    partial class Ajouter_Modifier_SousFamille
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
            this.groupBox_sousfamille = new System.Windows.Forms.GroupBox();
            this.label_typefamille = new System.Windows.Forms.Label();
            this.textBox_nomsousfamille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_typefamille = new System.Windows.Forms.ComboBox();
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_ajouter_modifier = new System.Windows.Forms.Button();
            this.groupBox_sousfamille.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_sousfamille
            // 
            this.groupBox_sousfamille.Controls.Add(this.label_typefamille);
            this.groupBox_sousfamille.Controls.Add(this.textBox_nomsousfamille);
            this.groupBox_sousfamille.Controls.Add(this.label1);
            this.groupBox_sousfamille.Controls.Add(this.comboBox_typefamille);
            this.groupBox_sousfamille.Location = new System.Drawing.Point(12, 12);
            this.groupBox_sousfamille.Name = "groupBox_sousfamille";
            this.groupBox_sousfamille.Size = new System.Drawing.Size(316, 215);
            this.groupBox_sousfamille.TabIndex = 0;
            this.groupBox_sousfamille.TabStop = false;
            // 
            // label_typefamille
            // 
            this.label_typefamille.AutoSize = true;
            this.label_typefamille.Location = new System.Drawing.Point(29, 116);
            this.label_typefamille.Name = "label_typefamille";
            this.label_typefamille.Size = new System.Drawing.Size(78, 13);
            this.label_typefamille.TabIndex = 3;
            this.label_typefamille.Text = "Type de famille";
            // 
            // textBox_nomsousfamille
            // 
            this.textBox_nomsousfamille.Location = new System.Drawing.Point(136, 40);
            this.textBox_nomsousfamille.Name = "textBox_nomsousfamille";
            this.textBox_nomsousfamille.Size = new System.Drawing.Size(174, 20);
            this.textBox_nomsousfamille.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom Sous Famille";
            // 
            // comboBox_typefamille
            // 
            this.comboBox_typefamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_typefamille.FormattingEnabled = true;
            this.comboBox_typefamille.Location = new System.Drawing.Point(136, 108);
            this.comboBox_typefamille.Name = "comboBox_typefamille";
            this.comboBox_typefamille.Size = new System.Drawing.Size(174, 21);
            this.comboBox_typefamille.TabIndex = 0;
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(244, 250);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 1;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_ajouter_modifier
            // 
            this.button_ajouter_modifier.Location = new System.Drawing.Point(137, 250);
            this.button_ajouter_modifier.Name = "button_ajouter_modifier";
            this.button_ajouter_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_modifier.TabIndex = 2;
            this.button_ajouter_modifier.Text = "Ajouter";
            this.button_ajouter_modifier.UseVisualStyleBackColor = true;
            this.button_ajouter_modifier.Click += new System.EventHandler(this.button_ajouter_modifier_Click);
            // 
            // Ajouter_Modifier_SousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 295);
            this.Controls.Add(this.button_ajouter_modifier);
            this.Controls.Add(this.button_annuler);
            this.Controls.Add(this.groupBox_sousfamille);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajouter_Modifier_SousFamille";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox_sousfamille.ResumeLayout(false);
            this.groupBox_sousfamille.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_sousfamille;
        private System.Windows.Forms.Label label_typefamille;
        private System.Windows.Forms.TextBox textBox_nomsousfamille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_typefamille;
        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Button button_ajouter_modifier;
    }
}
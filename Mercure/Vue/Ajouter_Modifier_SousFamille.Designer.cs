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
            this.Label_TypeFamille = new System.Windows.Forms.Label();
            this.TextBox_NomSousFamille = new System.Windows.Forms.TextBox();
            this.Label_NomSousFamille = new System.Windows.Forms.Label();
            this.ComboBox_TypeFamille = new System.Windows.Forms.ComboBox();
            this.Button_Annuler = new System.Windows.Forms.Button();
            this.Button_Ajouter_Modifier = new System.Windows.Forms.Button();
            this.groupBox_sousfamille.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_sousfamille
            // 
            this.groupBox_sousfamille.Controls.Add(this.Label_TypeFamille);
            this.groupBox_sousfamille.Controls.Add(this.TextBox_NomSousFamille);
            this.groupBox_sousfamille.Controls.Add(this.Label_NomSousFamille);
            this.groupBox_sousfamille.Controls.Add(this.ComboBox_TypeFamille);
            this.groupBox_sousfamille.Location = new System.Drawing.Point(12, 12);
            this.groupBox_sousfamille.Name = "groupBox_sousfamille";
            this.groupBox_sousfamille.Size = new System.Drawing.Size(316, 215);
            this.groupBox_sousfamille.TabIndex = 0;
            this.groupBox_sousfamille.TabStop = false;
            // 
            // Label_TypeFamille
            // 
            this.Label_TypeFamille.AutoSize = true;
            this.Label_TypeFamille.Location = new System.Drawing.Point(29, 116);
            this.Label_TypeFamille.Name = "Label_TypeFamille";
            this.Label_TypeFamille.Size = new System.Drawing.Size(78, 13);
            this.Label_TypeFamille.TabIndex = 3;
            this.Label_TypeFamille.Text = "Type de famille";
            // 
            // TextBox_NomSousFamille
            // 
            this.TextBox_NomSousFamille.Location = new System.Drawing.Point(136, 40);
            this.TextBox_NomSousFamille.Name = "TextBox_NomSousFamille";
            this.TextBox_NomSousFamille.Size = new System.Drawing.Size(174, 20);
            this.TextBox_NomSousFamille.TabIndex = 2;
            // 
            // Label_NomSousFamille
            // 
            this.Label_NomSousFamille.AutoSize = true;
            this.Label_NomSousFamille.Location = new System.Drawing.Point(16, 40);
            this.Label_NomSousFamille.Name = "Label_NomSousFamille";
            this.Label_NomSousFamille.Size = new System.Drawing.Size(91, 13);
            this.Label_NomSousFamille.TabIndex = 1;
            this.Label_NomSousFamille.Text = "Nom Sous Famille";
            // 
            // ComboBox_TypeFamille
            // 
            this.ComboBox_TypeFamille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_TypeFamille.FormattingEnabled = true;
            this.ComboBox_TypeFamille.Location = new System.Drawing.Point(136, 108);
            this.ComboBox_TypeFamille.Name = "ComboBox_TypeFamille";
            this.ComboBox_TypeFamille.Size = new System.Drawing.Size(174, 21);
            this.ComboBox_TypeFamille.TabIndex = 0;
            // 
            // Button_Annuler
            // 
            this.Button_Annuler.Location = new System.Drawing.Point(244, 250);
            this.Button_Annuler.Name = "Button_Annuler";
            this.Button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Button_Annuler.TabIndex = 1;
            this.Button_Annuler.Text = "Annuler";
            this.Button_Annuler.UseVisualStyleBackColor = true;
            this.Button_Annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // Button_Ajouter_Modifier
            // 
            this.Button_Ajouter_Modifier.Location = new System.Drawing.Point(137, 250);
            this.Button_Ajouter_Modifier.Name = "Button_Ajouter_Modifier";
            this.Button_Ajouter_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Button_Ajouter_Modifier.TabIndex = 2;
            this.Button_Ajouter_Modifier.Text = "Ajouter";
            this.Button_Ajouter_Modifier.UseVisualStyleBackColor = true;
            this.Button_Ajouter_Modifier.Click += new System.EventHandler(this.button_ajouter_modifier_Click);
            // 
            // Ajouter_Modifier_SousFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 295);
            this.Controls.Add(this.Button_Ajouter_Modifier);
            this.Controls.Add(this.Button_Annuler);
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
        private System.Windows.Forms.Label Label_TypeFamille;
        private System.Windows.Forms.TextBox TextBox_NomSousFamille;
        private System.Windows.Forms.Label Label_NomSousFamille;
        private System.Windows.Forms.ComboBox ComboBox_TypeFamille;
        private System.Windows.Forms.Button Button_Annuler;
        private System.Windows.Forms.Button Button_Ajouter_Modifier;
    }
}
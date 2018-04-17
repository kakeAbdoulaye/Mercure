namespace Mercure.Vue
{
    partial class Ajouter_Modifier_Marque
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
            this.Button_Annuler = new System.Windows.Forms.Button();
            this.Button_Ajouter_Modifier = new System.Windows.Forms.Button();
            this.groupBox_Marque = new System.Windows.Forms.GroupBox();
            this.TextBox_NomMarque = new System.Windows.Forms.TextBox();
            this.label_NomMarque = new System.Windows.Forms.Label();
            this.groupBox_Marque.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Annuler
            // 
            this.Button_Annuler.Location = new System.Drawing.Point(266, 226);
            this.Button_Annuler.Name = "Button_Annuler";
            this.Button_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Button_Annuler.TabIndex = 0;
            this.Button_Annuler.Text = "Annuler";
            this.Button_Annuler.UseVisualStyleBackColor = true;
            this.Button_Annuler.Click += new System.EventHandler(this.Button_Annuler_Click);
            // 
            // Button_Ajouter_Modifier
            // 
            this.Button_Ajouter_Modifier.Location = new System.Drawing.Point(152, 226);
            this.Button_Ajouter_Modifier.Name = "Button_Ajouter_Modifier";
            this.Button_Ajouter_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Button_Ajouter_Modifier.TabIndex = 1;
            this.Button_Ajouter_Modifier.Text = "Ajouter";
            this.Button_Ajouter_Modifier.UseVisualStyleBackColor = true;
            this.Button_Ajouter_Modifier.Click += new System.EventHandler(this.Button_Ajouter_Modifier_Click);
            // 
            // groupBox_Marque
            // 
            this.groupBox_Marque.Controls.Add(this.TextBox_NomMarque);
            this.groupBox_Marque.Controls.Add(this.label_NomMarque);
            this.groupBox_Marque.Location = new System.Drawing.Point(2, 24);
            this.groupBox_Marque.Name = "groupBox_Marque";
            this.groupBox_Marque.Size = new System.Drawing.Size(349, 187);
            this.groupBox_Marque.TabIndex = 2;
            this.groupBox_Marque.TabStop = false;
            // 
            // TextBox_NomMarque
            // 
            this.TextBox_NomMarque.Location = new System.Drawing.Point(120, 69);
            this.TextBox_NomMarque.Name = "TextBox_NomMarque";
            this.TextBox_NomMarque.Size = new System.Drawing.Size(151, 20);
            this.TextBox_NomMarque.TabIndex = 1;
            // 
            // label_NomMarque
            // 
            this.label_NomMarque.AutoSize = true;
            this.label_NomMarque.Location = new System.Drawing.Point(10, 69);
            this.label_NomMarque.Name = "label_NomMarque";
            this.label_NomMarque.Size = new System.Drawing.Size(71, 13);
            this.label_NomMarque.TabIndex = 0;
            this.label_NomMarque.Text = "Nom Marque ";
            // 
            // Ajouter_Modifier_Marque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.groupBox_Marque);
            this.Controls.Add(this.Button_Ajouter_Modifier);
            this.Controls.Add(this.Button_Annuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajouter_Modifier_Marque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox_Marque.ResumeLayout(false);
            this.groupBox_Marque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Annuler;
        private System.Windows.Forms.Button Button_Ajouter_Modifier;
        private System.Windows.Forms.GroupBox groupBox_Marque;
        private System.Windows.Forms.TextBox TextBox_NomMarque;
        private System.Windows.Forms.Label label_NomMarque;
    }
}
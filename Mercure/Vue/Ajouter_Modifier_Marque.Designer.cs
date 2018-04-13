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
            this.button_annuler = new System.Windows.Forms.Button();
            this.button_ajouter_modifier = new System.Windows.Forms.Button();
            this.groupBox_Marque = new System.Windows.Forms.GroupBox();
            this.textBox_nommarque = new System.Windows.Forms.TextBox();
            this.label_nommarque = new System.Windows.Forms.Label();
            this.groupBox_Marque.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_annuler
            // 
            this.button_annuler.Location = new System.Drawing.Point(266, 226);
            this.button_annuler.Name = "button_annuler";
            this.button_annuler.Size = new System.Drawing.Size(75, 23);
            this.button_annuler.TabIndex = 0;
            this.button_annuler.Text = "Annuler";
            this.button_annuler.UseVisualStyleBackColor = true;
            this.button_annuler.Click += new System.EventHandler(this.button_annuler_Click);
            // 
            // button_ajouter_modifier
            // 
            this.button_ajouter_modifier.Location = new System.Drawing.Point(152, 226);
            this.button_ajouter_modifier.Name = "button_ajouter_modifier";
            this.button_ajouter_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter_modifier.TabIndex = 1;
            this.button_ajouter_modifier.Text = "Ajouter";
            this.button_ajouter_modifier.UseVisualStyleBackColor = true;
            this.button_ajouter_modifier.Click += new System.EventHandler(this.button_ajouter_modifier_Click);
            // 
            // groupBox_Marque
            // 
            this.groupBox_Marque.Controls.Add(this.textBox_nommarque);
            this.groupBox_Marque.Controls.Add(this.label_nommarque);
            this.groupBox_Marque.Location = new System.Drawing.Point(2, 24);
            this.groupBox_Marque.Name = "groupBox_Marque";
            this.groupBox_Marque.Size = new System.Drawing.Size(349, 187);
            this.groupBox_Marque.TabIndex = 2;
            this.groupBox_Marque.TabStop = false;
            // 
            // textBox_nommarque
            // 
            this.textBox_nommarque.Location = new System.Drawing.Point(120, 69);
            this.textBox_nommarque.Name = "textBox_nommarque";
            this.textBox_nommarque.Size = new System.Drawing.Size(151, 20);
            this.textBox_nommarque.TabIndex = 1;
            // 
            // label_nommarque
            // 
            this.label_nommarque.AutoSize = true;
            this.label_nommarque.Location = new System.Drawing.Point(10, 69);
            this.label_nommarque.Name = "label_nommarque";
            this.label_nommarque.Size = new System.Drawing.Size(71, 13);
            this.label_nommarque.TabIndex = 0;
            this.label_nommarque.Text = "Nom Marque ";
            // 
            // Ajouter_Modifier_Marque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 261);
            this.Controls.Add(this.groupBox_Marque);
            this.Controls.Add(this.button_ajouter_modifier);
            this.Controls.Add(this.button_annuler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ajouter_Modifier_Marque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox_Marque.ResumeLayout(false);
            this.groupBox_Marque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_annuler;
        private System.Windows.Forms.Button button_ajouter_modifier;
        private System.Windows.Forms.GroupBox groupBox_Marque;
        private System.Windows.Forms.TextBox textBox_nommarque;
        private System.Windows.Forms.Label label_nommarque;
    }
}
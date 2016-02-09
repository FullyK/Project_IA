namespace ProjetIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Impasse = new System.Windows.Forms.Button();
            this.Depart = new System.Windows.Forms.TextBox();
            this.Arrive = new System.Windows.Forms.TextBox();
            this.Chemin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Impasse
            // 
            this.Impasse.Location = new System.Drawing.Point(12, 12);
            this.Impasse.Name = "Impasse";
            this.Impasse.Size = new System.Drawing.Size(75, 23);
            this.Impasse.TabIndex = 0;
            this.Impasse.Text = "Impasse(s)";
            this.Impasse.UseVisualStyleBackColor = true;
            this.Impasse.Click += new System.EventHandler(this.buttonImpasse_Click);
            // 
            // Depart
            // 
            this.Depart.Location = new System.Drawing.Point(13, 68);
            this.Depart.Name = "Depart";
            this.Depart.Size = new System.Drawing.Size(100, 20);
            this.Depart.TabIndex = 1;
            // 
            // Arrive
            // 
            this.Arrive.Location = new System.Drawing.Point(13, 111);
            this.Arrive.Name = "Arrive";
            this.Arrive.Size = new System.Drawing.Size(100, 20);
            this.Arrive.TabIndex = 2;
            // 
            // Chemin
            // 
            this.Chemin.Location = new System.Drawing.Point(12, 155);
            this.Chemin.Name = "Chemin";
            this.Chemin.Size = new System.Drawing.Size(75, 23);
            this.Chemin.TabIndex = 3;
            this.Chemin.Text = "Chemin";
            this.Chemin.UseVisualStyleBackColor = true;
            this.Chemin.Click += new System.EventHandler(this.Chemin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.Chemin);
            this.Controls.Add(this.Arrive);
            this.Controls.Add(this.Depart);
            this.Controls.Add(this.Impasse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Impasse;
        private System.Windows.Forms.TextBox Depart;
        private System.Windows.Forms.TextBox Arrive;
        private System.Windows.Forms.Button Chemin;
    }
}


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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EtapeLaiterie = new System.Windows.Forms.TextBox();
            this.CheminLaiterie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Impasse
            // 
            this.Impasse.Location = new System.Drawing.Point(6, 23);
            this.Impasse.Name = "Impasse";
            this.Impasse.Size = new System.Drawing.Size(75, 23);
            this.Impasse.TabIndex = 0;
            this.Impasse.Text = "Impasse(s)";
            this.Impasse.UseVisualStyleBackColor = true;
            this.Impasse.Click += new System.EventHandler(this.buttonImpasse_Click);
            // 
            // Depart
            // 
            this.Depart.Location = new System.Drawing.Point(30, 19);
            this.Depart.Name = "Depart";
            this.Depart.Size = new System.Drawing.Size(100, 20);
            this.Depart.TabIndex = 1;
            // 
            // Arrive
            // 
            this.Arrive.Location = new System.Drawing.Point(30, 62);
            this.Arrive.Name = "Arrive";
            this.Arrive.Size = new System.Drawing.Size(100, 20);
            this.Arrive.TabIndex = 2;
            // 
            // Chemin
            // 
            this.Chemin.Location = new System.Drawing.Point(29, 106);
            this.Chemin.Name = "Chemin";
            this.Chemin.Size = new System.Drawing.Size(75, 23);
            this.Chemin.TabIndex = 3;
            this.Chemin.Text = "Chemin";
            this.Chemin.UseVisualStyleBackColor = true;
            this.Chemin.Click += new System.EventHandler(this.Chemin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(427, 270);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Impasse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(419, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Question 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Chemin);
            this.tabPage2.Controls.Add(this.Depart);
            this.tabPage2.Controls.Add(this.Arrive);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(419, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Question 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CheminLaiterie);
            this.tabPage3.Controls.Add(this.EtapeLaiterie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(419, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Question 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EtapeLaiterie
            // 
            this.EtapeLaiterie.Location = new System.Drawing.Point(19, 31);
            this.EtapeLaiterie.Name = "EtapeLaiterie";
            this.EtapeLaiterie.Size = new System.Drawing.Size(100, 20);
            this.EtapeLaiterie.TabIndex = 0;
            // 
            // CheminLaiterie
            // 
            this.CheminLaiterie.Location = new System.Drawing.Point(19, 78);
            this.CheminLaiterie.Name = "CheminLaiterie";
            this.CheminLaiterie.Size = new System.Drawing.Size(124, 23);
            this.CheminLaiterie.TabIndex = 5;
            this.CheminLaiterie.Text = "Calcul du Chemin";
            this.CheminLaiterie.UseVisualStyleBackColor = true;
            this.CheminLaiterie.Click += new System.EventHandler(this.CheminLaiterie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 421);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Impasse;
        private System.Windows.Forms.TextBox Depart;
        private System.Windows.Forms.TextBox Arrive;
        private System.Windows.Forms.Button Chemin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox EtapeLaiterie;
        private System.Windows.Forms.Button CheminLaiterie;
    }
}


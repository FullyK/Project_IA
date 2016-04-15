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
            this.CheminLaiterie = new System.Windows.Forms.Button();
            this.EtapeLaiterie = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.CalculQuestion4 = new System.Windows.Forms.Button();
            this.etapeLaiterieRetour = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.colorationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.arbre = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Impasse
            // 
            this.Impasse.Location = new System.Drawing.Point(17, 23);
            this.Impasse.Name = "Impasse";
            this.Impasse.Size = new System.Drawing.Size(75, 23);
            this.Impasse.TabIndex = 0;
            this.Impasse.Text = "Impasse(s)";
            this.Impasse.UseVisualStyleBackColor = true;
            this.Impasse.Click += new System.EventHandler(this.buttonImpasse_Click);
            // 
            // Depart
            // 
            this.Depart.Location = new System.Drawing.Point(68, 19);
            this.Depart.Name = "Depart";
            this.Depart.Size = new System.Drawing.Size(100, 20);
            this.Depart.TabIndex = 1;
            // 
            // Arrive
            // 
            this.Arrive.Location = new System.Drawing.Point(68, 63);
            this.Arrive.Name = "Arrive";
            this.Arrive.Size = new System.Drawing.Size(100, 20);
            this.Arrive.TabIndex = 2;
            // 
            // Chemin
            // 
            this.Chemin.Location = new System.Drawing.Point(68, 104);
            this.Chemin.Name = "Chemin";
            this.Chemin.Size = new System.Drawing.Size(75, 23);
            this.Chemin.TabIndex = 3;
            this.Chemin.Text = "Chemin";
            this.Chemin.UseVisualStyleBackColor = true;
            this.Chemin.Click += new System.EventHandler(this.Chemin_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(385, 247);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Impasse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(377, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Question 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.arbre);
            this.tabPage2.Controls.Add(this.Chemin);
            this.tabPage2.Controls.Add(this.Depart);
            this.tabPage2.Controls.Add(this.Arrive);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(377, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Question 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.CheminLaiterie);
            this.tabPage3.Controls.Add(this.EtapeLaiterie);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(377, 221);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Question 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CheminLaiterie
            // 
            this.CheminLaiterie.Location = new System.Drawing.Point(99, 78);
            this.CheminLaiterie.Name = "CheminLaiterie";
            this.CheminLaiterie.Size = new System.Drawing.Size(124, 23);
            this.CheminLaiterie.TabIndex = 5;
            this.CheminLaiterie.Text = "Calcul du Chemin";
            this.CheminLaiterie.UseVisualStyleBackColor = true;
            this.CheminLaiterie.Click += new System.EventHandler(this.CheminLaiterie_Click);
            // 
            // EtapeLaiterie
            // 
            this.EtapeLaiterie.Location = new System.Drawing.Point(111, 40);
            this.EtapeLaiterie.Name = "EtapeLaiterie";
            this.EtapeLaiterie.Size = new System.Drawing.Size(100, 20);
            this.EtapeLaiterie.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.CalculQuestion4);
            this.tabPage4.Controls.Add(this.etapeLaiterieRetour);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(377, 221);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Question 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // CalculQuestion4
            // 
            this.CalculQuestion4.Location = new System.Drawing.Point(115, 66);
            this.CalculQuestion4.Name = "CalculQuestion4";
            this.CalculQuestion4.Size = new System.Drawing.Size(124, 23);
            this.CalculQuestion4.TabIndex = 7;
            this.CalculQuestion4.Text = "Calcul du Chemin";
            this.CalculQuestion4.UseVisualStyleBackColor = true;
            this.CalculQuestion4.Click += new System.EventHandler(this.CalculQuestion4_Click);
            // 
            // etapeLaiterieRetour
            // 
            this.etapeLaiterieRetour.Location = new System.Drawing.Point(126, 25);
            this.etapeLaiterieRetour.Name = "etapeLaiterieRetour";
            this.etapeLaiterieRetour.Size = new System.Drawing.Size(100, 20);
            this.etapeLaiterieRetour.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.colorationButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(377, 221);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Question 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // colorationButton
            // 
            this.colorationButton.Location = new System.Drawing.Point(22, 25);
            this.colorationButton.Name = "colorationButton";
            this.colorationButton.Size = new System.Drawing.Size(75, 23);
            this.colorationButton.TabIndex = 0;
            this.colorationButton.Text = "Coloration";
            this.colorationButton.UseVisualStyleBackColor = true;
            this.colorationButton.Click += new System.EventHandler(this.colorationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Note : Séparer les lettres par des virgules";
            // 
            // arbre
            // 
            this.arbre.Location = new System.Drawing.Point(174, 6);
            this.arbre.Name = "arbre";
            this.arbre.Size = new System.Drawing.Size(197, 198);
            this.arbre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Départ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Arrivé : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Listes des laiteries : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Listes des laiteries : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button CalculQuestion4;
        private System.Windows.Forms.TextBox etapeLaiterieRetour;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button colorationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView arbre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


namespace BlackJack
{
    partial class NouvellePartie
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
            this.CB_Joueurs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Risque1 = new System.Windows.Forms.ComboBox();
            this.CB_Risque2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_1Compte = new System.Windows.Forms.CheckBox();
            this.CB_2Compte = new System.Windows.Forms.CheckBox();
            this.BTN_Commencer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Joueurs
            // 
            this.CB_Joueurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Joueurs.FormattingEnabled = true;
            this.CB_Joueurs.Items.AddRange(new object[] {
            "Humain contre humain",
            "Humain contre IA",
            "IA contre IA"});
            this.CB_Joueurs.Location = new System.Drawing.Point(65, 6);
            this.CB_Joueurs.Name = "CB_Joueurs";
            this.CB_Joueurs.Size = new System.Drawing.Size(136, 21);
            this.CB_Joueurs.TabIndex = 0;
            this.CB_Joueurs.SelectedIndexChanged += new System.EventHandler(this.CB_Joueurs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Joueurs: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Risque IA 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Risque IA 2:";
            // 
            // CB_Risque1
            // 
            this.CB_Risque1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Risque1.Enabled = false;
            this.CB_Risque1.FormattingEnabled = true;
            this.CB_Risque1.Items.AddRange(new object[] {
            "Courageux",
            "Moyen",
            "Prudent"});
            this.CB_Risque1.Location = new System.Drawing.Point(80, 33);
            this.CB_Risque1.Name = "CB_Risque1";
            this.CB_Risque1.Size = new System.Drawing.Size(121, 21);
            this.CB_Risque1.TabIndex = 4;
            this.CB_Risque1.SelectedIndexChanged += new System.EventHandler(this.CB_Risque1_SelectedIndexChanged);
            // 
            // CB_Risque2
            // 
            this.CB_Risque2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Risque2.Enabled = false;
            this.CB_Risque2.FormattingEnabled = true;
            this.CB_Risque2.Items.AddRange(new object[] {
            "Courageux",
            "Moyen",
            "Prudent"});
            this.CB_Risque2.Location = new System.Drawing.Point(80, 60);
            this.CB_Risque2.Name = "CB_Risque2";
            this.CB_Risque2.Size = new System.Drawing.Size(121, 21);
            this.CB_Risque2.TabIndex = 5;
            this.CB_Risque2.SelectedIndexChanged += new System.EventHandler(this.CB_Risque2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IA 1 Compte: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "IA 2 Compte: ";
            // 
            // CB_1Compte
            // 
            this.CB_1Compte.AutoSize = true;
            this.CB_1Compte.Enabled = false;
            this.CB_1Compte.Location = new System.Drawing.Point(86, 87);
            this.CB_1Compte.Name = "CB_1Compte";
            this.CB_1Compte.Size = new System.Drawing.Size(105, 17);
            this.CB_1Compte.TabIndex = 8;
            this.CB_1Compte.Text = "Cochez pour Oui";
            this.CB_1Compte.UseVisualStyleBackColor = true;
            this.CB_1Compte.CheckedChanged += new System.EventHandler(this.CB_1Compte_CheckedChanged);
            // 
            // CB_2Compte
            // 
            this.CB_2Compte.AutoSize = true;
            this.CB_2Compte.Enabled = false;
            this.CB_2Compte.Location = new System.Drawing.Point(86, 110);
            this.CB_2Compte.Name = "CB_2Compte";
            this.CB_2Compte.Size = new System.Drawing.Size(105, 17);
            this.CB_2Compte.TabIndex = 9;
            this.CB_2Compte.Text = "Cochez pour Oui";
            this.CB_2Compte.UseVisualStyleBackColor = true;
            this.CB_2Compte.CheckedChanged += new System.EventHandler(this.CB_2Compte_CheckedChanged);
            // 
            // BTN_Commencer
            // 
            this.BTN_Commencer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTN_Commencer.Enabled = false;
            this.BTN_Commencer.Location = new System.Drawing.Point(27, 191);
            this.BTN_Commencer.Name = "BTN_Commencer";
            this.BTN_Commencer.Size = new System.Drawing.Size(164, 23);
            this.BTN_Commencer.TabIndex = 10;
            this.BTN_Commencer.Text = "Commencer la partie";
            this.BTN_Commencer.UseVisualStyleBackColor = true;
            // 
            // NouvellePartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 247);
            this.Controls.Add(this.BTN_Commencer);
            this.Controls.Add(this.CB_2Compte);
            this.Controls.Add(this.CB_1Compte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CB_Risque2);
            this.Controls.Add(this.CB_Risque1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Joueurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NouvellePartie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle Partie...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Joueurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Risque1;
        private System.Windows.Forms.ComboBox CB_Risque2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CB_1Compte;
        private System.Windows.Forms.CheckBox CB_2Compte;
        private System.Windows.Forms.Button BTN_Commencer;
    }
}
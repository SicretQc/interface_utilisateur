namespace Travail_Pratique_1
{
    partial class frm_Ecran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Choix_Cours = new Label();
            cbx_Choix_Cours = new ComboBox();
            lbl_Nb_Etudiants = new Label();
            tbx_Nb_Etudiants = new TextBox();
            btn_Quitter = new Button();
            tcl_Menu = new TabControl();
            tbp_Cours = new TabPage();
            lbl_Evaluation = new Label();
            lbl_Gestion = new Label();
            pbx_Ecole = new PictureBox();
            tbp_Etudiant = new TabPage();
            tbp_Cahier = new TabPage();
            tbx_Prenom_Etudiant = new TextBox();
            tbx_Nom_Etudiant = new TextBox();
            dtx_Date_Naissance = new DateTimePicker();
            tbx_Code_Permanent = new TextBox();
            tbx_age = new TextBox();
            tcl_Menu.SuspendLayout();
            tbp_Cours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Ecole).BeginInit();
            tbp_Etudiant.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Choix_Cours
            // 
            lbl_Choix_Cours.AutoSize = true;
            lbl_Choix_Cours.Location = new Point(68, 75);
            lbl_Choix_Cours.Name = "lbl_Choix_Cours";
            lbl_Choix_Cours.Size = new Size(86, 15);
            lbl_Choix_Cours.TabIndex = 1;
            lbl_Choix_Cours.Text = "Choix du cours";
            // 
            // cbx_Choix_Cours
            // 
            cbx_Choix_Cours.FormattingEnabled = true;
            cbx_Choix_Cours.Items.AddRange(new object[] { "420-3D4-Interface utilisateur", "420-3E5-Interface Web" });
            cbx_Choix_Cours.Location = new Point(302, 78);
            cbx_Choix_Cours.Name = "cbx_Choix_Cours";
            cbx_Choix_Cours.Size = new Size(121, 23);
            cbx_Choix_Cours.TabIndex = 2;
            // 
            // lbl_Nb_Etudiants
            // 
            lbl_Nb_Etudiants.AutoSize = true;
            lbl_Nb_Etudiants.Location = new Point(41, 369);
            lbl_Nb_Etudiants.Name = "lbl_Nb_Etudiants";
            lbl_Nb_Etudiants.Size = new Size(113, 15);
            lbl_Nb_Etudiants.TabIndex = 3;
            lbl_Nb_Etudiants.Text = "Nombre d'étudiants";
            // 
            // tbx_Nb_Etudiants
            // 
            tbx_Nb_Etudiants.Location = new Point(194, 366);
            tbx_Nb_Etudiants.Name = "tbx_Nb_Etudiants";
            tbx_Nb_Etudiants.Size = new Size(100, 23);
            tbx_Nb_Etudiants.TabIndex = 4;
            // 
            // btn_Quitter
            // 
            btn_Quitter.Location = new Point(437, 367);
            btn_Quitter.Name = "btn_Quitter";
            btn_Quitter.Size = new Size(75, 23);
            btn_Quitter.TabIndex = 5;
            btn_Quitter.Text = "Quitter";
            btn_Quitter.UseVisualStyleBackColor = true;
            // 
            // tcl_Menu
            // 
            tcl_Menu.Controls.Add(tbp_Cours);
            tcl_Menu.Controls.Add(tbp_Etudiant);
            tcl_Menu.Controls.Add(tbp_Cahier);
            tcl_Menu.Location = new Point(68, 141);
            tcl_Menu.Name = "tcl_Menu";
            tcl_Menu.SelectedIndex = 0;
            tcl_Menu.Size = new Size(397, 176);
            tcl_Menu.TabIndex = 6;
            // 
            // tbp_Cours
            // 
            tbp_Cours.Controls.Add(lbl_Evaluation);
            tbp_Cours.Controls.Add(lbl_Gestion);
            tbp_Cours.Controls.Add(pbx_Ecole);
            tbp_Cours.Location = new Point(4, 24);
            tbp_Cours.Name = "tbp_Cours";
            tbp_Cours.Padding = new Padding(3);
            tbp_Cours.Size = new Size(389, 148);
            tbp_Cours.TabIndex = 0;
            tbp_Cours.Text = "Cours";
            tbp_Cours.UseVisualStyleBackColor = true;
            // 
            // lbl_Evaluation
            // 
            lbl_Evaluation.AutoSize = true;
            lbl_Evaluation.Location = new Point(260, 8);
            lbl_Evaluation.Name = "lbl_Evaluation";
            lbl_Evaluation.Size = new Size(115, 15);
            lbl_Evaluation.TabIndex = 2;
            lbl_Evaluation.Text = "Évaluations de cours";
            // 
            // lbl_Gestion
            // 
            lbl_Gestion.AutoSize = true;
            lbl_Gestion.Location = new Point(18, 88);
            lbl_Gestion.Name = "lbl_Gestion";
            lbl_Gestion.Size = new Size(309, 15);
            lbl_Gestion.TabIndex = 1;
            lbl_Gestion.Text = " Gestion des évaluations pour le cours [cours sélectionné]";
            // 
            // pbx_Ecole
            // 
            pbx_Ecole.Location = new Point(18, 25);
            pbx_Ecole.Name = "pbx_Ecole";
            pbx_Ecole.Size = new Size(100, 50);
            pbx_Ecole.TabIndex = 0;
            pbx_Ecole.TabStop = false;
            // 
            // tbp_Etudiant
            // 
            tbp_Etudiant.Controls.Add(tbx_age);
            tbp_Etudiant.Controls.Add(tbx_Code_Permanent);
            tbp_Etudiant.Controls.Add(dtx_Date_Naissance);
            tbp_Etudiant.Controls.Add(tbx_Nom_Etudiant);
            tbp_Etudiant.Controls.Add(tbx_Prenom_Etudiant);
            tbp_Etudiant.Location = new Point(4, 24);
            tbp_Etudiant.Name = "tbp_Etudiant";
            tbp_Etudiant.Padding = new Padding(3);
            tbp_Etudiant.Size = new Size(389, 148);
            tbp_Etudiant.TabIndex = 1;
            tbp_Etudiant.Text = "Étudiant";
            tbp_Etudiant.UseVisualStyleBackColor = true;
            // 
            // tbp_Cahier
            // 
            tbp_Cahier.Location = new Point(4, 24);
            tbp_Cahier.Name = "tbp_Cahier";
            tbp_Cahier.Padding = new Padding(3);
            tbp_Cahier.Size = new Size(389, 148);
            tbp_Cahier.TabIndex = 2;
            tbp_Cahier.Text = "Cahier de notes";
            tbp_Cahier.UseVisualStyleBackColor = true;
            // 
            // tbx_Prenom_Etudiant
            // 
            tbx_Prenom_Etudiant.Location = new Point(151, 23);
            tbx_Prenom_Etudiant.Name = "tbx_Prenom_Etudiant";
            tbx_Prenom_Etudiant.Size = new Size(100, 23);
            tbx_Prenom_Etudiant.TabIndex = 0;
            // 
            // tbx_Nom_Etudiant
            // 
            tbx_Nom_Etudiant.Location = new Point(151, 52);
            tbx_Nom_Etudiant.Name = "tbx_Nom_Etudiant";
            tbx_Nom_Etudiant.Size = new Size(100, 23);
            tbx_Nom_Etudiant.TabIndex = 1;
            // 
            // dtx_Date_Naissance
            // 
            dtx_Date_Naissance.Location = new Point(151, 81);
            dtx_Date_Naissance.Name = "dtx_Date_Naissance";
            dtx_Date_Naissance.Size = new Size(200, 23);
            dtx_Date_Naissance.TabIndex = 2;
            // 
            // tbx_Code_Permanent
            // 
            tbx_Code_Permanent.Location = new Point(27, 34);
            tbx_Code_Permanent.Name = "tbx_Code_Permanent";
            tbx_Code_Permanent.Size = new Size(100, 23);
            tbx_Code_Permanent.TabIndex = 3;
            // 
            // tbx_age
            // 
            tbx_age.Location = new Point(26, 81);
            tbx_age.Name = "tbx_age";
            tbx_age.Size = new Size(100, 23);
            tbx_age.TabIndex = 4;
            // 
            // frm_Ecran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcl_Menu);
            Controls.Add(btn_Quitter);
            Controls.Add(tbx_Nb_Etudiants);
            Controls.Add(lbl_Nb_Etudiants);
            Controls.Add(cbx_Choix_Cours);
            Controls.Add(lbl_Choix_Cours);
            Name = "frm_Ecran";
            Text = "Collège - Charles Guernon";
            tcl_Menu.ResumeLayout(false);
            tbp_Cours.ResumeLayout(false);
            tbp_Cours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Ecole).EndInit();
            tbp_Etudiant.ResumeLayout(false);
            tbp_Etudiant.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lbl_Choix_Cours;
        private ComboBox cbx_Choix_Cours;
        private Label lbl_Nb_Etudiants;
        private TextBox tbx_Nb_Etudiants;
        private Button btn_Quitter;
        private TabControl tcl_Menu;
        private TabPage tbp_Cours;
        private TabPage tbp_Etudiant;
        private TabPage tbp_Cahier;
        private PictureBox pbx_Ecole;
        private Label lbl_Gestion;
        private Label lbl_Evaluation;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox tbx_Code_Permanent;
        private DateTimePicker dtx_Date_Naissance;
        private TextBox tbx_Nom_Etudiant;
        private TextBox tbx_Prenom_Etudiant;
        private TextBox tbx_age;
    }
}

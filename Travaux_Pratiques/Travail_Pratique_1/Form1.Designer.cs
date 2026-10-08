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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ecran));
            lbl_Choix_Cours = new Label();
            cbx_Choix_Cours = new ComboBox();
            lbl_Nb_Etudiants = new Label();
            tbx_Nb_Etudiants = new TextBox();
            btn_Quitter = new Button();
            tcl_Menu = new TabControl();
            tbp_Cours = new TabPage();
            btn_Valider = new Button();
            btn_Modifier = new Button();
            tbx_Eval5 = new TextBox();
            tbx_Eval4 = new TextBox();
            tbx_Eval3 = new TextBox();
            tbx_Eval2 = new TextBox();
            tbx_Eval1 = new TextBox();
            lbl_Evaluation = new Label();
            lbl_Gestion = new Label();
            pbx_Ecole = new PictureBox();
            tbp_Etudiant = new TabPage();
            tbx_CoursEtu5 = new TextBox();
            tbx_CoursEtu4 = new TextBox();
            tbx_CoursEtu3 = new TextBox();
            tbx_CoursEtu2 = new TextBox();
            tbx_CoursEtu1 = new TextBox();
            Résultats = new Label();
            nud_Cours5 = new NumericUpDown();
            nud_Cours4 = new NumericUpDown();
            nud_Cours3 = new NumericUpDown();
            nud_Cours2 = new NumericUpDown();
            nud_Cours1 = new NumericUpDown();
            lbl_DateNaissance = new Label();
            lbl_Nom = new Label();
            lbl_Prenom = new Label();
            pbx_Eleve = new PictureBox();
            lbl_CodePermanent = new Label();
            lbl_Age = new Label();
            btn_Sauvegarder = new Button();
            btn_Effacer = new Button();
            tbx_age = new TextBox();
            tbx_Code_Permanent = new TextBox();
            dtx_Date_Naissance = new DateTimePicker();
            tbx_Nom_Etudiant = new TextBox();
            tbx_Prenom_Etudiant = new TextBox();
            tbp_Cahier = new TabPage();
            lbl_Echec_Reussi = new Label();
            btn_SupprimerEtu = new Button();
            lbx_Etudiant = new ListBox();
            pbx_Cahier = new PictureBox();
            rtb_Moyenne = new RichTextBox();
            lbl_Moyenne = new Label();
            tbx_EvalCahier5 = new TextBox();
            tbx_EvalCahier4 = new TextBox();
            tbx_EvalCahier3 = new TextBox();
            tbx_EvalCahier2 = new TextBox();
            tbx_EvalCahier1 = new TextBox();
            rtb_Finale = new RichTextBox();
            lbl_NoteFinale = new Label();
            lbl_ResultatCahier = new Label();
            lbl_Note = new Label();
            rtb_Note5 = new RichTextBox();
            rtb_Note4 = new RichTextBox();
            rtb_Note3 = new RichTextBox();
            rtb_Note2 = new RichTextBox();
            rtb_Note1 = new RichTextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            tcl_Menu.SuspendLayout();
            tbp_Cours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Ecole).BeginInit();
            tbp_Etudiant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Cours5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Eleve).BeginInit();
            tbp_Cahier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Cahier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            SuspendLayout();
            // 
            // lbl_Choix_Cours
            // 
            lbl_Choix_Cours.AutoSize = true;
            lbl_Choix_Cours.Location = new Point(72, 20);
            lbl_Choix_Cours.Name = "lbl_Choix_Cours";
            lbl_Choix_Cours.Size = new Size(86, 15);
            lbl_Choix_Cours.TabIndex = 1;
            lbl_Choix_Cours.Text = "Choix du cours";
            // 
            // cbx_Choix_Cours
            // 
            cbx_Choix_Cours.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_Choix_Cours.FormattingEnabled = true;
            cbx_Choix_Cours.Location = new Point(355, 12);
            cbx_Choix_Cours.Name = "cbx_Choix_Cours";
            cbx_Choix_Cours.Size = new Size(273, 23);
            cbx_Choix_Cours.TabIndex = 2;
            cbx_Choix_Cours.SelectedIndexChanged += cbx_Choix_Cours_SelectedIndexChanged;
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
            tbx_Nb_Etudiants.Enabled = false;
            tbx_Nb_Etudiants.Location = new Point(194, 366);
            tbx_Nb_Etudiants.Name = "tbx_Nb_Etudiants";
            tbx_Nb_Etudiants.Size = new Size(100, 23);
            tbx_Nb_Etudiants.TabIndex = 4;
            tbx_Nb_Etudiants.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Quitter
            // 
            btn_Quitter.Location = new Point(437, 367);
            btn_Quitter.Name = "btn_Quitter";
            btn_Quitter.Size = new Size(75, 23);
            btn_Quitter.TabIndex = 5;
            btn_Quitter.Text = "Quitter";
            btn_Quitter.UseVisualStyleBackColor = true;
            btn_Quitter.Click += btn_Quitter_Click;
            // 
            // tcl_Menu
            // 
            tcl_Menu.Controls.Add(tbp_Cours);
            tcl_Menu.Controls.Add(tbp_Etudiant);
            tcl_Menu.Controls.Add(tbp_Cahier);
            tcl_Menu.Location = new Point(68, 69);
            tcl_Menu.Name = "tcl_Menu";
            tcl_Menu.SelectedIndex = 0;
            tcl_Menu.Size = new Size(564, 275);
            tcl_Menu.TabIndex = 6;
            // 
            // tbp_Cours
            // 
            tbp_Cours.Controls.Add(btn_Valider);
            tbp_Cours.Controls.Add(btn_Modifier);
            tbp_Cours.Controls.Add(tbx_Eval5);
            tbp_Cours.Controls.Add(tbx_Eval4);
            tbp_Cours.Controls.Add(tbx_Eval3);
            tbp_Cours.Controls.Add(tbx_Eval2);
            tbp_Cours.Controls.Add(tbx_Eval1);
            tbp_Cours.Controls.Add(lbl_Evaluation);
            tbp_Cours.Controls.Add(lbl_Gestion);
            tbp_Cours.Controls.Add(pbx_Ecole);
            tbp_Cours.Location = new Point(4, 24);
            tbp_Cours.Name = "tbp_Cours";
            tbp_Cours.Padding = new Padding(3);
            tbp_Cours.Size = new Size(556, 247);
            tbp_Cours.TabIndex = 0;
            tbp_Cours.Text = "Cours";
            tbp_Cours.UseVisualStyleBackColor = true;
            // 
            // btn_Valider
            // 
            btn_Valider.Location = new Point(440, 209);
            btn_Valider.Name = "btn_Valider";
            btn_Valider.Size = new Size(75, 23);
            btn_Valider.TabIndex = 9;
            btn_Valider.Text = "Valider";
            btn_Valider.UseVisualStyleBackColor = true;
            btn_Valider.Click += btn_Valider_Click;
            // 
            // btn_Modifier
            // 
            btn_Modifier.Location = new Point(353, 210);
            btn_Modifier.Name = "btn_Modifier";
            btn_Modifier.Size = new Size(75, 23);
            btn_Modifier.TabIndex = 8;
            btn_Modifier.Text = "Modifier";
            btn_Modifier.UseVisualStyleBackColor = true;
            btn_Modifier.Click += btn_Modifier_Click;
            // 
            // tbx_Eval5
            // 
            tbx_Eval5.Enabled = false;
            tbx_Eval5.Location = new Point(410, 160);
            tbx_Eval5.Name = "tbx_Eval5";
            tbx_Eval5.Size = new Size(100, 23);
            tbx_Eval5.TabIndex = 7;
            // 
            // tbx_Eval4
            // 
            tbx_Eval4.Enabled = false;
            tbx_Eval4.Location = new Point(410, 131);
            tbx_Eval4.Name = "tbx_Eval4";
            tbx_Eval4.Size = new Size(100, 23);
            tbx_Eval4.TabIndex = 6;
            // 
            // tbx_Eval3
            // 
            tbx_Eval3.Enabled = false;
            tbx_Eval3.Location = new Point(410, 102);
            tbx_Eval3.Name = "tbx_Eval3";
            tbx_Eval3.Size = new Size(100, 23);
            tbx_Eval3.TabIndex = 5;
            // 
            // tbx_Eval2
            // 
            tbx_Eval2.Enabled = false;
            tbx_Eval2.Location = new Point(410, 73);
            tbx_Eval2.Name = "tbx_Eval2";
            tbx_Eval2.Size = new Size(100, 23);
            tbx_Eval2.TabIndex = 4;
            // 
            // tbx_Eval1
            // 
            tbx_Eval1.Enabled = false;
            tbx_Eval1.Location = new Point(410, 44);
            tbx_Eval1.Name = "tbx_Eval1";
            tbx_Eval1.Size = new Size(100, 23);
            tbx_Eval1.TabIndex = 3;
            // 
            // lbl_Evaluation
            // 
            lbl_Evaluation.AutoSize = true;
            lbl_Evaluation.Location = new Point(410, 16);
            lbl_Evaluation.Name = "lbl_Evaluation";
            lbl_Evaluation.Size = new Size(115, 15);
            lbl_Evaluation.TabIndex = 2;
            lbl_Evaluation.Text = "Évaluations de cours";
            // 
            // lbl_Gestion
            // 
            lbl_Gestion.Location = new Point(38, 164);
            lbl_Gestion.Name = "lbl_Gestion";
            lbl_Gestion.Size = new Size(184, 70);
            lbl_Gestion.TabIndex = 1;
            lbl_Gestion.Text = " Gestion des évaluations pour le cours [cours sélectionné]";
            lbl_Gestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbx_Ecole
            // 
            pbx_Ecole.BackgroundImage = (Image)resources.GetObject("pbx_Ecole.BackgroundImage");
            pbx_Ecole.BackgroundImageLayout = ImageLayout.Stretch;
            pbx_Ecole.Location = new Point(53, 16);
            pbx_Ecole.Name = "pbx_Ecole";
            pbx_Ecole.Size = new Size(153, 145);
            pbx_Ecole.TabIndex = 0;
            pbx_Ecole.TabStop = false;
            // 
            // tbp_Etudiant
            // 
            tbp_Etudiant.Controls.Add(tbx_CoursEtu5);
            tbp_Etudiant.Controls.Add(tbx_CoursEtu4);
            tbp_Etudiant.Controls.Add(tbx_CoursEtu3);
            tbp_Etudiant.Controls.Add(tbx_CoursEtu2);
            tbp_Etudiant.Controls.Add(tbx_CoursEtu1);
            tbp_Etudiant.Controls.Add(Résultats);
            tbp_Etudiant.Controls.Add(nud_Cours5);
            tbp_Etudiant.Controls.Add(nud_Cours4);
            tbp_Etudiant.Controls.Add(nud_Cours3);
            tbp_Etudiant.Controls.Add(nud_Cours2);
            tbp_Etudiant.Controls.Add(nud_Cours1);
            tbp_Etudiant.Controls.Add(lbl_DateNaissance);
            tbp_Etudiant.Controls.Add(lbl_Nom);
            tbp_Etudiant.Controls.Add(lbl_Prenom);
            tbp_Etudiant.Controls.Add(pbx_Eleve);
            tbp_Etudiant.Controls.Add(lbl_CodePermanent);
            tbp_Etudiant.Controls.Add(lbl_Age);
            tbp_Etudiant.Controls.Add(btn_Sauvegarder);
            tbp_Etudiant.Controls.Add(btn_Effacer);
            tbp_Etudiant.Controls.Add(tbx_age);
            tbp_Etudiant.Controls.Add(tbx_Code_Permanent);
            tbp_Etudiant.Controls.Add(dtx_Date_Naissance);
            tbp_Etudiant.Controls.Add(tbx_Nom_Etudiant);
            tbp_Etudiant.Controls.Add(tbx_Prenom_Etudiant);
            tbp_Etudiant.Location = new Point(4, 24);
            tbp_Etudiant.Name = "tbp_Etudiant";
            tbp_Etudiant.Padding = new Padding(3);
            tbp_Etudiant.Size = new Size(556, 247);
            tbp_Etudiant.TabIndex = 1;
            tbp_Etudiant.Text = "Étudiant";
            tbp_Etudiant.UseVisualStyleBackColor = true;
            // 
            // tbx_CoursEtu5
            // 
            tbx_CoursEtu5.Enabled = false;
            tbx_CoursEtu5.Location = new Point(331, 161);
            tbx_CoursEtu5.Name = "tbx_CoursEtu5";
            tbx_CoursEtu5.Size = new Size(100, 23);
            tbx_CoursEtu5.TabIndex = 23;
            // 
            // tbx_CoursEtu4
            // 
            tbx_CoursEtu4.Enabled = false;
            tbx_CoursEtu4.Location = new Point(331, 132);
            tbx_CoursEtu4.Name = "tbx_CoursEtu4";
            tbx_CoursEtu4.Size = new Size(100, 23);
            tbx_CoursEtu4.TabIndex = 22;
            // 
            // tbx_CoursEtu3
            // 
            tbx_CoursEtu3.Enabled = false;
            tbx_CoursEtu3.Location = new Point(331, 103);
            tbx_CoursEtu3.Name = "tbx_CoursEtu3";
            tbx_CoursEtu3.Size = new Size(100, 23);
            tbx_CoursEtu3.TabIndex = 21;
            // 
            // tbx_CoursEtu2
            // 
            tbx_CoursEtu2.Enabled = false;
            tbx_CoursEtu2.Location = new Point(331, 74);
            tbx_CoursEtu2.Name = "tbx_CoursEtu2";
            tbx_CoursEtu2.Size = new Size(100, 23);
            tbx_CoursEtu2.TabIndex = 20;
            // 
            // tbx_CoursEtu1
            // 
            tbx_CoursEtu1.Enabled = false;
            tbx_CoursEtu1.Location = new Point(331, 44);
            tbx_CoursEtu1.Name = "tbx_CoursEtu1";
            tbx_CoursEtu1.Size = new Size(100, 23);
            tbx_CoursEtu1.TabIndex = 19;
            // 
            // Résultats
            // 
            Résultats.AutoSize = true;
            Résultats.Location = new Point(361, 13);
            Résultats.Name = "Résultats";
            Résultats.Size = new Size(54, 15);
            Résultats.TabIndex = 18;
            Résultats.Text = "Résultats";
            // 
            // nud_Cours5
            // 
            nud_Cours5.Location = new Point(451, 161);
            nud_Cours5.Name = "nud_Cours5";
            nud_Cours5.Size = new Size(82, 23);
            nud_Cours5.TabIndex = 17;
            // 
            // nud_Cours4
            // 
            nud_Cours4.Location = new Point(451, 133);
            nud_Cours4.Name = "nud_Cours4";
            nud_Cours4.Size = new Size(82, 23);
            nud_Cours4.TabIndex = 16;
            // 
            // nud_Cours3
            // 
            nud_Cours3.Location = new Point(451, 103);
            nud_Cours3.Name = "nud_Cours3";
            nud_Cours3.Size = new Size(82, 23);
            nud_Cours3.TabIndex = 15;
            // 
            // nud_Cours2
            // 
            nud_Cours2.Location = new Point(451, 73);
            nud_Cours2.Name = "nud_Cours2";
            nud_Cours2.Size = new Size(82, 23);
            nud_Cours2.TabIndex = 14;
            // 
            // nud_Cours1
            // 
            nud_Cours1.Location = new Point(451, 44);
            nud_Cours1.Name = "nud_Cours1";
            nud_Cours1.Size = new Size(82, 23);
            nud_Cours1.TabIndex = 13;
            // 
            // lbl_DateNaissance
            // 
            lbl_DateNaissance.AutoSize = true;
            lbl_DateNaissance.Location = new Point(153, 128);
            lbl_DateNaissance.Name = "lbl_DateNaissance";
            lbl_DateNaissance.Size = new Size(101, 15);
            lbl_DateNaissance.TabIndex = 12;
            lbl_DateNaissance.Text = "Date de naissance";
            // 
            // lbl_Nom
            // 
            lbl_Nom.AutoSize = true;
            lbl_Nom.Location = new Point(161, 82);
            lbl_Nom.Name = "lbl_Nom";
            lbl_Nom.Size = new Size(34, 15);
            lbl_Nom.TabIndex = 11;
            lbl_Nom.Text = "Nom";
            // 
            // lbl_Prenom
            // 
            lbl_Prenom.AutoSize = true;
            lbl_Prenom.Location = new Point(150, 23);
            lbl_Prenom.Name = "lbl_Prenom";
            lbl_Prenom.Size = new Size(49, 15);
            lbl_Prenom.TabIndex = 10;
            lbl_Prenom.Text = "Prenom";
            // 
            // pbx_Eleve
            // 
            pbx_Eleve.BackgroundImage = (Image)resources.GetObject("pbx_Eleve.BackgroundImage");
            pbx_Eleve.BackgroundImageLayout = ImageLayout.Stretch;
            pbx_Eleve.Location = new Point(21, 13);
            pbx_Eleve.Name = "pbx_Eleve";
            pbx_Eleve.Size = new Size(99, 103);
            pbx_Eleve.TabIndex = 9;
            pbx_Eleve.TabStop = false;
            // 
            // lbl_CodePermanent
            // 
            lbl_CodePermanent.AutoSize = true;
            lbl_CodePermanent.Location = new Point(24, 119);
            lbl_CodePermanent.Name = "lbl_CodePermanent";
            lbl_CodePermanent.Size = new Size(96, 15);
            lbl_CodePermanent.TabIndex = 8;
            lbl_CodePermanent.Text = "Code permanent";
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize = true;
            lbl_Age.Location = new Point(34, 182);
            lbl_Age.Name = "lbl_Age";
            lbl_Age.Size = new Size(28, 15);
            lbl_Age.TabIndex = 7;
            lbl_Age.Text = "Âge";
            // 
            // btn_Sauvegarder
            // 
            btn_Sauvegarder.Enabled = false;
            btn_Sauvegarder.Location = new Point(442, 218);
            btn_Sauvegarder.Name = "btn_Sauvegarder";
            btn_Sauvegarder.Size = new Size(91, 23);
            btn_Sauvegarder.TabIndex = 6;
            btn_Sauvegarder.Text = "Sauvegarder";
            btn_Sauvegarder.UseVisualStyleBackColor = true;
            btn_Sauvegarder.Click += btn_Sauvegarder_Click;
            // 
            // btn_Effacer
            // 
            btn_Effacer.Location = new Point(356, 218);
            btn_Effacer.Name = "btn_Effacer";
            btn_Effacer.Size = new Size(75, 23);
            btn_Effacer.TabIndex = 5;
            btn_Effacer.Text = "Effacer";
            btn_Effacer.UseVisualStyleBackColor = true;
            btn_Effacer.Click += btn_Effacer_Click;
            // 
            // tbx_age
            // 
            tbx_age.Enabled = false;
            tbx_age.Location = new Point(27, 198);
            tbx_age.Name = "tbx_age";
            tbx_age.Size = new Size(100, 23);
            tbx_age.TabIndex = 4;
            tbx_age.Text = "0";
            // 
            // tbx_Code_Permanent
            // 
            tbx_Code_Permanent.Enabled = false;
            tbx_Code_Permanent.Location = new Point(27, 145);
            tbx_Code_Permanent.Name = "tbx_Code_Permanent";
            tbx_Code_Permanent.Size = new Size(100, 23);
            tbx_Code_Permanent.TabIndex = 3;
            tbx_Code_Permanent.Text = "XXXX999999";
            // 
            // dtx_Date_Naissance
            // 
            dtx_Date_Naissance.Format = DateTimePickerFormat.Short;
            dtx_Date_Naissance.Location = new Point(150, 150);
            dtx_Date_Naissance.Name = "dtx_Date_Naissance";
            dtx_Date_Naissance.Size = new Size(123, 23);
            dtx_Date_Naissance.TabIndex = 2;
            dtx_Date_Naissance.Value = new DateTime(2026, 10, 7, 9, 0, 39, 0);
            dtx_Date_Naissance.ValueChanged += dtx_Date_Naissance_ValueChanged;
            // 
            // tbx_Nom_Etudiant
            // 
            tbx_Nom_Etudiant.Location = new Point(150, 100);
            tbx_Nom_Etudiant.Name = "tbx_Nom_Etudiant";
            tbx_Nom_Etudiant.Size = new Size(100, 23);
            tbx_Nom_Etudiant.TabIndex = 1;
            tbx_Nom_Etudiant.TextChanged += tbx_Nom_Etudiant_TextChanged;
            // 
            // tbx_Prenom_Etudiant
            // 
            tbx_Prenom_Etudiant.Location = new Point(151, 52);
            tbx_Prenom_Etudiant.Name = "tbx_Prenom_Etudiant";
            tbx_Prenom_Etudiant.Size = new Size(100, 23);
            tbx_Prenom_Etudiant.TabIndex = 0;
            tbx_Prenom_Etudiant.TextChanged += tbx_Prenom_Etudiant_TextChanged;
            // 
            // tbp_Cahier
            // 
            tbp_Cahier.Controls.Add(lbl_Echec_Reussi);
            tbp_Cahier.Controls.Add(btn_SupprimerEtu);
            tbp_Cahier.Controls.Add(lbx_Etudiant);
            tbp_Cahier.Controls.Add(pbx_Cahier);
            tbp_Cahier.Controls.Add(rtb_Moyenne);
            tbp_Cahier.Controls.Add(lbl_Moyenne);
            tbp_Cahier.Controls.Add(tbx_EvalCahier5);
            tbp_Cahier.Controls.Add(tbx_EvalCahier4);
            tbp_Cahier.Controls.Add(tbx_EvalCahier3);
            tbp_Cahier.Controls.Add(tbx_EvalCahier2);
            tbp_Cahier.Controls.Add(tbx_EvalCahier1);
            tbp_Cahier.Controls.Add(rtb_Finale);
            tbp_Cahier.Controls.Add(lbl_NoteFinale);
            tbp_Cahier.Controls.Add(lbl_ResultatCahier);
            tbp_Cahier.Controls.Add(lbl_Note);
            tbp_Cahier.Controls.Add(rtb_Note5);
            tbp_Cahier.Controls.Add(rtb_Note4);
            tbp_Cahier.Controls.Add(rtb_Note3);
            tbp_Cahier.Controls.Add(rtb_Note2);
            tbp_Cahier.Controls.Add(rtb_Note1);
            tbp_Cahier.Location = new Point(4, 24);
            tbp_Cahier.Name = "tbp_Cahier";
            tbp_Cahier.Padding = new Padding(3);
            tbp_Cahier.Size = new Size(556, 247);
            tbp_Cahier.TabIndex = 2;
            tbp_Cahier.Text = "Cahier de notes";
            tbp_Cahier.UseVisualStyleBackColor = true;
            // 
            // lbl_Echec_Reussi
            // 
            lbl_Echec_Reussi.AutoSize = true;
            lbl_Echec_Reussi.Location = new Point(417, 225);
            lbl_Echec_Reussi.Name = "lbl_Echec_Reussi";
            lbl_Echec_Reussi.Size = new Size(110, 15);
            lbl_Echec_Reussi.TabIndex = 34;
            lbl_Echec_Reussi.Text = "Échec pour le cours";
            lbl_Echec_Reussi.Visible = false;
            // 
            // btn_SupprimerEtu
            // 
            btn_SupprimerEtu.Location = new Point(15, 214);
            btn_SupprimerEtu.Name = "btn_SupprimerEtu";
            btn_SupprimerEtu.Size = new Size(196, 23);
            btn_SupprimerEtu.TabIndex = 33;
            btn_SupprimerEtu.Text = "Supprimer un étudiant";
            btn_SupprimerEtu.UseVisualStyleBackColor = true;
            btn_SupprimerEtu.Click += btn_SupprimerEtu_Click;
            // 
            // lbx_Etudiant
            // 
            lbx_Etudiant.FormattingEnabled = true;
            lbx_Etudiant.Location = new Point(13, 130);
            lbx_Etudiant.Name = "lbx_Etudiant";
            lbx_Etudiant.Size = new Size(209, 64);
            lbx_Etudiant.TabIndex = 32;
            lbx_Etudiant.SelectedIndexChanged += lbx_Etudiant_SelectedIndexChanged;
            // 
            // pbx_Cahier
            // 
            pbx_Cahier.BackgroundImage = (Image)resources.GetObject("pbx_Cahier.BackgroundImage");
            pbx_Cahier.BackgroundImageLayout = ImageLayout.Stretch;
            pbx_Cahier.Location = new Point(13, 10);
            pbx_Cahier.Name = "pbx_Cahier";
            pbx_Cahier.Size = new Size(88, 113);
            pbx_Cahier.TabIndex = 31;
            pbx_Cahier.TabStop = false;
            // 
            // rtb_Moyenne
            // 
            rtb_Moyenne.Enabled = false;
            rtb_Moyenne.Location = new Point(107, 100);
            rtb_Moyenne.Name = "rtb_Moyenne";
            rtb_Moyenne.Size = new Size(115, 24);
            rtb_Moyenne.TabIndex = 30;
            rtb_Moyenne.Text = "";
            // 
            // lbl_Moyenne
            // 
            lbl_Moyenne.AutoSize = true;
            lbl_Moyenne.Location = new Point(107, 70);
            lbl_Moyenne.Name = "lbl_Moyenne";
            lbl_Moyenne.Size = new Size(115, 15);
            lbl_Moyenne.TabIndex = 29;
            lbl_Moyenne.Text = "Moyenne du groupe";
            // 
            // tbx_EvalCahier5
            // 
            tbx_EvalCahier5.Enabled = false;
            tbx_EvalCahier5.Location = new Point(309, 146);
            tbx_EvalCahier5.Name = "tbx_EvalCahier5";
            tbx_EvalCahier5.Size = new Size(100, 23);
            tbx_EvalCahier5.TabIndex = 28;
            // 
            // tbx_EvalCahier4
            // 
            tbx_EvalCahier4.Enabled = false;
            tbx_EvalCahier4.Location = new Point(309, 117);
            tbx_EvalCahier4.Name = "tbx_EvalCahier4";
            tbx_EvalCahier4.Size = new Size(100, 23);
            tbx_EvalCahier4.TabIndex = 27;
            // 
            // tbx_EvalCahier3
            // 
            tbx_EvalCahier3.Enabled = false;
            tbx_EvalCahier3.Location = new Point(309, 88);
            tbx_EvalCahier3.Name = "tbx_EvalCahier3";
            tbx_EvalCahier3.Size = new Size(100, 23);
            tbx_EvalCahier3.TabIndex = 26;
            // 
            // tbx_EvalCahier2
            // 
            tbx_EvalCahier2.Enabled = false;
            tbx_EvalCahier2.Location = new Point(309, 58);
            tbx_EvalCahier2.Name = "tbx_EvalCahier2";
            tbx_EvalCahier2.Size = new Size(100, 23);
            tbx_EvalCahier2.TabIndex = 25;
            // 
            // tbx_EvalCahier1
            // 
            tbx_EvalCahier1.Enabled = false;
            tbx_EvalCahier1.Location = new Point(309, 28);
            tbx_EvalCahier1.Name = "tbx_EvalCahier1";
            tbx_EvalCahier1.Size = new Size(100, 23);
            tbx_EvalCahier1.TabIndex = 24;
            // 
            // rtb_Finale
            // 
            rtb_Finale.Enabled = false;
            rtb_Finale.Location = new Point(445, 196);
            rtb_Finale.Name = "rtb_Finale";
            rtb_Finale.Size = new Size(47, 24);
            rtb_Finale.TabIndex = 9;
            rtb_Finale.Text = "";
            // 
            // lbl_NoteFinale
            // 
            lbl_NoteFinale.AutoSize = true;
            lbl_NoteFinale.Location = new Point(344, 199);
            lbl_NoteFinale.Name = "lbl_NoteFinale";
            lbl_NoteFinale.Size = new Size(65, 15);
            lbl_NoteFinale.TabIndex = 7;
            lbl_NoteFinale.Text = "Note finale";
            // 
            // lbl_ResultatCahier
            // 
            lbl_ResultatCahier.AutoSize = true;
            lbl_ResultatCahier.Location = new Point(329, 10);
            lbl_ResultatCahier.Name = "lbl_ResultatCahier";
            lbl_ResultatCahier.Size = new Size(54, 15);
            lbl_ResultatCahier.TabIndex = 6;
            lbl_ResultatCahier.Text = "Résultats";
            // 
            // lbl_Note
            // 
            lbl_Note.AutoSize = true;
            lbl_Note.Location = new Point(450, 6);
            lbl_Note.Name = "lbl_Note";
            lbl_Note.Size = new Size(33, 15);
            lbl_Note.TabIndex = 5;
            lbl_Note.Text = "Note";
            // 
            // rtb_Note5
            // 
            rtb_Note5.Enabled = false;
            rtb_Note5.Location = new Point(445, 146);
            rtb_Note5.Name = "rtb_Note5";
            rtb_Note5.Size = new Size(47, 24);
            rtb_Note5.TabIndex = 4;
            rtb_Note5.Text = "";
            // 
            // rtb_Note4
            // 
            rtb_Note4.Enabled = false;
            rtb_Note4.Location = new Point(445, 116);
            rtb_Note4.Name = "rtb_Note4";
            rtb_Note4.Size = new Size(47, 24);
            rtb_Note4.TabIndex = 3;
            rtb_Note4.Text = "";
            // 
            // rtb_Note3
            // 
            rtb_Note3.Enabled = false;
            rtb_Note3.Location = new Point(445, 88);
            rtb_Note3.Name = "rtb_Note3";
            rtb_Note3.Size = new Size(47, 24);
            rtb_Note3.TabIndex = 2;
            rtb_Note3.Text = "";
            // 
            // rtb_Note2
            // 
            rtb_Note2.Enabled = false;
            rtb_Note2.Location = new Point(445, 58);
            rtb_Note2.Name = "rtb_Note2";
            rtb_Note2.Size = new Size(47, 24);
            rtb_Note2.TabIndex = 1;
            rtb_Note2.Text = "";
            // 
            // rtb_Note1
            // 
            rtb_Note1.Enabled = false;
            rtb_Note1.Location = new Point(445, 28);
            rtb_Note1.Name = "rtb_Note1";
            rtb_Note1.Size = new Size(47, 24);
            rtb_Note1.TabIndex = 0;
            rtb_Note1.Text = "";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
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
            FormClosing += frm_Ecran_FormClosing;
            Load += frm_Ecran_Load;
            tcl_Menu.ResumeLayout(false);
            tbp_Cours.ResumeLayout(false);
            tbp_Cours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Ecole).EndInit();
            tbp_Etudiant.ResumeLayout(false);
            tbp_Etudiant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Cours5).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours4).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours3).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours2).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_Cours1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbx_Eleve).EndInit();
            tbp_Cahier.ResumeLayout(false);
            tbp_Cahier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbx_Cahier).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
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
        private TextBox tbx_Eval5;
        private TextBox tbx_Eval4;
        private TextBox tbx_Eval3;
        private TextBox tbx_Eval2;
        private TextBox tbx_Eval1;
        private Button btn_Modifier;
        private Button btn_Valider;
        private Button btn_Effacer;
        private Button btn_Sauvegarder;
        private Label lbl_DateNaissance;
        private Label lbl_Nom;
        private Label lbl_Prenom;
        private PictureBox pbx_Eleve;
        private Label lbl_CodePermanent;
        private Label lbl_Age;
        private NumericUpDown nud_Cours5;
        private NumericUpDown nud_Cours4;
        private NumericUpDown nud_Cours3;
        private NumericUpDown nud_Cours2;
        private NumericUpDown nud_Cours1;
        private TextBox tbx_CoursEtu5;
        private TextBox tbx_CoursEtu4;
        private TextBox tbx_CoursEtu3;
        private TextBox tbx_CoursEtu2;
        private TextBox tbx_CoursEtu1;
        private Label Résultats;
        private RichTextBox rtb_Note1;
        private RichTextBox rtb_Note5;
        private RichTextBox rtb_Note4;
        private RichTextBox rtb_Note3;
        private RichTextBox rtb_Note2;
        private RichTextBox rtb_Finale;
        private Label lbl_NoteFinale;
        private Label lbl_ResultatCahier;
        private Label lbl_Note;
        private TextBox tbx_EvalCahier5;
        private TextBox tbx_EvalCahier4;
        private TextBox tbx_EvalCahier3;
        private TextBox tbx_EvalCahier2;
        private TextBox tbx_EvalCahier1;
        private ListBox lbx_Etudiant;
        private PictureBox pbx_Cahier;
        private RichTextBox rtb_Moyenne;
        private Label lbl_Moyenne;
        private Label lbl_Echec_Reussi;
        private Button btn_SupprimerEtu;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
    }
}

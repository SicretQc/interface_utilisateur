using System.Text;
using System.Text.RegularExpressions;

namespace Travail_Pratique_1
{
    public partial class frm_Ecran : Form
    {
        public const int MAX_ETUDIANT = 10;
        public const string erreurEvaluation = "Il manque au moins une évaluation.";
        public const string erreurPrenomVide = "Le prénom ne peut pas être vide.";
        public const string erreurNomVide = "Le nom ne peut pas être vide.";
        public const string erreurCaracteres = "Les caractères saisis doivent comporter seulement les caractères suivants : lettres et caractères de contrôle.";
        public const string erreurDate = "La date de naissance doit être selectionnée.";
        public const string erreurEtudiantComplet = "Le nombre maximum d'étudiants a été atteint. Impossible d'ajouter un nouvel étudiant.";

        public Cours[] listeCours = new Cours[2];
        public Etudiant[] listeEtudiants = new Etudiant[MAX_ETUDIANT];
        private StringBuilder scodePermanent = new StringBuilder("XXXX999999");
        private StringBuilder sNom = new StringBuilder("XXX");
        private StringBuilder sPrenom = new StringBuilder("X");
        private StringBuilder sDateNaissance = new StringBuilder("999999");

        public frm_Ecran()
        {
            InitializeComponent();
        }

        private void frm_Ecran_Load(object sender, EventArgs e)
        {
            AjouterCours();
            if (listeCours.Length > 0)
            {
                for (int i = 0; i < listeCours.Length; i++)
                {
                    cbx_Choix_Cours.Items.Add(listeCours[i].ToString());
                }
                cbx_Choix_Cours.SelectedIndex = 0;
            }
            tbx_Nb_Etudiants.Text = Etudiant.NumEtudiant + "";
        }

        private void AjouterCours()
        {
            Cours Interface_utilisateur = new Cours("420 - 3D4", "Interface utilisateur");
            Cours Interface_Web = new Cours("420 - 3E5", "Interface Web");
            listeCours[0] = Interface_utilisateur;
            listeCours[1] = Interface_Web;
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_Ecran_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultat = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Confirmation de fermeture", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultat == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            Boolean evaluationVide = false;
            if (cbx_Choix_Cours.SelectedItem != null)
            {
                listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[0] = tbx_Eval1.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[1] = tbx_Eval2.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[2] = tbx_Eval3.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[3] = tbx_Eval4.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[4] = tbx_Eval5.Text;
                tbx_CoursEtu1.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[0];
                tbx_CoursEtu2.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[1];
                tbx_CoursEtu3.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[2];
                tbx_CoursEtu4.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[3];
                tbx_CoursEtu5.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[4];

                for (int i = 0; i < listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations.Length; i++)
                {
                    if (listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[i] == null || listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[i] == "")
                    {
                        evaluationVide = true;
                        break;
                    }
                }

                if (evaluationVide)
                {
                    MessageBox.Show("Veuillez remplir toutes les évaluations pour le cours sélectionné.", "Évaluations incomplètes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    verifierEvaluationVide();
                    tbx_Eval1.Enabled = false;
                    tbx_Eval2.Enabled = false;
                    tbx_Eval3.Enabled = false;
                    tbx_Eval4.Enabled = false;
                    tbx_Eval5.Enabled = false;
                }
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            tbx_Eval1.Enabled = true;
            tbx_Eval2.Enabled = true;
            tbx_Eval3.Enabled = true;
            tbx_Eval4.Enabled = true;
            tbx_Eval5.Enabled = true;
        }

        private void cbx_Choix_Cours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Choix_Cours.SelectedItem != null)
            {
                lbl_Gestion.Text = "Gestion des évaluations pour le cours " + cbx_Choix_Cours.SelectedItem.ToString();
                tbx_Eval1.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[0];
                tbx_Eval2.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[1];
                tbx_Eval3.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[2];
                tbx_Eval4.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[3];
                tbx_Eval5.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[4];
                tbx_CoursEtu1.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[0];
                tbx_CoursEtu2.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[1];
                tbx_CoursEtu3.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[2];
                tbx_CoursEtu4.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[3];
                tbx_CoursEtu5.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[4];
                supprimerDetails();
                if (listeCours[cbx_Choix_Cours.SelectedIndex].Inscription.Length != 0)
                {
                    lbx_Etudiant.Items.Clear();
                    for (int i = 0; i < listeCours[cbx_Choix_Cours.SelectedIndex].Inscription.Length; i++)
                    {
                        if (listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i] != null)
                        {
                            lbx_Etudiant.Items.Add(listeEtudiants[listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i].NumEtudiant - 1].ToString());
                        }
                    }
                }
            }
        }

        private void verifierEvaluationVide()
        {
            Boolean evaluationVide = false;
            for (int i = 0; i < listeCours.Length; i++)
            {
                for (int j = 0; j < listeCours[i].Evaluations.Length; j++)
                {
                    if (listeCours[i].Evaluations[j] == null || listeCours[i].Evaluations[j] == "")
                    {
                        evaluationVide = true;
                        break;
                    }
                }
            }

            if (evaluationVide == false)
            {
                btn_Sauvegarder.Enabled = true;
            }
            else
            {
                btn_Sauvegarder.Enabled = false;
            }
        }

        private void tbx_Prenom_Etudiant_TextChanged(object sender, EventArgs e)
        {
            if (tbx_Prenom_Etudiant.Text.Length >= 1)
            {

                sPrenom.Clear();
                sPrenom.Append(tbx_Prenom_Etudiant.Text.Substring(0, 1));
            }
            else
            {
                sPrenom.Clear();
                sPrenom.Append("X");
            }
            scodePermanent.Clear();
            scodePermanent.Append(sNom.ToString() + sPrenom.ToString() + sDateNaissance.ToString());
            tbx_Code_Permanent.Text = scodePermanent.ToString().ToUpper();
        }

        private void tbx_Nom_Etudiant_TextChanged(object sender, EventArgs e)
        {
            if (tbx_Nom_Etudiant.Text.Length >= 3)
            {
                sNom.Clear();
                sNom.Append(tbx_Nom_Etudiant.Text.Substring(0, 3));
            }
            else if (tbx_Nom_Etudiant.Text.Length < 3)
            {
                sNom.Clear();
                sNom.Append(tbx_Nom_Etudiant.Text.Substring(0, tbx_Nom_Etudiant.Text.Length));
                for (int i = 0; i < 3 - tbx_Nom_Etudiant.Text.Length; i++)
                {
                    sNom.Append("X");
                }
            }
            scodePermanent.Clear();
            scodePermanent.Append(sNom.ToString() + sPrenom.ToString() + sDateNaissance.ToString());
            tbx_Code_Permanent.Text = scodePermanent.ToString().ToUpper();
        }

        private void dtx_Date_Naissance_ValueChanged(object sender, EventArgs e)
        {
            sDateNaissance.Clear();
            sDateNaissance.Append(dtx_Date_Naissance.Value.ToString("yyyyMMdd"));
            scodePermanent.Clear();
            scodePermanent.Append(sNom.ToString() + sPrenom.ToString() + sDateNaissance.ToString());
            tbx_Code_Permanent.Text = scodePermanent.ToString().ToUpper();
            tbx_age.Text = (DateTime.Now.Year - dtx_Date_Naissance.Value.Year).ToString();
        }

        private void btn_Sauvegarder_Click(object sender, EventArgs e)
        {
            Boolean EtudiantComplet = Etudiant.NumEtudiant == MAX_ETUDIANT;
            if (EtudiantComplet)
            {
                MessageBox.Show(erreurEtudiantComplet, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AjouterEtudiant();
            }
        }

        private void AjouterEtudiant()
        {
            Boolean EtudiantVide = false;
            string regex = @"^([a-zA-ZÀ-ÿ]|\p{Cc}])+$";
            if (tbx_Prenom_Etudiant.Text.IsWhiteSpace())
            {
                EtudiantVide = true;
                errorProvider1.Clear();
                errorProvider1.SetError(tbx_Prenom_Etudiant, erreurPrenomVide);
            }
            else if (!(Regex.IsMatch(tbx_Prenom_Etudiant.Text, regex)))
            {
                EtudiantVide = true;
                errorProvider1.Clear();
                errorProvider1.SetError(tbx_Prenom_Etudiant, erreurCaracteres);
            }
            else
            {
                errorProvider1.Clear();
            }

            if (tbx_Nom_Etudiant.Text.IsWhiteSpace())
            {
                EtudiantVide = true;
                errorProvider2.Clear();
                errorProvider2.SetError(tbx_Nom_Etudiant, erreurNomVide);
            }
            else if (!(Regex.IsMatch(tbx_Nom_Etudiant.Text, regex)))
            {
                EtudiantVide = true;
                errorProvider2.Clear();
                errorProvider2.SetError(tbx_Nom_Etudiant, erreurCaracteres);
            }
            else
            {
                errorProvider2.Clear();
            }

            if (sDateNaissance.ToString() == "999999")
            {
                EtudiantVide = true;
                errorProvider3.Clear();
                errorProvider3.SetError(dtx_Date_Naissance, erreurDate);
            }
            else
            {
                errorProvider3.Clear();
            }

            if (EtudiantVide == false)
            {
                int numCours = -1;
                Etudiant etudiant = new Etudiant(tbx_Prenom_Etudiant.Text, tbx_Nom_Etudiant.Text, dtx_Date_Naissance.Value.ToString("yyyy-MM-dd"), tbx_Code_Permanent.Text);
                listeEtudiants[Etudiant.NumEtudiant - 1] = etudiant;
                tbx_Nb_Etudiants.Text = Etudiant.NumEtudiant + "";
                for (int i = 0; i < listeCours.Length - 1; i++)
                {
                    if (cbx_Choix_Cours.Text == listeCours[i].ToString())
                    {
                        numCours = i;
                    }
                }
                Inscription inscription = new(Etudiant.NumEtudiant, numCours, new int[] { (int)nud_Cours1.Value, (int)nud_Cours2.Value, (int)nud_Cours3.Value, (int)nud_Cours4.Value, (int)nud_Cours5.Value });
                ajouterInscription(inscription);
                lbx_Etudiant.Items.Add(etudiant.ToString());
                tbp_Cours.Enabled = false;
                MessageBox.Show("Les données de l’étudiant ont été sauvegardées pour le cours.");
            }
        }

        private void btn_Effacer_Click(object sender, EventArgs e)
        {
            tbx_Prenom_Etudiant.Clear();
            tbx_Nom_Etudiant.Clear();
            dtx_Date_Naissance.Value = DateTime.Now;
            sDateNaissance.Clear();
            sDateNaissance.Append("999999");
            scodePermanent.Clear();
            scodePermanent.Append("XXXX999999");
            tbx_Code_Permanent.Text = scodePermanent.ToString();
            tbx_age.Text = "0";
            nud_Cours1.Value = 0;
            nud_Cours2.Value = 0;
            nud_Cours3.Value = 0;
            nud_Cours4.Value = 0;
            nud_Cours5.Value = 0;
        }

        private void ajouterInscription(Inscription inscription)
        {
            listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[Inscription.NumInscription -1 ] = inscription;
        }

        private void ajouterDetails(Inscription inscription)
        {
            int compteur = 0;
            double finale = 0;
            double moyenne = 0;
            tbx_EvalCahier1.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[0];
            tbx_EvalCahier2.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[1];
            tbx_EvalCahier3.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[2];
            tbx_EvalCahier4.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[3];
            tbx_EvalCahier5.Text = listeCours[cbx_Choix_Cours.SelectedIndex].Evaluations[4];
            rtb_Note1.Text = inscription.Notes[0] + "%";
            rtb_Note2.Text = inscription.Notes[1] + "%";
            rtb_Note3.Text = inscription.Notes[2] + "%";
            rtb_Note4.Text = inscription.Notes[3] + "%";
            rtb_Note5.Text = inscription.Notes[4] + "%";
            for (int i = 0; i < inscription.Notes.Length; i++)
            {
                finale += inscription.Notes[i];
            }
            finale = finale / inscription.Notes.Length;
            rtb_Finale.Text = string.Format("{0:0.0}%", finale);
            for (int i = 0; i < listeCours[cbx_Choix_Cours.SelectedIndex].Inscription.Length; i++)
            {
                if (listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i] != null)
                {
                    for (int j = 0; j < listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i].Notes.Length; j++)
                    {
                        moyenne += listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i].Notes[j];
                        compteur++;
                    }
                }
            }
            moyenne = moyenne / compteur;
            rtb_Moyenne.Text = string.Format("{0:0.0}%", moyenne);
            if (finale >= 60)
            {
                lbl_Echec_Reussi.Visible = true;
                lbl_Echec_Reussi.ForeColor = Color.Green;
                lbl_Echec_Reussi.Text = "Réussite pour le cours";
            }
            else
            {
                lbl_Echec_Reussi.Visible = true;
                lbl_Echec_Reussi.ForeColor = Color.Red;
                lbl_Echec_Reussi.Text = "Échec pour le cours";
            }

            if (moyenne >= 60)
            {
                rtb_Moyenne.ForeColor = Color.Green;
            }
            else
            {
                rtb_Moyenne.ForeColor = Color.Red;
            }
        }

        private void supprimerDetails()
        {
            tbx_EvalCahier1.Clear();
            tbx_EvalCahier2.Clear();
            tbx_EvalCahier3.Clear();
            tbx_EvalCahier4.Clear();
            tbx_EvalCahier5.Clear();
            rtb_Note1.Clear();
            rtb_Note2.Clear();
            rtb_Note3.Clear();
            rtb_Note4.Clear();
            rtb_Note5.Clear();
            rtb_Finale.Clear();
            rtb_Moyenne.Clear();
            lbl_Echec_Reussi.Visible = false;
        }

        private void lbx_Etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < listeCours[cbx_Choix_Cours.SelectedIndex].Inscription.Length; i++)
            {
                if (listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i] != null && lbx_Etudiant.SelectedItem != null)
                {
                    if (lbx_Etudiant.SelectedItem.ToString() == listeEtudiants[listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i].NumEtudiant - 1].ToString())
                    {
                        supprimerDetails();
                        ajouterDetails(listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i]);
                    }
                }
            }
        }

        private void btn_SupprimerEtu_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listeCours[cbx_Choix_Cours.SelectedIndex].Inscription.Length; i++)
            {
                if (listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i] != null)
                {
                    int numEtudiant = listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i].NumEtudiant - 1;
                    if (lbx_Etudiant.SelectedIndex == numEtudiant)
                    {   
                        for (int j = numEtudiant; j < listeEtudiants.Length - 1; j++)
                        {
                            listeEtudiants[j] = listeEtudiants[j + 1];
                        }
                        listeEtudiants[Etudiant.NumEtudiant - 1] = null;
                        listeCours[cbx_Choix_Cours.SelectedIndex].Inscription[i] = null;
                        supprimerDetails();
                        lbx_Etudiant.Items.RemoveAt(lbx_Etudiant.SelectedIndex);
                        Etudiant.NumEtudiant--;
                        Inscription.NumInscription--;
                        tbx_Nb_Etudiants.Text = Etudiant.NumEtudiant.ToString();
                        break;
                    }
                }
            }
        }
    }
}

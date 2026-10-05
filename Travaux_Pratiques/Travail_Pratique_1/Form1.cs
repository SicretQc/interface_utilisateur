using System.Text;

namespace Travail_Pratique_1
{
    public partial class frm_Ecran : Form
    {

        List<Cours> listeCours = new List<Cours>();
        private StringBuilder scodePermanent = new StringBuilder("XXXX999999");
        private StringBuilder sNom = new StringBuilder("XXX");
        private StringBuilder sPrenom = new StringBuilder("X");
        private StringBuilder sDateNaissance = new StringBuilder("999999");

        public frm_Ecran()
        {
            InitializeComponent();
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
            sDateNaissance.Append(dtx_Date_Naissance.Value.ToString("yyMMdd"));
            scodePermanent.Clear();
            scodePermanent.Append(sNom.ToString() + sPrenom.ToString() + sDateNaissance.ToString());
            tbx_Code_Permanent.Text = scodePermanent.ToString().ToUpper();
        }

        private void frm_Ecran_Load(object sender, EventArgs e)
        {
            tbp_Etudiant.Enabled = false;
            tbp_Cahier.Enabled = false;

            ajouterCours();
            if (listeCours.Count > 0)
            {
                for (int i = 0; i < listeCours.Count; i++)
                {
                    cbx_Choix_Cours.Items.Add(listeCours[i].ToString());
                }
                cbx_Choix_Cours.SelectedIndex = 0;
            }
            tbx_Nb_Etudiants.Text = Etudiant.numEtudiant + "";
        }

        private void cbx_Choix_Cours_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Choix_Cours.SelectedItem != null)
            {
                lbl_Gestion.Text = "Gestion des évaluations pour le cours " + cbx_Choix_Cours.SelectedItem.ToString();
                tbx_Eval1.Text = listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[0];
                tbx_Eval2.Text = listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[1];
                tbx_Eval3.Text = listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[2];
                tbx_Eval4.Text = listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[3];
                tbx_Eval5.Text = listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[4];
            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajouterCours()
        {
            Cours Interface_utilisateur = new Cours("420 - 3D4", "Interface utilisateur");
            Cours Interface_Web = new Cours("420 - 3E5", "Interface Web");
            listeCours.Add(Interface_utilisateur);
            listeCours.Add(Interface_Web);
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            Boolean evaluationVide = false;
            if (cbx_Choix_Cours.SelectedItem != null)
            {
                listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[0] = tbx_Eval1.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[1] = tbx_Eval2.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[2] = tbx_Eval3.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[3] = tbx_Eval4.Text;
                listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[4] = tbx_Eval5.Text;

                for (int i = 0; i < listeCours[cbx_Choix_Cours.SelectedIndex].evaluations.Length; i++)
                {
                    if (listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[i] == null || listeCours[cbx_Choix_Cours.SelectedIndex].evaluations[i] == "")
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

        private void verifierEvaluationVide()
        {
            Boolean evaluationVide = false;
            for (int i = 0; i < listeCours.Count; i++)
            {
                for (int j = 0; j < listeCours[i].evaluations.Length; j++)
                {
                    if (listeCours[i].evaluations[j] == null || listeCours[i].evaluations[j] == "")
                    {
                        evaluationVide = true;
                        break;
                    }
                }
            }

            if (evaluationVide == false)
            {
                tbp_Etudiant.Enabled = true;
                tbp_Cahier.Enabled = true;
            }
            else
            {
                tbp_Etudiant.Enabled = false;
                tbp_Cahier.Enabled = false;
            }
        }
    }
}

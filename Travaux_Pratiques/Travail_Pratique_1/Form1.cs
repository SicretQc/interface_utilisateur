using System.Text;

namespace Travail_Pratique_1
{
    public partial class frm_Ecran : Form
    {
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
    }
}

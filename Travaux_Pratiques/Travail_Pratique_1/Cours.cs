using System;
using System.Text;

namespace Travail_Pratique_1
{
    public class Cours
    {
        private static int _numCours = 0;
        public static int NumCours
        {
            get { return _numCours; }
            set { _numCours = value; }
        }
        private string _codeCours;
        public string CodeCours
        {
            get { return _codeCours; }
            set
            { 
                if(value.Length == 7)
                {
                    _codeCours = value;
                }
            } 
        }

        public string Nom { get; set; }
        private string[] _evaluations;
        public string[] Evaluations
        {
            get { return _evaluations; }
            set
            {
                if (value.Length <= 5)
                {
                    _evaluations = value;
                }
            }
        }

        private Inscription[] _inscription;
        public Inscription[] Inscription
        {
            get { return _inscription; }
            set
            {
                if (AjouterInscription(Inscription[frm_Ecran.MAX_ETUDIANT]))
                {
                    _inscription = value;
                }
            }
        }

        public Cours()
        {
            _numCours++;
            _codeCours = string.Empty;
            Nom = string.Empty;
            _evaluations = new string[5];
            _inscription = new Inscription[frm_Ecran.MAX_ETUDIANT];
        }

        public Cours(string codeCours, string nom)
        {
            _numCours++;
            _codeCours = codeCours;
            Nom = nom;
            _evaluations = new string[5];
            _inscription = new Inscription[frm_Ecran.MAX_ETUDIANT];
        }

        override
        public string ToString()
        {
            return _codeCours + " - " + Nom;
        }

        private static Boolean AjouterInscription(Inscription inscription)
        {
            if(inscription.NumEtudiant == frm_Ecran.MAX_ETUDIANT)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
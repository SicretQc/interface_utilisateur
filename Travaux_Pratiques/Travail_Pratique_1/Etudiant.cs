using System;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Travail_Pratique_1
{
    public class Etudiant
    {
        private static int _numEtudiant = 0;
        public static int NumEtudiant
        {
            get { return _numEtudiant; } 
            set {_numEtudiant = value;}
        }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        private string _dateNaissance;
        public string DateNaissance
        {
            get { return _dateNaissance; }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    _dateNaissance = value;
                }
            }
        }
        private string _codePermanent;
        public string CodePermanent
        {
            get { return _codePermanent; }
            set
            {
                if (value == @"[a-zA-Z]{4}\d{6}")
                {
                    _codePermanent = value;
                }
            }
        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                DateTime dateNaissance = DateTime.ParseExact(this._dateNaissance, "yyyy-MM-dd", null);
                DateTime dateActuelle = DateTime.Now;
                _age = dateActuelle.Year - dateNaissance.Year;
            }
        }

        public Etudiant()
        {
            _numEtudiant++;
            Prenom = "";
            Nom = "";
            _dateNaissance = "";
            _codePermanent = "";
        }

        public Etudiant(string prenom, string nom, string dateNaissance, string codePermanent)
        {
            _numEtudiant++;
            Prenom = prenom;
            Nom = nom;
            _dateNaissance = dateNaissance;
            _codePermanent = codePermanent;
        }

        override
        public string ToString()
        {
            return Prenom + " " + Nom + " - " + _codePermanent;
        }
    }
}

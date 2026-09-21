using System;
using System.Collections.Generic;
using System.Text;

namespace Travail_Pratique_1
{
    internal class Etudiant
    {
        private static int compteur = 0;

        private int NumEtudiant;
        private string Prenom;
        private string Nom;
        private string DateNaissance;
        private string CodePermanent;
        private int age;

        public int numEtudiant
        {
            get { return NumEtudiant; }
            set { NumEtudiant = value; }
        }

        public string prenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }

        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string dateNaissance
        {
            get { return DateNaissance; }
            set
            {
                if (DateTime.TryParseExact(value, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
                {
                    DateNaissance = value;
                }
            }
        }

        public string codePermanent
        {
            get { return CodePermanent; }
            set
            {
                if (value == @"[a-zA-Z]{4}\d{6}")
                {
                    CodePermanent = value;
                }
            }
        }

        public int Age
        {
            get { return CalculerAge(); }
        }

        public Etudiant()
        {
            this.numEtudiant = compteur++;
            this.Prenom = "";
            this.Nom = "";
            this.DateNaissance = "";
            this.CodePermanent = "";
        }

        public Etudiant(int numEtudiant, string prenom, string nom, string dateNaissance, string codePermanent)
        {
            this.NumEtudiant = numEtudiant;
            this.Prenom = prenom;
            this.Nom = nom;
            this.DateNaissance = dateNaissance;
            this.CodePermanent = codePermanent;
        }

        private int CalculerAge()
        {
            DateTime dateNaissance = DateTime.ParseExact(this.DateNaissance, "yyyy-MM-dd", null);
            DateTime dateActuelle = DateTime.Now;
            age = dateActuelle.Year - dateNaissance.Year;
            return age;
        }

        override
        public string ToString()
        {
            return "Numéro d'étudiant:" + NumEtudiant + "\nPrénom: " + Prenom + "\nNom: " + Nom + "\nDate de naissance: " + DateNaissance + "\nCode permanent: " + CodePermanent + "\nÂge: " + Age;
        }
    }
}

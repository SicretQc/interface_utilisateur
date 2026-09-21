using System;
using System.Collections.Generic;
using System.Text;

namespace Travail_Pratique_1
{
    internal class Cours
    {
        private static int compteur = 0;

        private int NumCours;
        private string CodeCours;
        private string Nom;
        private string[] Evaluations;
        private Inscription[] Inscriptions;
        private int NombreEtudiants;

        public int numCours
        {
            get { return NumCours; }
            set { NumCours = value; }
        }
        public string codeCours
        {
            get { return CodeCours; }
            set { CodeCours = value; }
        }
        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }
        public string[] evaluations
        {
            get { return Evaluations; }
            set { Evaluations = value; }
        }
        public Inscription[] inscriptions
        {
            get { return Inscriptions; }
            set { Inscriptions = value; }
        }

        public Cours()
        {
            compteur++;
            NumCours = compteur;
            CodeCours = "";
            Nom = "";
            Evaluations = new string[0];
            Inscriptions = new Inscription[0];
            NombreEtudiants = 0;
        }

        public Cours(string codeCours, string nom, string[] evaluations)
        {
            compteur++;
            NumCours = compteur;
            CodeCours = codeCours;
            Nom = nom;
            Evaluations = evaluations;
            Inscriptions = new Inscription[0];
            NombreEtudiants = 0;
        }

        override
        public string ToString()
        {
            return "CodeCours:" + CodeCours + "\nNom:" + Nom;
        }
    }
}
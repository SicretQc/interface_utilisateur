using System;
using System.Text;

namespace Travail_Pratique_1
{
    internal class Cours
    {
        private static int NumCours = 0;

        private string CodeCours;
        private string Nom;
        private string[] Evaluations;
        private Inscription[] Inscriptions;
        private int NombreEtudiants;

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
            NumCours++;
            CodeCours = "";
            Nom = "";
            Evaluations = new string[5];
            Inscriptions = new Inscription[0];
            NombreEtudiants = 0;
        }

        public Cours(string codeCours, string nom)
        {
            NumCours++;
            CodeCours = codeCours;
            Nom = nom;
            Evaluations = new string[5];
            Inscriptions = new Inscription[0];
            NombreEtudiants = 0;
        }

        override
        public string ToString()
        {
            return CodeCours + " - " + Nom;
        }
    }
}
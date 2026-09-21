using System;
using System.Collections.Generic;
using System.Text;

namespace Travail_Pratique_1
{
    internal class Inscription
    {
        private int NumInscription;
        private int NumEtudiant;
        private int NumCours;
        private int[] Notes;

        public int numInscription
        {
            get { return NumInscription; }
            set { NumInscription = value; }
        }
        public int numEtudiant
        {
            get { return NumEtudiant; }
            set { NumEtudiant = value; }
        }
        public int numCours
        {
            get { return NumCours; }
            set { NumCours = value; }
        }
        public int[] notes
        {
            get { return Notes; }
            set { Notes = value; }
        }

        public Inscription()
        {
            NumInscription = 0;
            NumEtudiant = 0;
            NumCours = 0;
            Notes = new int[0];
        }

        public Inscription(int numInscription, int numEtudiant, int numCours, int[] notes)
        {
            NumInscription = numInscription;
            NumEtudiant = numEtudiant;
            NumCours = numCours;
            Notes = notes;
        }

        override
        public string ToString()
        {
            return "NumInscription:" + NumInscription + "\nNumEtudiant: " + NumEtudiant + "\nNumCours: " + NumCours;
        }
    }

}

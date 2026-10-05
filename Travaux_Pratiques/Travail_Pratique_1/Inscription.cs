using System;
using System.Text;

namespace Travail_Pratique_1
{
    public class Inscription
    {
        private static int _numInscription;
        public static int NumInscription
        {
            get { return _numInscription; }
        }
        private int _numEtudiant;
        public int NumEtudiant
        {
            get
            {
                return _numEtudiant;
            }
            set
            {
                _numEtudiant = Etudiant.NumEtudiant;
            }
        }
        private int _numCours;
        public int NumCours
        {
            get
            {
                return _numCours;
            }
            set
            {
                _numCours = Cours.NumCours;
            }
        }
        private int[] _notes;
        public int[] Notes
        {
            get { return _notes; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] >= 0 && value[i] <= 100)
                    {
                        _notes = value;
                    }
                }
            }
        }


        public Inscription()
        {
            _numInscription++;
            _notes = new int[5];
        }

        public Inscription(int[] notes)
        {
            _numInscription++;
            _notes = notes;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _notes.Length; i++)
            {
                sb.Append("\nNote " + (i + 1) + ": " + _notes[i]);
            }
            return "NumInscription:" + _numInscription + "\nNumEtudiant: " + _numEtudiant + "\nNumCours: " + _numCours + sb.ToString();
        }
    }

}

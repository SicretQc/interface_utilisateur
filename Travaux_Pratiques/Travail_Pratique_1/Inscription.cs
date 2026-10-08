using System;
using System.Text;

namespace Travail_Pratique_1
{
    public class Inscription
    {
        public static int NumInscription { get; set; }
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
            NumInscription++;
            _notes = new int[5];
        }

        public Inscription(int numEtudiant, int numCours, int[] notes)
        {
            NumInscription++;
            _numEtudiant = numEtudiant;
            _numCours = numCours;
            _notes = notes;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _notes.Length; i++)
            {
                sb.Append("\nNote " + (i + 1) + ": " + _notes[i]);
            }
            return "NumInscription:" + NumInscription + "\nNumEtudiant: " + _numEtudiant + "\nNumCours: " + _numCours + sb.ToString();
        }
    }

}

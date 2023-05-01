using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace Modele
{

    public class Personne
    {
        #region Variables_membre
        private string _nom;
        private string _prenom;
        private DateTime _dateNaissance;
        #endregion

        #region Constructeurs
        // Constructeur par défaut
        public Personne()
        {
            _nom = "";
            _prenom = "";
            _dateNaissance = DateTime.Now;
        }
        public Personne(string nom, string prenom)
        {
            _nom = nom;
            _prenom = prenom;
        }

        // Constructeur avec paramètres
        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
        }
        #endregion

        #region Accesseurs
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Personne))
            {
                return false;
            }

            Personne p = (Personne)obj;
            return _nom == p._nom && _prenom == p._prenom && _dateNaissance == p._dateNaissance;
        }

        public override string ToString()
        {
            return _nom + " " + _prenom + " (" + _dateNaissance.ToString("dd/MM/yyyy") + ")";
        }

        

        #endregion
    }
}

using System;

namespace Modele
{
    public class Gerant : IntervenantMagasin
    {
        #region Variables_membre
        private uint _MDP;
        private float _bonus;
        #endregion

        #region Constructeurs
        // Constructeur par défaut
        public Gerant() : base()
        {
            _MDP = 0;
            _bonus = 0.0f;
        }

        // Constructeur avec paramètres
        public Gerant(string nom, string prenom, DateTime dateNaissance, int numIntervenant, uint MDP, float bonus) : base(nom, prenom, dateNaissance, numIntervenant)
        {
            _MDP = MDP;
            _bonus = bonus;
        }
        #endregion

        #region Accesseurs
        public uint MDP
        {
            get { return _MDP; }
            set { _MDP = value; }
        }

        public float Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Gerant))
            {
                return false;
            }

            Gerant g = (Gerant)obj;
            return base.Equals(g) && _MDP == g._MDP && _bonus == g._bonus;
        }

        public override string ToString()
        {
            return base.ToString() + " - Gérant (Intervenant n° " + NumIntervenant + ", MDP : " + _MDP + ", Bonus : " + _bonus + ")";
        }
        #endregion
    }
}

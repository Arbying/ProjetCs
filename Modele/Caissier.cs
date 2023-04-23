namespace Modele
{
    public class Caissier : IntervenantMagasin
    {
        #region Variables_membre
        private uint _MDP;
        private float _TotalVentes;
        #endregion

        #region Constructeurs
        // Constructeur par défaut
        public Caissier() : base()
        {
            _MDP = 0;
            _TotalVentes = 0.0f;
        }

        // Constructeur avec paramètres
        public Caissier(string nom, string prenom, DateTime dateNaissance, int numIntervenant, uint MDP, float totalVentes) : base(nom, prenom, dateNaissance, numIntervenant)
        {
            _MDP = MDP;
            _TotalVentes = totalVentes;
        }
        #endregion

        #region Accesseurs
        public uint MDP
        {
            get { return _MDP; }
            set { _MDP = value; }
        }

        public float TotalVentes
        {
            get { return _TotalVentes; }
            set { _TotalVentes = value; }
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Caissier))
            {
                return false;
            }

            Caissier c = (Caissier)obj;
            return base.Equals(c) && _MDP == c._MDP && _TotalVentes == c._TotalVentes;
        }

        public override string ToString()
        {
            return base.ToString() + " - Caissier (Intervenant n° " + NumIntervenant + ", MDP : " + _MDP + ", Total des ventes : " + _TotalVentes + ")";
        }
        #endregion
    }
}

namespace Modele
{
    public abstract class IntervenantMagasin : Personne
    {
        #region Variables_membre
        private int _numIntervenant;
        #endregion

        #region Constructeurs
        // Constructeur par défaut
        public IntervenantMagasin() : base()
        {
            _numIntervenant = 0;
        }

        // Constructeur avec paramètres
        public IntervenantMagasin(string nom, string prenom, DateTime dateNaissance, int numIntervenant) : base(nom, prenom, dateNaissance)
        {
            _numIntervenant = numIntervenant;
        }
        #endregion

        #region Accesseurs
        public int NumIntervenant
        {
            get { return _numIntervenant; }
            set { _numIntervenant = value; }
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is IntervenantMagasin))
            {
                return false;
            }

            IntervenantMagasin i = (IntervenantMagasin)obj;
            return base.Equals(i) && _numIntervenant == i._numIntervenant;
        }

        public override string ToString()
        {
            return base.ToString() + " - Intervenant n° " + _numIntervenant;
        }
        #endregion
    }
}

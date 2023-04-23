namespace Modele
{
    public class Client : IntervenantMagasin
    {
        #region Variables_membre
        private ulong _carteFidelite;
        private int _points;
        #endregion

        #region Constructeurs
        // Constructeur par défaut
        public Client() : base()
        {
            _carteFidelite = 0;
            _points = 0;
        }

        // Constructeur avec paramètres
        public Client(string nom, string prenom, DateTime dateNaissance, int numIntervenant, ulong carteFidelite, int points) : base(nom, prenom, dateNaissance, numIntervenant)
        {
            _carteFidelite = carteFidelite;
            _points = points;
        }
        #endregion

        #region Accesseurs
        public ulong CarteFidelite
        {
            get { return _carteFidelite; }
            set { _carteFidelite = value; }
        }

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Client))
            {
                return false;
            }

            Client c = (Client)obj;
            return base.Equals(c) && _carteFidelite == c._carteFidelite && _points == c._points;
        }

        public override string ToString()
        {
            return base.ToString() + " - Client (Carte de fidélité : " + _carteFidelite + ", Points de fidélité : " + _points + ")";
        }
        #endregion
    }
}

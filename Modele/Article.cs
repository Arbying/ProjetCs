namespace Modele
{
    public class Article
    {
        #region Variables_membre
        private ulong _codeBarre;
        private string _denomination;
        private float _prix;
        private int _points;
        private int _quantite;
        #endregion

        #region Constructeurs
        // Constructeur par défaut
        public Article()
        {
            _codeBarre = 5400000000000;
            _denomination = "";
            _prix = 0.0f;
            _points = 0;
            _quantite = 0;
        }

        // Constructeur avec paramètres
        public Article(ulong codeBarre, string denomination, float prix, int points, int quantite)
        {
            _codeBarre = codeBarre;
            _denomination = denomination;
            _prix = prix;
            _points = points;
            _quantite = quantite;
        }
        #endregion

        #region Accesseurs
        public ulong CodeBarre
        {
            get { return _codeBarre; }
            set { _codeBarre = value; }
        }

        public string Denomination
        {
            get { return _denomination; }
            set { _denomination = value; }
        }

        public float Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public int Points
        {
            get { return _points; }
            set { _points = value; }
        }

        public int Quantite
        {
            get { return _quantite; }
            set { _quantite = value; }
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Article))
            {
                return false;
            }

            Article a = (Article)obj;
            return _codeBarre == a._codeBarre && _denomination == a._denomination && _prix == a._prix && _points == a._points && _quantite == a._quantite;
        }

        public override string ToString()
        {
            return _denomination + " - Prix : " + _prix + "€ - Points : " + _points + " - Quantité en stock : " + _quantite;
        }
        #endregion
    }
}

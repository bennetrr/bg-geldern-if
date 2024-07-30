namespace HeizungsProjekt
{
    public class Heizung
    {
        private int _temperatur;
        public int Temperatur
        {
            get { return _temperatur; }
            set
            {
                if (value <= Min) _temperatur = Min;
                else if (value >= Max) _temperatur = Max;
                else _temperatur = value;
            }
        }

        public int Min { get; }
        public int Max { get; }

        private int _schrittweite;
        public int Schrittweite
        {
            get { return _schrittweite; }
            set { if (value > 0) _schrittweite = value; }
        }

        public Heizung(int temperatur = 0, int min = 0, int max = 40, int schrittweite = 5)
        {
            Min = min;
            Max = max;
            Temperatur = temperatur;
            Schrittweite = schrittweite;
        }

        public void Waermer()
        {
            Temperatur += Schrittweite;
        }
        
        public void Kaelter()
        {
            Temperatur -= Schrittweite;
        }
    }
}
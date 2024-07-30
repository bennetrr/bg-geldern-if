namespace Digitaluhr_V2
{
    public class Nummernanzeige
    {
        private readonly int limit;
        private int wert;

        public Nummernanzeige(int limit)
        {
            Wert = 0;
            this.limit = limit;
        }

        public int Wert
        {
            get { return wert; }
            set
            {
                if (value < 0 || value > limit) wert = 0;
                else wert = value;
            }
        }

        public void ErhoeheWert()
        {
            Wert++;
        }

        public override string ToString()
        {
            return Wert.ToString("00");
        }
    }
}
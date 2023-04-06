namespace Digitaluhr_V2
{
    public class Uhrenanzeige
    {
        private readonly Nummernanzeige minuten;
        private readonly Nummernanzeige sekunden;
        private readonly Nummernanzeige stunden;

        public Uhrenanzeige()
        {
            stunden = new Nummernanzeige(23);
            minuten = new Nummernanzeige(59);
            sekunden = new Nummernanzeige(59);
        }

        public override string ToString()
        {
            return stunden + " : " + minuten + " : " + sekunden;
        }

        public void SetzeZeit(int std, int min, int sek)
        {
            stunden.Wert = std;
            minuten.Wert = min;
            sekunden.Wert = sek;
        }

        public void ErhoeheZeit()
        {
            sekunden.ErhoeheWert();
            if (sekunden.Wert == 0)
            {
                minuten.ErhoeheWert();
                if (minuten.Wert == 0) stunden.ErhoeheWert();
            }
        }
    }
}
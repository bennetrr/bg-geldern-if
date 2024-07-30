namespace Digitaluhr_V2
{
    public class WeckStoppUhr
    {
        private readonly Uhrenanzeige stoppuhr;
        private readonly Uhrenanzeige uhr;
        private readonly Uhrenanzeige wecker;
        
        private int schlummernAnzahl;
        private bool weckerEingeschaltet, alarm, stoppuhrLaeuft;

        public WeckStoppUhr()
        {
            wecker = new Uhrenanzeige();
            stoppuhr = new Uhrenanzeige();
            uhr = new Uhrenanzeige();

            weckerEingeschaltet = false;
            alarm = false;
            stoppuhrLaeuft = false;

            schlummernAnzahl = 0;
        }

        // Main Loop
        public void ErhoeheZeit()
        {
            uhr.ErhoeheZeit();
            if (stoppuhrLaeuft) stoppuhr.ErhoeheZeit();
            if (weckerEingeschaltet) Wecker_pruefeWeckzeit();
        }

        // Uhr
        public void Uhr_setzeUhrzeit(int stunden, int minuten, int sekunden)
        {
            uhr.SetzeZeit(stunden, minuten, sekunden);
        }

        public string Uhr_gibUhrzeit()
        {
            return uhr.ToString();
        }

        // Wecker
        public void Wecker_einschalten()
        {
            weckerEingeschaltet = true;
        }

        public void Wecker_ausschalten()
        {
            weckerEingeschaltet = false;
            wecker_AlarmAusschalten();
        }

        public void wecker_AlarmAusschalten()
        {
            alarm = false;
            for (var i = 0; i < 24 * 60 * 60 - schlummernAnzahl * 300; i++) wecker.ErhoeheZeit();
            schlummernAnzahl = 0;
        }

        public void Wecker_schlummern()
        {
            if (alarm)
            {
                alarm = false;
                schlummernAnzahl++;
                for (var i = 0; i < 300; i++) wecker.ErhoeheZeit();
            }
        }

        public void Wecker_setzeWeckzeit(int stunden, int minuten, int sekunden)
        {
            wecker.SetzeZeit(stunden, minuten, sekunden);
        }

        public string Wecker_gibWeckzeit()
        {
            return wecker.ToString();
        }

        private void Wecker_pruefeWeckzeit()
        {
            if (Wecker_gibWeckzeit() == Uhr_gibUhrzeit()) alarm = true;
        }

        public bool Wecker_gibWeckerEingeschaltet()
        {
            return weckerEingeschaltet;
        }

        public bool Wecker_gibAlarm()
        {
            return alarm;
        }

        // Stoppuhr
        public void Stoppuhr_starten()
        {
            stoppuhrLaeuft = true;
        }

        public void Stoppuhr_stoppen()
        {
            stoppuhrLaeuft = false;
        }

        public void Stoppuhr_reset()
        {
            Stoppuhr_stoppen();
            stoppuhr.SetzeZeit(0, 0, 0);
        }

        public string Stoppuhr_gibStoppuhrzeit()
        {
            return stoppuhr.ToString();
        }

        public bool Stoppuhr_gibStoppuhrLaeuft()
        {
            return stoppuhrLaeuft;
        }
    }
}
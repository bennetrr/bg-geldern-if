/**
 * Die Klasse WeckStoppUhr simuliert eine Digitaluhr, 
 * ... mit Stoppuhr- und Weckfunktion. 
 * Autor:   Martin Lentz
 * Version: 01.02.2017
 */
public class WeckStoppUhr
{
    private Uhrenanzeige uhr, wecker, stoppuhr;
    private boolean weckerEingeschaltet, alarm, stoppuhrLaeuft;

    public WeckStoppUhr()
    {
        wecker = new Uhrenanzeige();
        stoppuhr = new Uhrenanzeige();
        uhr = new Uhrenanzeige();
        weckerEingeschaltet = alarm = stoppuhrLaeuft = false;
    }
    
    // Erhöht die Zeit um einen Takt, d. h. um eine Sekunde 
    public void erhoeheZeit()
    {
        uhr.erhoeheZeit();

        if (stoppuhrLaeuft) stoppuhr.erhoeheZeit();

        if (weckerEingeschaltet) wecker_pruefeWeckzeit();
    }

    // Stellt neue Uhrzeit ein
    public void uhr_setzeUhrzeit(int stunden, int minuten, int sekunden)
    {
        uhr.setzeZeit(stunden, minuten, sekunden);
    }

    // Liefert die aktuelle Uhrzeit 
    public String uhr_gibUhrzeit()
    {
        return uhr.gibZeit();
    }    
    
    // Schaltet den Wecker ein
    public void wecker_einschalten()
    {
        weckerEingeschaltet = true;
    }
        
    // Schaltet den Wecker aus
    public void wecker_ausschalten()
    {
        weckerEingeschaltet = false;
        wecker_AlarmAusschalten();
    }
        
    // Schaltet den Alarm aus ohne den Wecker auszuschalten
    public void wecker_AlarmAusschalten()
    {
        alarm = false;
    }
        
    // Schlummerfunktion: Deaktiviert den Alarm für 10 Minuten
    public void wecker_schlummern()
    {
        if (alarm)
        {
            alarm = false;
            for (int i = 0; i < 600; i++)
            {
                wecker.erhoeheZeit();
            }
        }
    }
    
    // Stellt die Weckzeit ein
    public void wecker_setzeWeckzeit(int stunden, int minuten, int sekunden)
    {
        wecker.setzeZeit(stunden, minuten, sekunden);
    }    

    // Liefert die eingestellte Weckzeit 
    public String wecker_gibWeckzeit()
    {
        return wecker.gibZeit();
    }    

    // Prueft, ob die Weckzeit erreicht ist und aktiviert dann den Alarm
    private void wecker_pruefeWeckzeit()
    {
        if (wecker_gibWeckzeit().equals(uhr_gibUhrzeit())) alarm = true;
    }

    // Liefert den Aktivierungszustand des Weckers
    public boolean wecker_gibWeckerEingeschaltet()
    {
         return weckerEingeschaltet;
    }
    
    // Liefert den Alarm
    public boolean wecker_gibAlarm()
    {
        return alarm;
    }

    // Startet die Stoppuhr
    public void stoppuhr_starten()
    {
        stoppuhrLaeuft = true;
    }
    
    // Stoppt die Stoppuhr
    public void stoppuhr_stoppen()
    {
        stoppuhrLaeuft = false;
    }
    
    // Stellt die Stoppuhr zurück auf Null
    public void stoppuhr_reset()
    {
        stoppuhr_stoppen();
        stoppuhr.setzeZeit(0, 0, 0);
    }

    // Liefert die aktuelle Stoppuhrzeit
    public String stoppuhr_gibStoppuhrzeit()
    {
        return stoppuhr.gibZeit();
    }
    
    // Liefert den Aktivierungszustand der Stoppuhr
    public boolean stoppuhr_gibStoppuhrLaeuft()
    {
        return stoppuhrLaeuft;
    }
}
/**
 * Die Klasse Uhrenanzeige simuliert eine Digitaluhr,
 * ... zur Darstellung von Stunden, Minuten und Sekunden. 
 * Autor:   Martin Lentz
 * Version: 01.10.2014
 */
public class Uhrenanzeige
{
    private Nummernanzeige stunden, minuten, sekunden;
    
    public Uhrenanzeige()
    {
        stunden = new Nummernanzeige(23);
        minuten = new Nummernanzeige(59);
        sekunden = new Nummernanzeige(59);
    }

    // Liefert die aktuelle Zeit 
    public String gibZeit()
    {
        return stunden.gibWert()+" : "+minuten.gibWert()+" : "+sekunden.gibWert();
    }
    
    // Stellt neue Zeit ein
    public void setzeZeit(int stunden, int minuten, int sekunden)
    {
        this.stunden.setzeWert(stunden);
        this.minuten.setzeWert(minuten);
        this.sekunden.setzeWert(sekunden);
    }
    
    // Erhöht die Zeit um einen Takt, d. h. um eine Sekunde 
    public void erhoeheZeit()
    {
        sekunden.erhoeheWert();
        if (sekunden.gibWert() == 0)
        {
            minuten.erhoeheWert();
            if (minuten.gibWert() == 0)
            {
                stunden.erhoeheWert();
            }
        }
    }
}
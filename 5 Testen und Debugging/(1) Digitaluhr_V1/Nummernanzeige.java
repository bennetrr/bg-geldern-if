/**
 * Die Klasse Nummernanzeige simuliert eine zweistellige Anzeige,
 * ... im Bereich von 0 bis limit.
 * Autor:   Martin Lentz
 * Version: 01.10.2014
 */
public class Nummernanzeige
{
    private int wert, limit;

    public Nummernanzeige(int limit)
    {
        setzeWert(0);
        this.limit = limit;
    }

    // Lese aktuellen Wert aus Nummernanzeige aus
    public int gibWert()
    {
        return wert;
    }
    
    // Setze Nummernanzeige auf neuen Wert
    public void setzeWert(int wert)
    {
        if ( (wert <= limit) && (wert >= 0) )
        {
            this.wert = wert;
        }
    }
    
    // Erhöhe aktuellen Wert der Nummernanzeige
    public void erhoeheWert()
    {
        wert = wert+1;
        if (wert > limit)
        {
            wert = 0;
        }
    }
}
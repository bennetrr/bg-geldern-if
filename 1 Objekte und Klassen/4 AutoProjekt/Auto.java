/**
 * Die Klasse Auto simuliert das Verhalten eines Autos.<br>
 * Autor:   Martin Lentz<br>
 * Version: 02.10.2006<br>
 */
public class Auto
{
    private String kennzeichen;
    private int maxGeschwindigkeit, geschwindigkeit;
    private boolean motorEingeschaltet;

    /**
     * Konstruktor für Objekte der Klasse Auto<br>
     * Kennzeichen und maxGeschwindigkeit werden abgefragt<br>
     */
    
    public Auto()
    {
        this("GEL-BK-123", 150);
    }
    
    public Auto(String kennzeichen, int maxGeschwindigkeit)
    {
        this.kennzeichen = kennzeichen;
        this.maxGeschwindigkeit = maxGeschwindigkeit;
        geschwindigkeit = 0;
        motorEingeschaltet = false;       
    }

    /**
     * Startet den Motor<br>
     * Setzt motorEingeschaltet auf true
     */
    public void starten()
    {
        motorEingeschaltet = true;
    }

    /**
     * Stoppt den Motor<br>
     * Setzt motorEingeschaltet auf false
     */
    public void stoppen()
    {
        motorEingeschaltet = false;
    }

    /**
     * Erhöhen der aktuellen Geschwindigkeit, wenn der Motor eingeschaltet<br>
     */
    public void beschleunigen()
    {
        if (motorEingeschaltet)
        {
            geschwindigkeit = geschwindigkeit + 10;
            if(geschwindigkeit > maxGeschwindigkeit)
            {
                geschwindigkeit = maxGeschwindigkeit;
            }
        }
    }

    /**
     * Verringern der aktuellen Geschwindigkeit
     */
    public void bremsen()
    {
        if (motorEingeschaltet)
        {
            geschwindigkeit = geschwindigkeit - 10;
            if (geschwindigkeit < 0)
            {
                geschwindigkeit = 0;
            }
        }
        if (motorEingeschaltet)
        {
            geschwindigkeit = geschwindigkeit - 1;
            if (geschwindigkeit < 0)
            {
                geschwindigkeit = 0;
            }
        }    

    }

    /**
     * Kennzeichen ändern
     */
    public void ummelden(String kennzeichenNeu)
    {
        kennzeichen = kennzeichenNeu;
    }

    /**
     * Liefert die aktuelle Geschwindigkeit
     */
    public int gibGeschwindigkeit()
    {
        return geschwindigkeit;
    }

    /**
     * Liefert das aktuelle Kennzeichen
     */
    public String gibKennzeichen()
    {
        return kennzeichen;
    }
}
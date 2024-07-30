/**
 * Die Klasse Heizung simuliert das verhalten einer Heizung (oder so änhlich...) 
 *
 * @author Bennet Ranft
 * @version 0.0.1
 */
public class Heizung
{
    // instance variables - replace the example below with your own
    private int temperatur;
    private int min;
    private int max;
    private int schrittweite;

    /**
     * Konstruktor der Klasse Heizung
     */
    public Heizung()
    {
        temperatur = 15;
        min = 10;
        max = 30;
        schrittweite = 5;
    }
    
    public Heizung(int temperatur, int min, int max, int schrittweite)
    {
        this.temperatur = temperatur;
        this.min = min;
        this.max = max;
        this.schrittweite = schrittweite;
    }

    /**
     * Liefert die Temperatur
     *
     * @return temperatur
     */
    public int gibTemperatur()
    {
        return temperatur;
    }
    
    /**
     * Liefert die Schrittweite
     *
     * @return    schrittweite
     */
    public int gibSchrittweite()
    {
        return schrittweite;
    }
    
    /**
     * Ändert die Schrittweite
     *
     * @param     schrittweite
     */
    public void setzeSchrittweite(int schrittweite)
    {
        this.schrittweite = schrittweite;
        if (schrittweite < 1)
        {
            this.schrittweite = 1;
        }
    }
    
    /**
     * Erhöht die Temperatur
     */
    public void waermer()
    {
        temperatur += schrittweite;
        if (temperatur > max)
        {
            temperatur = max;
        }
    }
    
    /**
     * Vermindert die Temperatur
     */
    public void kaelter()
    {
        temperatur -= schrittweite;
        if (temperatur < min)
        {
            temperatur = min;
        }
    }

}

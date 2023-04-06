/**
 * Die Klasse Heizung simuliert das Verhalten einer Heizung.
 * Autor:   Martin Lentz
 * Version: 10.12.2016
 */
public class Heizung
{
    // Eigenschaften
    private int temperatur, min, max, schrittweite;

    // Konstruktoren für Objekte der Klasse Heizung
    public Heizung()
    {
        min = 10;
        max = 30;
        temperatur = 15;
        setzeSchrittweite(5);
    }

    public Heizung(int neueTemperatur, int neuesMin, int neuesMax, int neueSchrittweite)
    {
        temperatur = neueTemperatur;
        min = neuesMin;
        max = neuesMax;
        setzeSchrittweite(neueSchrittweite);
    }

    // Liefert den aktuellen Temperaturwert
    public int gibTemperatur()
    {
        return temperatur;
    }

    // Liefert die aktuelle Schrittweite
    public int gibSchrittweite()
    {
        return schrittweite;
    }

    // Setzt die Schrittweite
    public void setzeSchrittweite(int neueSchrittweite)
    {
        if (neueSchrittweite > 0)
        {
            schrittweite = neueSchrittweite;
        }
        else if (neueSchrittweite < 0)
        {
            schrittweite = -neueSchrittweite;
        }
        else
        {
            schrittweite = 5;
        }
    }   

    // Erhöhen der Temperatur
    public void waermer()
    {
        if (temperatur+schrittweite <= max)
        {
            temperatur = temperatur+schrittweite;
        }
        else
        {
            temperatur = max;
        }
    }

    // Absenken der Temperatur
    public void kuehler()
    {
        if (temperatur-schrittweite >= min)
        {
            temperatur = temperatur-schrittweite;
        }
        else
        {
            temperatur = min;
        }
    }
}
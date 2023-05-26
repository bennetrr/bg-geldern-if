public class Zaehler
{
    private int wert;
    private int maxWert;

    public Zaehler(int startWert, int maxWert)
    {
        setzeWert(startWert);
        this.maxWert = maxWert;
    }

    public int gibWert()
    {
        return wert;
    }

    public void setzeWert(int wert)
    {
        this.wert = wert;
        if(this.wert >= maxWert || this.wert <= 0) this.wert = 0;
    }

    public void erhoeheWert(int wert)
    {
        this.wert += wert;
        if(this.wert >= maxWert || this.wert <= 0) this.wert = 0;
    }
}

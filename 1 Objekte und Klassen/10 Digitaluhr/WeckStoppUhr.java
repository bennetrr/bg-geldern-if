public class WeckStoppUhr
{
    private Uhr uhr;
    private Uhr weckzeit;
    private Uhr stoppuhrZeit;
    private boolean weckerStatus;
    private boolean stoppuhrStatus;
    private int schlummeranzahl;

    // Konstruktor
    public WeckStoppUhr()
    {
        uhr = new Uhr();
        weckzeit = new Uhr();
        stoppuhrZeit = new Uhr();
        weckerStatus = false;
        stoppuhrStatus = false;
    }

    // Uhr
    public void erhoeheZeit()
    {
        uhr.erhoeheSekunden();
        System.out.println("Zeit: " + uhr.gibZeit());
    }

    public void setzeZeit(int stunden, int minuten, int sekunden)
    {
        uhr.setzeZeit(stunden, minuten, sekunden);
    }

    // Wecker
    public void testeWeckzeit()
    {
        if(weckerStatus && weckzeit.equals(uhr))
        {
            System.out.println("Der Wecker klingelt!");
            snooze();
        }
    }

    public void setzeWeckzeit(int stunden, int minuten){
        weckzeit.setzeZeit(stunden, minuten, 0);
    }

    public void weckerAn()
    {
        weckerStatus = true;
    }

    public void weckerAus()
    {
        weckerStatus = false;
        for(int i = 0; i < 24*60*60-schlummeranzahl*60*5; i++)
        {
            weckzeit.erhoeheSekunden();
        }
        schlummeranzahl = 0;
    }

    public String gibWeckzeit()
    {
        return weckzeit.gibZeit();
    }

    public boolean gibWeckerStatus()
    {
        return weckerStatus;
    }

    public void erhoeheWeckzeit(int stunden, int minuten)
    {
        weckzeit.erhoeheZeit(stunden, minuten, 0);
    }

    public void snooze(){
        if(weckerStatus && weckzeit.equals(uhr))
        {
            erhoeheWeckzeit(0, 5);
        }
        schlummeranzahl++;
    }

    // Stoppuhr
    public void erhoeheStoppuhr()
    {
        if(stoppuhrStatus)
        {
            stoppuhrZeit.erhoeheSekunden();
            System.out.println("Stoppuhr-Zeit: " + stoppuhrZeit.gibZeit());
        }
    }

    public void setzeStoppuhrZeit(int stunden, int minuten, int sekunden){
        stoppuhrZeit.setzeZeit(stunden, minuten, sekunden);
    }

    public void stoppuhrReset()
    {
        setzeStoppuhrZeit(0, 0, 0);
    }

    public void stoppuhrAn()
    {
        stoppuhrStatus = true;
    }

    public void stoppuhrAus()
    {
        stoppuhrStatus = false;
    }

    public String gibStoppuhrZeit()
    {
        return stoppuhrZeit.gibZeit();
    }

    public boolean gibStoppuhrStatus()
    {
        return stoppuhrStatus;
    }
}
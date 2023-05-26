public class Uhr
{
    public Zaehler sekunden = new Zaehler(0, 60);
    public Zaehler minuten = new Zaehler(0, 60);
    public Zaehler stunden = new Zaehler(0, 24);
    
    public String gibZeit()
    {
        String text = "";
        if(stunden.gibWert() < 10) text += "0" + stunden.gibWert();
        else text += stunden.gibWert();
        text += ":";        
        if(minuten.gibWert() < 10) text += "0" + minuten.gibWert();
        else text += minuten.gibWert();
        text += ":";
        if(sekunden.gibWert() < 10) text += "0" + sekunden.gibWert();
        else text += sekunden.gibWert();
        return text;
    }

    public boolean equals(Uhr o) {
        if (stunden.gibWert() == o.stunden.gibWert() && minuten.gibWert() == o.minuten.gibWert() && sekunden.gibWert() == o.sekunden.gibWert()) return true;
        else return false;
    }
    
    public void setzeZeit(int stunden, int minuten, int sekunden)
    {
        this.stunden.setzeWert(stunden);
        this.minuten.setzeWert(minuten);
        this.sekunden.setzeWert(sekunden);
    }
     
    public void erhoeheSekunden()
    {
        sekunden.erhoeheWert(1);
        if(sekunden.gibWert() == 0) minuten.erhoeheWert(1);        
        if(minuten.gibWert() == 0 && sekunden.gibWert() == 0) stunden.erhoeheWert(1);
    }

    public void erhoeheZeit(int stunden, int minuten, int sekunden)
    {
        this.sekunden.erhoeheWert(sekunden);
        if(this.sekunden.gibWert() == 0) this.minuten.erhoeheWert(1);
        this.minuten.erhoeheWert(minuten);
        if(this.minuten.gibWert() == 0 && this.sekunden.gibWert() == 0) this.stunden.erhoeheWert(1);
        this.stunden.erhoeheWert(stunden);
    }
}
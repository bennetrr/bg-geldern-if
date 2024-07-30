public class Turbine
{
    private int drehzahl;
    
    public Turbine(){
        drehzahl = 0;
    }
    
    public int gibDrehzahl(){
        return drehzahl;
    }
    
    public void setzeDrehzahl(int drehzahl){
       this.drehzahl = drehzahl;
    }
}
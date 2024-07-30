public class Fahrwerk
{
    private boolean ausgefahren;
    
    public Fahrwerk(){
        ausgefahren = true;
    }
    
    public void ausfahren(){
        ausgefahren = true;
    }
    
    public void einfahren(){
        ausgefahren = false;
    }
}

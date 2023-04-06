
/**
 * Klasse Schiebetor.
 * 
 * @author Bennet Ranft
 * @version 0.0.1
 */
public class Schiebetor
{
    private int schrittweite, oeffnungsbreite, maxOeffnungsbreite;
    private boolean verriegelt;
    private String waertername;

    /**
     * Konstruktor für Objekte der Klasse Schiebetor
     */
    public Schiebetor(int schrittweite, String waertername)
    {
        this.schrittweite = schrittweite;
        this.waertername = waertername;
        maxOeffnungsbreite = 300;
        oeffnungsbreite = 0;
        waertername = "";
        verriegelt = true;
    }

    /**
     * Verriegelt das Tor
     */
    public void oeffnen()
    {
        verriegelt = false;
    }

    /**
     * Verriegelt das Tor
     */
    public void verriegeln()
    {
        if(oeffnungsbreite <= 0) verriegelt = true;
    }

    /**
     * Fährt das Tor einen Schritt auf
     */
    public String schrittweiseAuffahren()
    {
        if(verriegelt) oeffnen();
        oeffnungsbreite += schrittweite;
        if(oeffnungsbreite >= maxOeffnungsbreite)
        {
            oeffnungsbreite = maxOeffnungsbreite;
            return("Max. Öffnungsbreite ist erreicht");
        }
        return("Öffnungsbreite: " + oeffnungsbreite);
    }

    /**
     * Fährt das Tor einen Schritt zu
     */
    public String schrittweiseZufahren()
    {
        oeffnungsbreite -= schrittweite;
        if(oeffnungsbreite <= 0)
        {
            oeffnungsbreite = 0;
            verriegeln();
            return("Tor ist geschlossen und verriegelt");
        }
        return("Öffnungsbreite: " + oeffnungsbreite);
    }
    
    public String oeffnenFuerAuto()
    {
        if(verriegelt) oeffnen();
        oeffnungsbreite = maxOeffnungsbreite;
        return("Max. Öffnungsbreite ist erreicht");
    }
    
    public String ganzZufahren()
    {
        oeffnungsbreite = 0;
        verriegeln();
        return("Tor ist geschlossen und verriegelt");
    }
    
    public String gibWaertername()
    {
        return waertername;
    }
    
    public void waerterWechsel(String waertername)
    {
        this.waertername = waertername;
    }
}

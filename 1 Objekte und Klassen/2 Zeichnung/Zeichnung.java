
/**
 * Diese Klasse definiert eine einfache Zeichnung. Um die Zeichnung auf
 * dem Bildschirm anzeigen zu lassen, muss die zeichne-Operation auf
 * einem Exemplar aufgerufen werden.
 * Aber hier steckt mehr drin: Da es eine elektronische Zeichnung ist,
 * kann sie ge�ndert werden. Man kann sie schwarz-wei� anzeigen lassen
 * und dann wieder in Farbe (nachdem sie gezeichnet wurde, ist ja klar).
 * 
 * Diese Klasse ist als fr�hes Java-Lehrbeispiel mit BlueJ gedacht.
 * 
 * @author  Michael K�lling und David J. Barnes
 * @version 1.0  (3. Januar 2003)
 */
public class Zeichnung
{
    private Quadrat wand;
    private Quadrat fenster;
    private Dreieck dach;
    private Kreis sonne;

    /**
     * Erzeuge ein Exemplar der Klasse Zeichnung
     */
    public Zeichnung()
    {
        // nichts zu tun hier, alle Exemplarvariablen werden automatisch
        // mit null initialisiert.
    }

    /**
     * Zeichne die Zeichnung.
     */
    public void zeichne()
    {
        wand = new Quadrat();
        wand.vertikalBewegen(80);
        wand.groesseAendern(100);
        wand.sichtbarMachen();
        
        fenster = new Quadrat();
        fenster.farbeAendern("schwarz");
        fenster.horizontalBewegen(20);
        fenster.vertikalBewegen(100);
        fenster.sichtbarMachen();

        dach = new Dreieck();  
        dach.groesseAendern(50, 140);
        dach.horizontalBewegen(60);
        dach.vertikalBewegen(70);
        dach.sichtbarMachen();

        sonne = new Kreis();
        sonne.farbeAendern("gelb");
        sonne.horizontalBewegen(180);
        sonne.vertikalBewegen(-10);
        sonne.groesseAendern(60);
        sonne.sichtbarMachen();
    }
    
    
    /**
     * Bewegt die Sonne nach unten.
     */
    public void sonnenuntergang()
    {
        sonne.langsamVertikalBewegen(550);        
        sonne.sichtbarMachen();
    }

     /**
      * �ndere die Darstellung in schwarz-wei�.
      */
    public void inSchwarzWeissAendern()
    {
        if(wand != null)   // nur wenn schon gezeichnet wurde ...
        {
            wand.farbeAendern("schwarz");
            fenster.farbeAendern("weiss");
            dach.farbeAendern("schwarz");
            sonne.farbeAendern("schwarz");
        }
    }

    /**
     * �ndere die Darstellung in Farbe.
     */
    public void inFarbeAendern()
    {
        if(wand != null)   // nur wenn schon gezeichnet wurde ...
        {
            wand.farbeAendern("rot");
            fenster.farbeAendern("schwarz");
            dach.farbeAendern("gruen");
            sonne.farbeAendern("gelb");
        }
    }

}

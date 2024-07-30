
/**
 * Klasse Pig
 * 
 * @author Bennet Ranft 
 * @version 0.0.1
 */
public class Pig
{
    private int posX, posY;
    private boolean treffer;

    /**
     * Konstruktor für Objekte der Klasse Pig
     */
    public Pig(int x, int y)
    {
        setzePosition(x, y);
        treffer = false;
    }

    /**
     * Setzt die Position
     * 
     * @param  x, y
     */
    public void setzePosition(int x, int y)
    {
        if(treffer == false)
        {
            if(x >= 0 && x <= 200 && y >= 0 && y <= 200)
            {
                posX = x;
                posY = y;
            }
            else
            {
                setzePosition(0, 0);
            }
        }
    }
    
    /**
     * Geht 10 nach Links
     */
    public void fluechteLinks()
    {
        setzePosition(posX - 10, posY);
    }
    
    /**
     * Geht 10 nach Rechts
     */
    public void fluechteRechts()
    {
        setzePosition(posX + 10, posY);
    }
    
    /**
     * Gibt die Position X
     * 
     * @return  x
     */
    public int gibPosX()
    {
        return posX;
    }
    
    /**
     * Gibt die Position Y
     * 
     * @return  y
     */
    public int gibPosY()
    {
        return posY;
    }
    
    /**
     * Setzt den Treffer-Status
     * 
     * @param  treffer
     */
    public void setzeTreffer(boolean treffer)
    {
        if(treffer == true) setzePosition(0, 0);
        this.treffer = treffer;
    }
    
    /**
     * Gibt den Treffer-Status
     * 
     * @return  treffer
     */
    public boolean gibTreffer()
    {
        return treffer;
    }
}

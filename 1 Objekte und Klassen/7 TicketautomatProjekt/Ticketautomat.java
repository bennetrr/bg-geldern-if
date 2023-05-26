/**
 * Die Klasse Ticketautomat modelliert einfache Ticketautomaten,
 * die Tickets zu einem Einheitspreis herausgeben.
 * Der Preis f�r die Tickets eines Automaten kann �ber den Konstruktor
 * festgelegt werden.<br>
 * Autor:   Martin Lentz<br>
 * Version: 02.10.2006<br>
 */
public class Ticketautomat
{
    private int preis;
    private int anzahlung;
    private int bestand;

    /**
     * Erzeugt einen Automaten, der Tickets zum angegebenen Preis (in Cent) ausgibt
     * 
     * @param      Preis in Cent
     */
    public Ticketautomat(int preis)
    {
        this.preis = preis;
        anzahlung = 0;
        bestand = 0;
    }

    /**
     * Anderer Konstruktor mit vorgegebenem Preis von 350 Cent
     */
    public Ticketautomat()
    {
        this(350);
    }

    /**
     * Gibt den Preis
     * 
     * @return Preis in Cent
     */
    public int gibPreis()
    {
        return preis;
    }

    /**
     * Gibt den eingezahlten Betrag
     * 
     * @return Anzahlung
     */
    public int gibAnzahlung()
    {
        return anzahlung;
    }

    /**
     * Gibt das Geld, was schon mit dem Verkauf von Tickets verdient wurde
     * 
     * @return Bestand
     */
    public int gibBestand()
    {
        return bestand;
    }

    /**
     * �ndert den Preis f�r ein Ticket, wenn der eingegebene Wert gr��er als 0 ist
     * 
     * @param preis
     */
    public void setzePreis(int preis)
    {
        if (preis > 0)
        {
            this.preis = preis;
        }
    }

    /**
     * F�gt Geld zu der Anzahlung hinzu.
     * 
     * @param Betrag
     */
    public void geldEinwerfen(int betrag)
    {
        if (betrag > 0)
        {
            anzahlung += betrag;
        }
    }

    /** 
     * "Druckt" ein Ticket und zieht das Geld von der Anzahlung ab, wenn gen�gend Geld eingeworfen wurde, bzw. gibt eine Fehlermeldung aus, falls nicht genug Geld vorhanden ist
     * 
     * @return Ticket f�r die BlueJ-Linie ... Ticketpreis: xxx Cent
     * @return Sie haben noch nicht gen�gend Geld eingeworfen.
     */
    public String ticketDrucken()
    {
        String ticket;
        if (anzahlung >= preis)
        {
            // Den Ausdruck eines Tickets simulieren
            ticket = "Ticket f�r die BlueJ-Linie ... Ticketpreis: ";
            ticket += preis + " Cent.";

            // Die Geldsumme, die bisher von diesem Automaten eingenommen wurde um den Ticketpreis erh�hen
            bestand = bestand+preis;

            // Den Preis von der bisherigen Bezahlung abziehen
            anzahlung = anzahlung-preis;
        }
        else
        {
            int preisVerbleibend;
            preisVerbleibend = preis - anzahlung;
            ticket = "Sie m�sssen noch ";
            ticket += preisVerbleibend + " Cent einwerfen.";
        }
        return ticket;
    }

    /**
     * Gibt die Anzahlung / den Rest der Anzahlung
     * 
     * @return wechselgeld
     */
    public int wechselgeldAuszahlen()
    {
        int wechselgeld;
        wechselgeld = anzahlung;
        anzahlung = 0;
        return wechselgeld;
    }

    /**
     * Gibt das verdiente Geld aus.
     * 
     * @return gewinn
     */
    public int leeren()
    {
        int gewinn;
        gewinn = bestand;
        bestand = 0;
        return gewinn;
    }
}
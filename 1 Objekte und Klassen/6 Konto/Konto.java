
/**
 * Klasse Konto.
 * 
 * @author Bennet Ranft 
 * @version 0.0.1
 */
public class Konto
{
    private int kontoNr, saldo;
    private String aktivitaet;

    /**
     * Konstruktor für Objekte der Klasse Konto
     */
    public Konto(int kontoNr)
    {
        this.kontoNr = kontoNr;
        saldo = 0;
        aktivitaet = "";
    }

    /**
     * gibt die Kontonummer
     * 
     * @return        Kontonummer
     */
    public int gibKontoNr()
    {
        return kontoNr;
    }

    /**
     * gibt den Kontostand (Saldo)
     * 
     * @return        saldo
     */
    public int gibSaldo()
    {
        return saldo;
    }

    /**
     * Test für Beträge
     * 
     * @param        betrag
     * @return       true oder false
     */
    private boolean betragOK(int betrag)
    {
        if(betrag > 0 && betrag % 5 == 0)
        {
            return true;
        }
        return false;
    }

    /**
     * Zahlt Beträge ein
     * 
     * @param        betrag
     * @return       saldo
     */
    public void einzahlen(int betrag)
    {
        if(betragOK(betrag))
        {
            saldo += betrag;
            neueAktivitaet(betrag, "+");
        }
    }

    /**
     * Zahlt Beträge aus
     * 
     * @param        betrag
     * @return       saldo
     */
    public void auszahlen(int betrag)
    {
        if(betragOK(betrag) && saldo - betrag > 0)
        {
            saldo -= betrag;
            neueAktivitaet(betrag, "-");
        }
    }

    /**
     * Fügt eine Kontoaktivität hinzu
     * 
     * @param        betrag, aktion
     */
    private void neueAktivitaet(int betrag, String aktion)
    {
        aktivitaet +=  new java.util.Date().toString() + ": " + aktion + betrag + " €             ";
    }

    /**
     * Gibt die Kontobewegung
     * 
     * @return       aktivität
     */
    public String gibAktivitaet()
    {
        return aktivitaet;
    }
}
public class Parkautomat
{
    private Parktarif tarifPrivat;
    private Parktarif tarifGeschaeftlich;
    private double parkkosten;
    private double bestand;

    public Parkautomat()
    {
        tarifGeschaeftlich = new Parktarif(1, 1);
        tarifPrivat = new Parktarif(3, 2);
        parkkosten = 0;
        bestand = 0;
    }

    public void ermittleParkkosten(boolean geschäftskunde, int parkdauer)
    {
        if(geschäftskunde) {
            parkkosten = (double) tarifGeschaeftlich.berechneParkkosten(parkdauer);
        } else {
            parkkosten = (double) tarifPrivat.berechneParkkosten(parkdauer);
        }
    }

    public double gibParkkosten()
    {
        return parkkosten;
    }

    public double geldEinwerfen(double muenzwert)
    {
        if(muenzwert >= parkkosten) {
            double rest = muenzwert - parkkosten;
            /*double bezahlen = parkkosten;
            parkkosten -= bezahlen;
            bestand += bezahlen;*/
            bestand += parkkosten;
            parkkosten = 0;
            return rest;
        } else {
            parkkosten -= muenzwert;
            bestand += muenzwert;
            return 0;
        }
    }
}
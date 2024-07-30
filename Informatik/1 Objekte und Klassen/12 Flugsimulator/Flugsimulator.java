public class Flugsimulator {
    private Ruder hoehenruder;
    private Ruder seitenruder;
    private Ruder querruder;
    private Turbine turbine1;
    private Turbine turbine2;
    private Fahrwerk fahrwerk;

    private boolean an;

    /*
    Positionen der Ruder

    Höhenruder / Querruder:
    pos1: Oben
    pos2: Mitte
    pos3: Unten

    Seitenruder:
    pos1: Rechts
    pos2: Mitte
    pos3: Links
     */

    public Flugsimulator() {
        hoehenruder = new Ruder();
        seitenruder = new Ruder();
        querruder = new Ruder();
        turbine1 = new Turbine();
        turbine2 = new Turbine();
        fahrwerk = new Fahrwerk();
        an = false;
    }

    public void starten() {
        an = true;
        fahrwerk.einfahren();
        seitenruder.pos2();
        hoehenruder.pos1();
        querruder.pos1();
        turbine1.setzeDrehzahl(30000);
        turbine2.setzeDrehzahl(30000);
    }

    public void landen(){
        fahrwerk.ausfahren();
        seitenruder.pos2();
        hoehenruder.pos3();
        querruder.pos3();
        turbine1.setzeDrehzahl(0);
        turbine2.setzeDrehzahl(0);
        an = false;
    }

    public void beschleunigen(){
        turbine1.setzeDrehzahl(turbine1.gibDrehzahl()+1000);
        turbine2.setzeDrehzahl(turbine2.gibDrehzahl()+1000);
    }

    public void bremsen(){
        turbine1.setzeDrehzahl(turbine1.gibDrehzahl()-1000);
        turbine2.setzeDrehzahl(turbine2.gibDrehzahl()-1000);
    }

    public void rechts(){
        hoehenruder.pos2();
        querruder.pos2();
        seitenruder.pos1();
    }

    public void links(){
        hoehenruder.pos2();
        querruder.pos2();
        seitenruder.pos3();
    }

    public void oben(){
        seitenruder.pos2();
        hoehenruder.pos1();
        querruder.pos1();
    }

    public void unten(){
        seitenruder.pos2();
        hoehenruder.pos3();
        querruder.pos3();
    }
}

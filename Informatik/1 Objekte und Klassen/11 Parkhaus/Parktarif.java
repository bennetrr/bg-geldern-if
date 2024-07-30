public class Parktarif
{
	private int preisErsteStunde;
	private int preisWeitereStunde;

	public Parktarif(int PreisErsteStunde, int PreisWeitereStunde)
	{
	    this.preisErsteStunde = PreisErsteStunde;
	    this.preisWeitereStunde = PreisWeitereStunde;
	}
	
	public int berechneParkkosten(int parkdauer)
	{
	    parkdauer = parkdauer-1;
	    return preisErsteStunde + parkdauer*preisWeitereStunde;
	}
}
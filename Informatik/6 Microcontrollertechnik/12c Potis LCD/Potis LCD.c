#include <reg517A.h>
#include <lcd.h>

void initADU();
void ausgabeBeschriftung();
void ausgabeMesswert(int, int);

bit probeP70;

void main()
{
	int spannung;
	
	P1 = 0;
	P4 = 0;
	
	initADU();
	initialisierungLCD();
	ausgabeBeschriftung();
	
	while (1) {
		while (BSY);
		
		spannung = ADDATH / 255.0 * 5000;
		ausgabeMesswert(!probeP70, spannung);
		
		if (probeP70) {
			ADCON1 = (ADCON1 & 0xF0) | 0x01;  // 0bxxxx0001
		} else {
			ADCON1 = ADCON1 & 0xF0;  // 0bxxxx0000
		}
		
		probeP70 = !probeP70;
		ADDATL = 0;
	}
}

void initADU()
{
	ADEX = 0;
	ADM = 1;
	ADCON1 = ADCON1 & 0x70;  // 0b0xxx0000
	probeP70 = 1;
	ADDATL = 0;
}

void ausgabeBeschriftung()
{
	char spaltenNr;
	unsigned char text1[] = "U_P7.0 = .... mV";
	unsigned char text2[] = "U_P7.1 = .... mV";
		
	// Ausgabe der Beschriftung im LC-Display
	cursorposition(0, 0);
	for (spaltenNr = 0; spaltenNr < 16; spaltenNr++)
	{
		schreiben(text1[spaltenNr]);
	}
	
	cursorposition(1, 0);
	for (spaltenNr = 0; spaltenNr < 16; spaltenNr++)
	{
		schreiben(text2[spaltenNr]);
	}
}

void ausgabeMesswert(int zeile, int messwert)
{
	char stelle[4], stellenNr;

	// Stellen (Tausender, Hunderter Zehner, Einer) ermitteln
	// (... alternativ mit dem Modulo-Operator)
	stelle[3] = messwert/1000;
	stelle[2] = (messwert-stelle[3]*1000)/100;
	stelle[1] = (messwert-stelle[3]*1000-stelle[2]*100)/10;
	stelle[0] = messwert-stelle[3]*1000-stelle[2]*100-stelle[1]*10;
		
	// Ausgabe des Messwertes im LC-Display
	cursorposition(zeile, 9);
	for (stellenNr = 3; stellenNr > -1; stellenNr--)
	{
		schreiben(stelle[stellenNr]);
	}
}

#include <reg517A.h>
#include <lcd.h>

void initIsrADU();
void ausgabeBeschriftung();
void ausgabeMesswert(int);

void main()
{
	int spannung;
	
	P1 = 0;
	P4 = 0;
	
	initIsrADU();
	initialisierungLCD();
	ausgabeBeschriftung();
	
	// Global enable
	EAL = 1;
	
	while (1) {
		while (BSY);
		
		spannung = ADDATH / 255.0 * 5000;
		ausgabeMesswert(spannung);
		ADDATL = 0;
	}
}

void initIsrADU()
{
	ADEX = 0;
	ADM = 1;
	ADCON1 = ADCON1 & 0x70;  // 0b0xxx0000
	ADDATL = 0;
}

void ausgabeBeschriftung()
{
	char spaltenNr;
	unsigned char text[] = "U_P7.0 = .... mV";
		
	// Ausgabe der Beschriftung im LC-Display
	cursorposition(0, 0);
	for (spaltenNr = 0; spaltenNr < 16; spaltenNr++)
	{
		schreiben(text[spaltenNr]);
	}
}

void ausgabeMesswert(int messwert)
{
	char stelle[4], stellenNr;

	// Stellen (Tausender, Hunderter Zehner, Einer) ermitteln
	// (... alternativ mit dem Modulo-Operator)
	stelle[3] = messwert/1000;
	stelle[2] = (messwert-stelle[3]*1000)/100;
	stelle[1] = (messwert-stelle[3]*1000-stelle[2]*100)/10;
	stelle[0] = messwert-stelle[3]*1000-stelle[2]*100-stelle[1]*10;
		
	// Ausgabe des Messwertes im LC-Display
	cursorposition(0, 9);
	for (stellenNr = 3; stellenNr > -1; stellenNr--)
	{
		schreiben(stelle[stellenNr]);
	}
}

#include <absacc.h>		// Bekanntgabe des Befehls XBYTE[] s. u.

// Warten, bis der Display-Controller HD44780 fertig ist (Busy-Flag = 0)
void warten()
{
	// Hinweis: Mit XBYTE[] wird über das externe Bussystem auf externe
	// Peripheriegeräte - in diesem Fall das LC-Display - zugegriffen!
	while(XBYTE[0xFF81]&0x80);
}

// Initialisierung des LC-Displays: 
// - Zweizeiliges Display, Punktmatrix mit 5x7 Punkten, 8-Bit-Modus
// - Eingeschaltetes, gelöschtes Display, mit unsichtbarem Cursor
// - Automatische Inkrementierung der Cursorposition nach dem Schreiben
void initialisierungLCD()
{
	int i;
	unsigned char befehl[6] = {0x30, 0x30, 0x38, 0x0C, 0x01, 0x06};

	for(i = 0; i < 6; i++)
	{
		XBYTE[0xFF80] = befehl[i];
		warten();
	}
}

// Cursor auf 'zeile' 0 bzw. 1 und 'spalte' 0, 1, 2, ... oder 15 positionieren
void cursorposition(char zeile, char spalte)
{
	if (zeile==1) zeile = 0x40;
	XBYTE[0xFF80]=0x80+zeile+spalte;
	warten();
}

// Schreiben eines Zeichens an die aktuelle Cursorposition
void schreiben(unsigned char zeichen)
{
	if (zeichen < 10) zeichen = zeichen+0x30;
	XBYTE[0xFF82] = zeichen;
	warten();
}
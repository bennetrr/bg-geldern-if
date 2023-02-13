#include <reg517A.h>

sbit P32 = 0xB2;  // Starten
sbit P34 = 0xB4;  // Lichtschranke

sbit P41 = 0xE9;  // Förderband

void initIsrP32();
void initIsrP33();
void initIsrT0();

void main()
{
	P41 = 0;
	
	initIsrP32();
	P34 = 1;
	initIsrT0();
	
	// Global enable
	EAL = 1;
	
	while (1) {
		//pass
	}
}

void initIsrP32()
{
	P32 = 1;
	IT0 = 1;
	IE0 = 0;
	EX0 = 1;
}

void initIsrT0()
{
	TF0 = 0;                      // Interrupt bei Overflow
	TR0 = 1;                      // Timer run
	TMOD = (TMOD & 0xF0) | 0x06;  // Mode: 0b0110
	TH0 = 250;                    // Neuer Wert bei Overflow
	TL0 = 250;                    // Startwert
	ET0 = 1;                      // Enable
}

void isrT0() interrupt 1
{
	P41 = 0;
}

void isrP32() interrupt 0
{
	P41 = 1;
}

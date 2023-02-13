#include <reg517A.h>

sbit P50 = 0xF8;
sbit P40 = 0xE8;
sbit P41 = 0xE9;

void initIsrT0();
void initIsrT1();

bit takt_10kHz;
bit takt_1Hz;
int takt_1Hz_cycles;

void main()
{
	initIsrT0();
	initIsrT1();
	
	// Global enable
	EAL = 1;
	
	while (1) {
		P40 = takt_10kHz;
		if (P50) P41 = takt_1Hz;
	}
}

void initIsrT0()
{
	TF0 = 0;                      // Interrupt bei Overflow
	TR0 = 1;                      // Timer run
	TMOD = (TMOD & 0xF0) | 0x02;  // Mode: 0b0010
	TH0 = 189;                    // Neuer Wert bei Overflow
	TL0 = 189;                    // Startwert
	ET0 = 1;                      // Enable
}

void initIsrT1()
{
	TF1 = 0;                      // Interrupt bei Overflow
	TR1 = 1;                      // Timer run
	TMOD = (TMOD & 0x0F) | 0x10;  // Mode: 0b0001
	TH1 = 0xD3;                   // Neuer Wert bei Overflow
	TL1 = 0xD5;                   // Startwert
	takt_1Hz_cycles = 0;
	ET1 = 1;                      // Enable
}

void isrT0() interrupt 1
{
	takt_10kHz = !takt_10kHz;
}

void isrT1() interrupt 3
{
	takt_1Hz_cycles++;
	
	if (takt_1Hz_cycles >= 11) {
		takt_1Hz = !takt_1Hz;
		initIsrT1();
	}
}

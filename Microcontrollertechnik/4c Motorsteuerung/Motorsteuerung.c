#include <reg517A.h>

sbit P10 = 0x90;
sbit P32 = 0xB2;

sbit P50 = 0xF8;
sbit P51 = 0xF9;
sbit P52 = 0xFA;

void initIsrP10();
void initIsrP32();

void main()
{
	P50 = 0;
	P51 = 0;
	P52 = 0;
	
	initIsrP10();
	initIsrP32();
	
	// Global enable
	EAL = 1;
	
	while (1) {
		//pass
	}
}

void initIsrP10()
{
	// P1.0
	P10 = 1;
	I3FR = 1;
	IEX3 = 0;
	EX3 = 1;
}

void initIsrP32()
{
	// P3.2
	P32 = 1;
	IT0 = 1;
	IE0 = 0;
	EX0 = 1;
}

void isrP10() interrupt 10
{
	P50 = 1;
	P51 = 1;
	P52 = 1;
}

void isrP32() interrupt 0
{
	P50 = 0;
	P51 = 0;
	P52 = 0;
}

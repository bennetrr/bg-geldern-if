#include <reg517A.h>

void initIsrADU();

void main()
{
	P1 = 0;
	P4 = 0;
	
	initIsrADU();
	
	// Global enable
	EAL = 1;
	
	while (1) {
		//pass
	}
}

void initIsrADU()
{
	ADEX = 0;
	ADM = 1;
	ADCON1 = ADCON1 & 0x70;  // 0b0xxx0000
	ADDATL = 0;
	IADC = 0;
	EADC = 1;
}

void isrADU() interrupt 8
{
	P4 = ADDATH;
	ADDATL = 0;
	IADC = 0;
}

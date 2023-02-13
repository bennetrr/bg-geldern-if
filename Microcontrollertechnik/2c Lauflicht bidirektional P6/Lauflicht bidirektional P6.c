#include <reg517A.h>

void main()
{
	int i;
	int value = 1;

	P1 = 0;

	while (1)
	{	
		if (P6 & 1 == 1) {
			value = value << 1;
		} else {
			value = value >> 1;
		}
		if (value >= 255) {
			value = 1;
		}
		if (value <= 0) {
			value = 128;
		}
		P4 = value;
		for (i = 0; i < 30000; i++);
	}
}
#include <reg517A.h>

void main()
{
	int i;
	int value1 = 3;

	P1 = 0;

	while (1)
	{	
		while(value1 > 0 && value1 < 128) {
			value1 = value1 << 1;
			P4 = value1;
			for (i = 0; i < 30000; i++);
		}

		do {
			value1 = value1 >> 1;
			P4 = value1;
			for (i = 0; i < 30000; i++);
		} while(value1 > 3 && value1 <= 255);
	}
}
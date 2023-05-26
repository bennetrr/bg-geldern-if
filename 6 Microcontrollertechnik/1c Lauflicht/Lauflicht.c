#include <reg517A.h>

void main()
{
	int i;
	int value = 1;

	P1 = 0;

	while (1)
	{	
		value = value << 1;
		if (value >= 255) {
			value = 1;
		}
		P4 = value;
		for (i = 0; i < 30000; i++);
	}
}
#include <reg517A.h>

void main()
{
	int i;
	int j;

	P1 = 0;

	while (1)
	{
		for(j = 0; j <= 255; j++) {
			P4 = j;
			for (i = 0; i < 30000; i++);
		}
	}
}
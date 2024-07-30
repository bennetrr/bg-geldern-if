#include <reg517A.h>

void main()
{
	int i;

	P1 = 0;
	
	while (1)
	{
		P4 = 0;
 		for (i = 0; i < 30000; i++);
		P4 = 255;
		for (i = 0; i < 30000; i++);
	}
}
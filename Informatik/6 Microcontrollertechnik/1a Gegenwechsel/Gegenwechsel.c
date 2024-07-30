#include <reg517A.h>

void main()
{
	int i;

	P1 = 0;

	while (1)
	{
		P4 = 1;  //0b0000001
 		for (i = 0; i < 30000; i++);
		P4 = 128;  //0b1000000;
		for (i = 0; i < 30000; i++);
	}
}
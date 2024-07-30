#include <reg517A.h>
#include <math.h>

void main()
{
	int i;
	int s;

	P1 = 0;

	while (1)
	{	
		for (i = 1; i <= 8; i++) {
			P4 = pow(2, i)-1;
			for (s= 0; s < 30000; s++);
		}
	}
}
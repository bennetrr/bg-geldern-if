#include <reg517A.h>

void main()
{
	int i;
	int value = 1;
	bit status = 0;

	P1 = 0;
	P4 = 0;

	while (1)
	{	
		if ((P5 & 1) == 0) {
			status = 1;
		} 
		if ((P6 & 1) == 0) {
			status = 0;
		} 
		if (status) {
			value = value << 1;
			
			if (value >= 255) {
				value = 1;
			}
			
			P4 = value;	
			for (i = 0; i < 30000; i++);
		}
	}
}
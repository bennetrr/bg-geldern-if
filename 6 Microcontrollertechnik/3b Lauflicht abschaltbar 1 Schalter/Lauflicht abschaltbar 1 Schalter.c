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
			if (status) {
				status = 0;
			} else {
				status = 1;
			}
		}
		
		if (status) {
			value = value << 1;
			
			if (value >= 255) {
				value = 1;
			}
			
			P4 = value;	
			for (i = 0; i < 10; i++) {
				if ((P5 & 1) == 0) {
					if (status) {
						status = 0;
					} else {
						status = 1;
					}
				}
				for (i = 0; i < 3000; i++);
			}
		}
	}
}
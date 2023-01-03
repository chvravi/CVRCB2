#include<stdio.h>
#include<math.h>
main()
{
	int p,s,e,i,j;
	long int output;
	clrscr();
	printf("enter starting number :\n");
	scanf("%d",&s);
	printf("enter the ending number :\n");
	scanf("%d",&e);
	printf("enter the max power number :\n");
	scanf("%d",&p);

	printf("Number \t Powers ( 1 - %d ) :\n",p);

	for(j=s;j<=e;j++)
	{
		printf("%d\t",j);
		for(i=1;i<=p;i++)
		{
			output=pow(j,i);
			printf("%li\t",output);
		}
		printf("\n");
	}

	getch();
	return 0;
}